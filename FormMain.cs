using System;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace TitleSync
{
    public partial class FormMain : Form
    {
        private StringBuilder m_Sb;
        private FileSystemWatcher fsWatcher;
        private bool m_bDirty;
        private bool m_bIsWatching;
        private string _fileName;
        private string _token;


        public string FileName
        {
            get { return _fileName; }
            set
            {
                _fileName = value;
                txtFile.Text = _fileName;
            }
        }
        private string fullUrl;
        public FormMain()
        {
            InitializeComponent();


            m_Sb = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;
            _token = GetAppSetting("token");
            txEndpointUrl.Text = GetAppSetting("endpointUrl");
            FileName = GetAppSetting("lastPathFile");


            txtFile.Text = FileName;

            var fileContent = ReadFile(FileName);
            txtFileContent.Text = (fileContent != "0") ? fileContent : "";
        }

        private void BtnBrowseFile_Click(object sender, EventArgs e)
        {
            btnBrowseFile.Enabled = true;
            DialogResult resDialog = dlgOpenFile.ShowDialog();
            if (resDialog.ToString() == "OK")
            {

                FileName = dlgOpenFile.FileName;
                SetAppSetting("lastPathFile", FileName);
                txtFile.Text = FileName;
                txtFileContent.Clear();
                txtFileContent.AppendText(ReadFile(FileName));

            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {

            if (!m_bIsWatching)
            {

                try
                {
                    fsWatcher = new FileSystemWatcher
                    {
                        Path = Path.GetDirectoryName(txtFile.Text),
                        Filter = Path.GetFileName(txtFile.Text),
                        NotifyFilter = NotifyFilters.LastWrite
                    };
                    fsWatcher.Changed += new FileSystemEventHandler(OnChanged);
                    fsWatcher.EnableRaisingEvents = true;
                    lstNotification.Items.Clear();
                    btnBrowseFile.Enabled = false;
                    m_bIsWatching = true;
                    btnWatchFile.BackColor = Color.Red;
                    btnWatchFile.Text = "Stop";
                    ReadFileAndMakeRequest();
                }
                catch (Exception)
                {
                    MessageBox.Show("File can't be read");
                }

            }
            else
            {
                fsWatcher.Dispose();
                btnBrowseFile.Enabled = true;
                btnWatchFile.BackColor = Color.LimeGreen;
                btnWatchFile.Text = "CONNECT";
                m_bIsWatching = false;
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            ReadFileAndMakeRequest();
        }

        private void ReadFileAndMakeRequest()
        {
            if (!m_bDirty)
            {
                fullUrl = txEndpointUrl.Text + ReadFile(FileName) + "&token=" + _token;
                var response = MakeRequest(fullUrl);
                m_Sb.Clear();
                //m_Sb.Append(e.Name);
                //m_Sb.Append(" ");
                m_Sb.Append(DateTime.Now.ToString("HH:mm:ss"));
                m_Sb.Append(" - ");
                m_Sb.Append(response);
                lstNotification.Items.Add(m_Sb.ToString());
                m_bDirty = true;
            }
            else
            {
                m_bDirty = false;
            }
        }

        private string ReadFile(string _fileName)
        {
            try
            {

                XmlDocument xDoc = new XmlDocument();

                xDoc.Load(FileName);

                var artist = xDoc.SelectNodes("/Playlist/OnAir/CurMusic/Artist");
                var title = xDoc.SelectNodes("/Playlist/OnAir/CurMusic/Title");

                return artist[0].InnerText + " - " + title[0].InnerText;
                //StringBuilder content = new StringBuilder();
                //using (var fs = new FileStream(_fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                //using (var reader = new StreamReader(fs))
                //{
                //    string line;
                //    while ((line = reader.ReadLine()) != null)
                //    {
                //        content.Append(line);
                //    }
                //}
                //return content.ToString();

            }
            catch (Exception ex)
            {
                return ex.Data.Count.ToString();

            }
        }

        private string MakeRequest(string _fullUrl)
        {
            try
            {
                WebRequest request = WebRequest.Create(_fullUrl);
                using (WebResponse response = (WebResponse)request.GetResponse())
                {
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        // Open the stream using a StreamReader for easy access.  
                        StreamReader reader = new StreamReader(dataStream);
                        // Read the content.  
                        string responseFromServer = reader.ReadToEnd();
                        Console.WriteLine(responseFromServer + ":reader");
                        return responseFromServer;

                    }
                }
            }

            catch (WebException ex)
            {
                Console.WriteLine(ex.Message + "webex");
                return (ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "extion");
                return ex.Message;
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                NotifyIcon.Visible = true;
                NotifyIcon.BalloonTipTitle = "Running in Background";
                NotifyIcon.ShowBalloonTip(500);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NotifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void TokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string token = Prompt.ShowDialog("Insert Authentication Token", "");
            _token = token;
            SetAppSetting("token", token);

        }
        private void SetAppSetting(string _setting, string _value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[_setting].Value = _value;
            configuration.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private string GetAppSetting(string _setting)
        {
            return ConfigurationManager.AppSettings[_setting];
        }

        private void TxtEndpointUrl_TextChanged(object sender, EventArgs e)
        {
            SetAppSetting("endpointUrl", txEndpointUrl.Text);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

        }


    }
}