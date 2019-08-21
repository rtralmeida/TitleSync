using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace TitleSync
{
    public partial class FormMain : Form
    {
        private StringBuilder m_Sb;
        private FileSystemWatcher fsWatcher;
        private bool m_bDirty;
        private string _songTitle;
        private bool m_bIsWatching;
        private string _fileName;
        private string _fullUrl;


        public FormMain()
        {
            InitializeComponent();
            m_Sb = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;
            _fileName = txtFile.Text;

            _fullUrl = txtUrl.Text;
        }

        private void btnBrowseFile_Click(object sender, EventArgs e)
        {
            btnBrowseFile.Enabled = true;
            DialogResult resDialog = dlgOpenFile.ShowDialog();
            if (resDialog.ToString() == "OK")
            {
                txtFileContent.Text = "";
                _fileName = dlgOpenFile.FileName;
                txtFile.Text = _fileName;
                ReadFile(_fileName);
            }
        }


        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (!m_bIsWatching)
            {
                btnBrowseFile.Enabled = false;
                m_bIsWatching = true;
                btnWatchFile.BackColor = Color.Red;
                btnWatchFile.Text = "Stop";
                fsWatcher = new FileSystemWatcher
                {
                    Path = Path.GetDirectoryName(txtFile.Text),
                    Filter = Path.GetFileName(txtFile.Text),
                    NotifyFilter = NotifyFilters.LastWrite
                };
                fsWatcher.Changed += new FileSystemEventHandler(OnChanged);
                fsWatcher.EnableRaisingEvents = true;
            }
            else
            {
                btnBrowseFile.Enabled = true;
                btnWatchFile.BackColor = Color.LimeGreen;
                btnWatchFile.Text = "CONNECT";
                m_bIsWatching = false;
            }
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (!m_bDirty)
            {
                ReadFile(_fileName);
                var response = MakeRequest();
                m_Sb.Clear();
                m_Sb.Append(e.Name);
                m_Sb.Append(" ");
                m_Sb.Append(e.ChangeType.ToString());
                m_Sb.Append(DateTime.Now.ToString("HH:mm:ss"));
                m_Sb.Append(" - ");
                m_Sb.Append(response);
                m_bDirty = true;
                lstNotification.Items.Add(m_Sb.ToString());
                m_bDirty = true;
            }
            else
            {
                m_bDirty = false;
            }
        }


        private void ReadFile(string fileName)
        {
            txtFileContent.Clear();
            StringBuilder content = new StringBuilder();
            using (var fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) // prevent error already used by another proccess
            using (var reader = new StreamReader(fs))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    content.AppendLine(line);
                    _songTitle = line;
                }
            }
            txtFileContent.AppendText(content.ToString());

            _fullUrl = txtUrl.Text + _songTitle;

            lblFullUrl.Text = txtUrl.Text + _songTitle;

        }


        private void WriteFile(string text, string fileName = "token.txt")
        {

            File.WriteAllText(Application.StartupPath.ToString() + "\\" + @fileName, text);

        }

        private string MakeRequest()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_fullUrl);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
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
            WriteFile(token);

        }
    }
}