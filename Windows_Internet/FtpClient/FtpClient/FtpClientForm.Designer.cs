namespace FtpClient
{
    partial class FtpClientForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonOpenDirectory = new System.Windows.Forms.Button();
            this.buttonGetFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textServer = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.checkBoxBinary = new System.Windows.Forms.CheckBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(448, 35);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(106, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonOpenDirectory
            // 
            this.buttonOpenDirectory.Enabled = false;
            this.buttonOpenDirectory.Location = new System.Drawing.Point(448, 81);
            this.buttonOpenDirectory.Name = "buttonOpenDirectory";
            this.buttonOpenDirectory.Size = new System.Drawing.Size(106, 23);
            this.buttonOpenDirectory.TabIndex = 1;
            this.buttonOpenDirectory.Text = "Open Directory";
            this.buttonOpenDirectory.UseVisualStyleBackColor = true;
            this.buttonOpenDirectory.Click += new System.EventHandler(this.buttonOpenDirectory_Click);
            // 
            // buttonGetFile
            // 
            this.buttonGetFile.Enabled = false;
            this.buttonGetFile.Location = new System.Drawing.Point(448, 126);
            this.buttonGetFile.Name = "buttonGetFile";
            this.buttonGetFile.Size = new System.Drawing.Size(106, 23);
            this.buttonGetFile.TabIndex = 2;
            this.buttonGetFile.Text = "Get File";
            this.buttonGetFile.UseVisualStyleBackColor = true;
            this.buttonGetFile.Click += new System.EventHandler(this.buttonGetFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passworld";
            // 
            // textServer
            // 
            this.textServer.Location = new System.Drawing.Point(96, 24);
            this.textServer.Name = "textServer";
            this.textServer.Size = new System.Drawing.Size(178, 21);
            this.textServer.TabIndex = 6;
            this.textServer.Text = "ftp://172.16.51.27";
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(96, 71);
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(178, 21);
            this.textUsername.TabIndex = 7;
            this.textUsername.Text = "Administrator";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(96, 118);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(178, 21);
            this.textPassword.TabIndex = 8;
            this.textPassword.Text = "1";
            // 
            // checkBoxBinary
            // 
            this.checkBoxBinary.AutoSize = true;
            this.checkBoxBinary.Checked = true;
            this.checkBoxBinary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBinary.Location = new System.Drawing.Point(448, 213);
            this.checkBoxBinary.Name = "checkBoxBinary";
            this.checkBoxBinary.Size = new System.Drawing.Size(90, 16);
            this.checkBoxBinary.TabIndex = 10;
            this.checkBoxBinary.Text = "Binary Mode";
            this.checkBoxBinary.UseVisualStyleBackColor = true;
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 12;
            this.listFiles.Location = new System.Drawing.Point(14, 151);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(403, 244);
            this.listFiles.TabIndex = 11;
            this.listFiles.SelectedIndexChanged += new System.EventHandler(this.listFiles_SelectedIndexChanged);
            // 
            // FtpClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 415);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.checkBoxBinary);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.textUsername);
            this.Controls.Add(this.textServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGetFile);
            this.Controls.Add(this.buttonOpenDirectory);
            this.Controls.Add(this.buttonOpen);
            this.Name = "FtpClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ftp Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonOpenDirectory;
        private System.Windows.Forms.Button buttonGetFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textServer;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.CheckBox checkBoxBinary;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

