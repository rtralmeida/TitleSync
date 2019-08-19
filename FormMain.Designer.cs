using MaterialSkin;
using MaterialSkin.Controls;
namespace TitleSync
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label3 = new System.Windows.Forms.Label();
            this.tmrEditNotify = new System.Windows.Forms.Timer(this.components);
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnWatchFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtUrl = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnBrowseFile = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFile = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lstNotification = new System.Windows.Forms.ListBox();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change Notifications";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
            this.tmrEditNotify.Tick += new System.EventHandler(this.tmrEditNotify_Tick);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.BalloonTipText = "Radio Title Sync";
            this.NotifyIcon.BalloonTipTitle = "Radio Title Sync";
            this.NotifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Radio Title Sync";
            this.NotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NotifyIcon_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // btnWatchFile
            // 
            this.btnWatchFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWatchFile.AutoSize = true;
            this.btnWatchFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWatchFile.Depth = 0;
            this.btnWatchFile.Icon = null;
            this.btnWatchFile.Location = new System.Drawing.Point(290, 652);
            this.btnWatchFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnWatchFile.Name = "btnWatchFile";
            this.btnWatchFile.Primary = true;
            this.btnWatchFile.Size = new System.Drawing.Size(138, 36);
            this.btnWatchFile.TabIndex = 3;
            this.btnWatchFile.Text = "START WATCHING";
            this.btnWatchFile.UseVisualStyleBackColor = true;
            this.btnWatchFile.Click += new System.EventHandler(this.BtnWatchFile_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Depth = 0;
            this.txtUrl.Hint = "";
            this.txtUrl.Location = new System.Drawing.Point(13, 319);
            this.txtUrl.MaxLength = 32767;
            this.txtUrl.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Padding = new System.Windows.Forms.Padding(10);
            this.txtUrl.PasswordChar = '\0';
            this.txtUrl.SelectedText = "";
            this.txtUrl.SelectionLength = 0;
            this.txtUrl.SelectionStart = 0;
            this.txtUrl.Size = new System.Drawing.Size(331, 23);
            this.txtUrl.TabIndex = 2;
            this.txtUrl.TabStop = false;
            this.txtUrl.Text = "http://azfm.com.test/triger.php?song=songName";
            this.txtUrl.UseSystemPasswordChar = false;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseFile.AutoSize = true;
            this.btnBrowseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseFile.Depth = 0;
            this.btnBrowseFile.Icon = null;
            this.btnBrowseFile.Location = new System.Drawing.Point(352, 123);
            this.btnBrowseFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Primary = true;
            this.btnBrowseFile.Size = new System.Drawing.Size(76, 36);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(9, 89);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(146, 19);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Select File/Directory";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 287);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Link for Radio/Website";
            // 
            // txtFile
            // 
            this.txtFile.Depth = 0;
            this.txtFile.Hint = "";
            this.txtFile.Location = new System.Drawing.Point(12, 129);
            this.txtFile.MaxLength = 32767;
            this.txtFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFile.Name = "txtFile";
            this.txtFile.Padding = new System.Windows.Forms.Padding(10, 20, 10, 20);
            this.txtFile.PasswordChar = '\0';
            this.txtFile.SelectedText = "";
            this.txtFile.SelectionLength = 0;
            this.txtFile.SelectionStart = 0;
            this.txtFile.Size = new System.Drawing.Size(331, 23);
            this.txtFile.TabIndex = 2;
            this.txtFile.TabStop = false;
            this.txtFile.Text = "D:\\Dropbox\\code\\sites\\azfm.com\\local.txt";
            this.txtFile.UseSystemPasswordChar = false;
            // 
            // lstNotification
            // 
            this.lstNotification.FormattingEnabled = true;
            this.lstNotification.Location = new System.Drawing.Point(12, 377);
            this.lstNotification.Name = "lstNotification";
            this.lstNotification.Size = new System.Drawing.Size(416, 173);
            this.lstNotification.TabIndex = 17;
            // 
            // txtFileContent
            // 
            this.txtFileContent.Location = new System.Drawing.Point(13, 165);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(415, 96);
            this.txtFileContent.TabIndex = 18;
            this.txtFileContent.Text = "";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 756);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.lstNotification);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.btnWatchFile);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "TitleSync";
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer tmrEditNotify;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MaterialSkin.Controls.MaterialRaisedButton btnWatchFile;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUrl;
        private MaterialSkin.Controls.MaterialRaisedButton btnBrowseFile;
        private MaterialLabel materialLabel2;
        private MaterialLabel materialLabel1;
        private MaterialSingleLineTextField txtFile;
        private System.Windows.Forms.ListBox lstNotification;
        private System.Windows.Forms.RichTextBox txtFileContent;
    }
}

