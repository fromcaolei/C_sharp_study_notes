namespace Manual_Menus
{
    partial class FrmContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItemNewExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemTile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.ToolStripMenuItemWindow,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.ToolStripMenuItemWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 25);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.openToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ToolStripMenuItemNewExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemNew.Text = "&New";
            this.ToolStripMenuItemNew.Click += new System.EventHandler(this.ToolStripMenuItemNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.toolStripMenuItem1.MergeIndex = 10;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // ToolStripMenuItemNewExit
            // 
            this.ToolStripMenuItemNewExit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.ToolStripMenuItemNewExit.MergeIndex = 11;
            this.ToolStripMenuItemNewExit.Name = "ToolStripMenuItemNewExit";
            this.ToolStripMenuItemNewExit.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemNewExit.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // ToolStripMenuItemWindow
            // 
            this.ToolStripMenuItemWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemTile,
            this.ToolStripMenuItemCascade});
            this.ToolStripMenuItemWindow.Name = "ToolStripMenuItemWindow";
            this.ToolStripMenuItemWindow.Size = new System.Drawing.Size(67, 21);
            this.ToolStripMenuItemWindow.Text = "&Window";
            // 
            // ToolStripMenuItemTile
            // 
            this.ToolStripMenuItemTile.Name = "ToolStripMenuItemTile";
            this.ToolStripMenuItemTile.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemTile.Text = "&Tile";
            this.ToolStripMenuItemTile.Click += new System.EventHandler(this.ToolStripMenuItemTile_Click);
            // 
            // ToolStripMenuItemCascade
            // 
            this.ToolStripMenuItemCascade.Name = "ToolStripMenuItemCascade";
            this.ToolStripMenuItemCascade.Size = new System.Drawing.Size(152, 22);
            this.ToolStripMenuItemCascade.Text = "&Cascade";
            this.ToolStripMenuItemCascade.Click += new System.EventHandler(this.ToolStripMenuItemCascade_Click);
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 415);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(615, 453);
            this.Name = "FrmContainer";
            this.Text = "Simple Text Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNew;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewExit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWindow;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemTile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemCascade;



















    }
}