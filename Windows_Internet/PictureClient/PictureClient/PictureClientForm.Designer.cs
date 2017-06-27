namespace PictureClient
{
    partial class PictureClientForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonGetPicture = new System.Windows.Forms.Button();
            this.buttonListPictures = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 490);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(466, 484);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonListPictures);
            this.panel3.Controls.Add(this.buttonGetPicture);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 433);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 48);
            this.panel3.TabIndex = 2;
            // 
            // buttonGetPicture
            // 
            this.buttonGetPicture.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonGetPicture.Location = new System.Drawing.Point(257, 13);
            this.buttonGetPicture.Name = "buttonGetPicture";
            this.buttonGetPicture.Size = new System.Drawing.Size(154, 23);
            this.buttonGetPicture.TabIndex = 4;
            this.buttonGetPicture.Text = "Get Picture";
            this.buttonGetPicture.UseVisualStyleBackColor = true;
            this.buttonGetPicture.Click += new System.EventHandler(this.buttonGetPicture_Click);
            // 
            // buttonListPictures
            // 
            this.buttonListPictures.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListPictures.Location = new System.Drawing.Point(49, 13);
            this.buttonListPictures.Name = "buttonListPictures";
            this.buttonListPictures.Size = new System.Drawing.Size(154, 23);
            this.buttonListPictures.TabIndex = 3;
            this.buttonListPictures.Text = "List Pictures";
            this.buttonListPictures.UseVisualStyleBackColor = true;
            this.buttonListPictures.Click += new System.EventHandler(this.buttonListPictures_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 424);
            this.panel1.TabIndex = 0;
            // 
            // listFiles
            // 
            this.listFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 12;
            this.listFiles.Location = new System.Drawing.Point(0, 0);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(460, 424);
            this.listFiles.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(475, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(466, 484);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // PictureClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 490);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PictureClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Picture Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listFiles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonListPictures;
        private System.Windows.Forms.Button buttonGetPicture;
    }
}

