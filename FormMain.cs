using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using MaterialSkin.Controls;
using MaterialSkin;
using System.Threading.Tasks;

namespace TitleSync
{
    public partial class FormMain : MaterialForm
    {
        private StringBuilder m_Sb;
        private bool m_bDirty;
        private System.IO.FileSystemWatcher m_Watcher;
        private bool m_bIsWatching;
        private string _fileName;

        public FormMain()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo200, Accent.Pink200, TextShade.WHITE);

            //materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);


            m_Sb = new StringBuilder();
            m_bDirty = false;
            m_bIsWatching = false;
        }

        private void BtnWatchFile_Click(object sender, EventArgs e)
        {

            if (m_bIsWatching)
            {
                btnBrowseFile.Enabled = true;

                m_bIsWatching = false;
                btnWatchFile.BackColor = Color.Red;
                m_Watcher.EnableRaisingEvents = false;
                m_Watcher.Dispose();
                btnWatchFile.Text = "Start Watching";
            }
            else
            {
                m_bIsWatching = true;
                btnBrowseFile.Enabled = false;
                btnWatchFile.Text = "Stop Watching";

                m_Watcher = new FileSystemWatcher();

                m_Watcher.Filter = txtFile.Text.Substring(txtFile.Text.LastIndexOf('\\') + 1);
                m_Watcher.Path = txtFile.Text.Substring(0, txtFile.Text.Length - m_Watcher.Filter.Length);

                m_Watcher.NotifyFilter = NotifyFilters.LastWrite;
                //m_Watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName;
                m_Watcher.Changed += new FileSystemEventHandler(OnChanged);
                //m_Watcher.Created += new FileSystemEventHandler(OnChanged);
                //m_Watcher.Deleted += new FileSystemEventHandler(OnChanged);
                //m_Watcher.Renamed += new RenamedEventHandler(OnRenamed);
                m_Watcher.EnableRaisingEvents = true;

            }

        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            if (!m_bDirty)
            {
                var response = MakeRequest();
                m_Sb.Clear();
                m_Sb.Append(e.Name);
                m_Sb.Append(" ");
                m_Sb.Append(e.ChangeType.ToString());
                //m_Sb.Append(" - ");
                m_Sb.Append(DateTime.Now.ToString("HH:mm:ss"));
                m_Sb.Append(" - ");
                m_Sb.Append(response);
                m_bDirty = true;
            }
        }

        private void tmrEditNotify_Tick(object sender, EventArgs e)
        {
            if (m_bDirty)
            {
                m_bDirty = false;
                lstNotification.BeginUpdate();
                lstNotification.Items.Add(m_Sb.ToString());
                lstNotification.EndUpdate();
            }
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
                FillTxtFileContent();
            }
        }

        private void FillTxtFileContent()
        {

            using (StreamReader fileContents = ReadFile(_fileName))
            {
                string line;
                while ((line = fileContents.ReadLine()) != null)
                {
                    txtFileContent.AppendText(line);
                }
            }

        }

        private string MakeRequest()
        {

            return "amazing";
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txtUrl.Text);
            //request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //using (Stream stream = response.GetResponseStream())
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    return reader.ReadToEnd();
            //}

        }

        private StreamReader ReadFile(string fileName)
        {

            StreamReader file = new StreamReader(@fileName);
            return file;
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
            //NotifyIcon.Visible = false;
            //NotifyIcon.ShowBalloonTip(1000);

        }


    }
}