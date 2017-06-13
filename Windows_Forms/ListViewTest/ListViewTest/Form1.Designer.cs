namespace ListViewTest
{
    partial class ListView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.labelCurrentPath = new System.Windows.Forms.Label();
            this.listViewFilesAndFolders = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.ViewMode = new System.Windows.Forms.GroupBox();
            this.Tile = new System.Windows.Forms.RadioButton();
            this.Details = new System.Windows.Forms.RadioButton();
            this.List = new System.Windows.Forms.RadioButton();
            this.SmallIcon = new System.Windows.Forms.RadioButton();
            this.Largelcon = new System.Windows.Forms.RadioButton();
            this.ViewMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCurrentPath
            // 
            this.labelCurrentPath.AutoSize = true;
            this.labelCurrentPath.Location = new System.Drawing.Point(13, 13);
            this.labelCurrentPath.Name = "labelCurrentPath";
            this.labelCurrentPath.Size = new System.Drawing.Size(101, 12);
            this.labelCurrentPath.TabIndex = 0;
            this.labelCurrentPath.Text = "labelCurrentPath";
            // 
            // listViewFilesAndFolders
            // 
            this.listViewFilesAndFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilesAndFolders.LargeImageList = this.imageListLarge;
            this.listViewFilesAndFolders.Location = new System.Drawing.Point(15, 29);
            this.listViewFilesAndFolders.Name = "listViewFilesAndFolders";
            this.listViewFilesAndFolders.Size = new System.Drawing.Size(383, 168);
            this.listViewFilesAndFolders.SmallImageList = this.imageListSmall;
            this.listViewFilesAndFolders.TabIndex = 1;
            this.listViewFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.listViewFilesAndFolders.View = System.Windows.Forms.View.Details;
            this.listViewFilesAndFolders.ItemActivate += new System.EventHandler(this.listViewFilesAndFolders_ItemActivate);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "2.jpg");
            this.imageListLarge.Images.SetKeyName(1, "3.jpg");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "2.jpg");
            this.imageListSmall.Images.SetKeyName(1, "3.jpg");
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonBack.Location = new System.Drawing.Point(242, 203);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "buttonBack";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ViewMode
            // 
            this.ViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewMode.Controls.Add(this.Tile);
            this.ViewMode.Controls.Add(this.Details);
            this.ViewMode.Controls.Add(this.List);
            this.ViewMode.Controls.Add(this.SmallIcon);
            this.ViewMode.Controls.Add(this.Largelcon);
            this.ViewMode.Location = new System.Drawing.Point(405, 29);
            this.ViewMode.Name = "ViewMode";
            this.ViewMode.Size = new System.Drawing.Size(141, 168);
            this.ViewMode.TabIndex = 3;
            this.ViewMode.TabStop = false;
            this.ViewMode.Text = "View Mode";
            // 
            // Tile
            // 
            this.Tile.AutoSize = true;
            this.Tile.Location = new System.Drawing.Point(7, 113);
            this.Tile.Name = "Tile";
            this.Tile.Size = new System.Drawing.Size(47, 16);
            this.Tile.TabIndex = 4;
            this.Tile.Text = "Tile";
            this.Tile.UseVisualStyleBackColor = true;
            this.Tile.CheckedChanged += new System.EventHandler(this.Tile_CheckedChanged);
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Checked = true;
            this.Details.Location = new System.Drawing.Point(7, 90);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(65, 16);
            this.Details.TabIndex = 3;
            this.Details.TabStop = true;
            this.Details.Text = "Details";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.CheckedChanged += new System.EventHandler(this.Details_CheckedChanged);
            // 
            // List
            // 
            this.List.AutoSize = true;
            this.List.Location = new System.Drawing.Point(7, 67);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(47, 16);
            this.List.TabIndex = 2;
            this.List.Text = "List";
            this.List.UseVisualStyleBackColor = true;
            this.List.CheckedChanged += new System.EventHandler(this.List_CheckedChanged);
            // 
            // SmallIcon
            // 
            this.SmallIcon.AutoSize = true;
            this.SmallIcon.Location = new System.Drawing.Point(7, 44);
            this.SmallIcon.Name = "SmallIcon";
            this.SmallIcon.Size = new System.Drawing.Size(77, 16);
            this.SmallIcon.TabIndex = 1;
            this.SmallIcon.Text = "SmallIcon";
            this.SmallIcon.UseVisualStyleBackColor = true;
            this.SmallIcon.CheckedChanged += new System.EventHandler(this.SmallIcon_CheckedChanged);
            // 
            // Largelcon
            // 
            this.Largelcon.AutoSize = true;
            this.Largelcon.Location = new System.Drawing.Point(7, 21);
            this.Largelcon.Name = "Largelcon";
            this.Largelcon.Size = new System.Drawing.Size(77, 16);
            this.Largelcon.TabIndex = 0;
            this.Largelcon.Text = "Largelcon";
            this.Largelcon.UseVisualStyleBackColor = true;
            this.Largelcon.CheckedChanged += new System.EventHandler(this.Largelcon_CheckedChanged);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 238);
            this.Controls.Add(this.ViewMode);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listViewFilesAndFolders);
            this.Controls.Add(this.labelCurrentPath);
            this.MinimumSize = new System.Drawing.Size(574, 276);
            this.Name = "ListView";
            this.Text = "ListView";
            this.ViewMode.ResumeLayout(false);
            this.ViewMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCurrentPath;
        private System.Windows.Forms.ListView listViewFilesAndFolders;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox ViewMode;
        private System.Windows.Forms.RadioButton Tile;
        private System.Windows.Forms.RadioButton Details;
        private System.Windows.Forms.RadioButton List;
        private System.Windows.Forms.RadioButton SmallIcon;
        private System.Windows.Forms.RadioButton Largelcon;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;

    }
}

