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
            this.txEndpointUrl = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.lstNotification = new System.Windows.Forms.ListBox();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.btnWatchFile = new System.Windows.Forms.Button();
            this.lblFullUrl = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Change Notifications";
            // 
            // tmrEditNotify
            // 
            this.tmrEditNotify.Enabled = true;
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
            // txEndpointUrl
            // 
            this.txEndpointUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txEndpointUrl.Location = new System.Drawing.Point(49, 321);
            this.txEndpointUrl.Name = "txEndpointUrl";
            this.txEndpointUrl.Size = new System.Drawing.Size(425, 26);
            this.txEndpointUrl.TabIndex = 2;
            this.txEndpointUrl.TabStop = false;
            this.txEndpointUrl.TextChanged += new System.EventHandler(this.TxtEndpointUrl_TextChanged);
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowseFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBrowseFile.Location = new System.Drawing.Point(385, 67);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(89, 26);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.BtnBrowseFile_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(44, 26);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(177, 24);
            this.materialLabel2.TabIndex = 15;
            this.materialLabel2.Text = "Select File/Directory";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(44, 289);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(197, 24);
            this.materialLabel1.TabIndex = 15;
            this.materialLabel1.Text = "Link for Radio/Website";
            // 
            // txtFile
            // 
            this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFile.Location = new System.Drawing.Point(48, 67);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(331, 26);
            this.txtFile.TabIndex = 2;
            this.txtFile.TabStop = false;
            // 
            // lstNotification
            // 
            this.lstNotification.FormattingEnabled = true;
            this.lstNotification.HorizontalScrollbar = true;
            this.lstNotification.Location = new System.Drawing.Point(58, 503);
            this.lstNotification.Name = "lstNotification";
            this.lstNotification.Size = new System.Drawing.Size(425, 160);
            this.lstNotification.TabIndex = 17;
            // 
            // txtFileContent
            // 
            this.txtFileContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFileContent.Location = new System.Drawing.Point(48, 107);
            this.txtFileContent.Name = "txtFileContent";
            this.txtFileContent.Size = new System.Drawing.Size(426, 168);
            this.txtFileContent.TabIndex = 18;
            this.txtFileContent.Text = "";
            // 
            // btnWatchFile
            // 
            this.btnWatchFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnWatchFile.BackColor = System.Drawing.Color.LimeGreen;
            this.btnWatchFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnWatchFile.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnWatchFile.Location = new System.Drawing.Point(191, 402);
            this.btnWatchFile.MinimumSize = new System.Drawing.Size(100, 60);
            this.btnWatchFile.Name = "btnWatchFile";
            this.btnWatchFile.Size = new System.Drawing.Size(147, 60);
            this.btnWatchFile.TabIndex = 4;
            this.btnWatchFile.Text = "CONNECT";
            this.btnWatchFile.UseVisualStyleBackColor = false;
            this.btnWatchFile.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // lblFullUrl
            // 
            this.lblFullUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFullUrl.Location = new System.Drawing.Point(48, 353);
            this.lblFullUrl.Name = "lblFullUrl";
            this.lblFullUrl.ReadOnly = true;
            this.lblFullUrl.Size = new System.Drawing.Size(426, 26);
            this.lblFullUrl.TabIndex = 2;
            this.lblFullUrl.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(526, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tokenToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tokenToolStripMenuItem
            // 
            this.tokenToolStripMenuItem.Name = "tokenToolStripMenuItem";
            this.tokenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.tokenToolStripMenuItem.Text = "Token";
            this.tokenToolStripMenuItem.Click += new System.EventHandler(this.TokenToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checkmark.ico");
            this.imageList1.Images.SetKeyName(1, "close.ico");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 721);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnWatchFile);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.lstNotification);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.lblFullUrl);
            this.Controls.Add(this.txEndpointUrl);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "TitleSync";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txEndpointUrl;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.ListBox lstNotification;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.Button btnWatchFile;
        private System.Windows.Forms.TextBox lblFullUrl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokenToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
    }
}

