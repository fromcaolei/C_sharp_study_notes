namespace SimpleEditorTest
{
    partial class SimpleEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleEditorForm));
            this.TextBoxEdit = new System.Windows.Forms.TextBox();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.miFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.miFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditorFont = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditorColor = new System.Windows.Forms.ToolStripMenuItem();
            this.miEditorBrowser = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.dlgPageSetup = new System.Windows.Forms.PageSetupDialog();
            this.dlgPrint = new System.Windows.Forms.PrintDialog();
            this.dlgPrintPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.dlgFont = new System.Windows.Forms.FontDialog();
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.dlgFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBoxEdit
            // 
            this.TextBoxEdit.AcceptsReturn = true;
            this.TextBoxEdit.AcceptsTab = true;
            this.TextBoxEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxEdit.Location = new System.Drawing.Point(0, 25);
            this.TextBoxEdit.Multiline = true;
            this.TextBoxEdit.Name = "TextBoxEdit";
            this.TextBoxEdit.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TextBoxEdit.Size = new System.Drawing.Size(434, 437);
            this.TextBoxEdit.TabIndex = 0;
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.editorToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(434, 25);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFileNew,
            this.miFileOpen,
            this.miFileSave,
            this.miFileSaveAs,
            this.toolStripMenuItem1,
            this.miFilePrint,
            this.miFilePrintPreview,
            this.miFilePageSetup,
            this.toolStripMenuItem2,
            this.miFileExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(39, 21);
            this.miFile.Text = "&File";
            // 
            // miFileNew
            // 
            this.miFileNew.Name = "miFileNew";
            this.miFileNew.Size = new System.Drawing.Size(150, 22);
            this.miFileNew.Text = "&New";
            this.miFileNew.Click += new System.EventHandler(this.miFileNew_Click);
            // 
            // miFileOpen
            // 
            this.miFileOpen.Name = "miFileOpen";
            this.miFileOpen.Size = new System.Drawing.Size(150, 22);
            this.miFileOpen.Text = "&Open...";
            this.miFileOpen.Click += new System.EventHandler(this.miFileOpen_Click);
            // 
            // miFileSave
            // 
            this.miFileSave.Name = "miFileSave";
            this.miFileSave.Size = new System.Drawing.Size(150, 22);
            this.miFileSave.Text = "&Save";
            this.miFileSave.Click += new System.EventHandler(this.miFileSave_Click);
            // 
            // miFileSaveAs
            // 
            this.miFileSaveAs.Name = "miFileSaveAs";
            this.miFileSaveAs.Size = new System.Drawing.Size(150, 22);
            this.miFileSaveAs.Text = "Save &As...";
            this.miFileSaveAs.Click += new System.EventHandler(this.miFileSaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(147, 6);
            // 
            // miFilePrint
            // 
            this.miFilePrint.Name = "miFilePrint";
            this.miFilePrint.Size = new System.Drawing.Size(150, 22);
            this.miFilePrint.Text = "&Print";
            this.miFilePrint.Click += new System.EventHandler(this.miFilePrint_Click);
            // 
            // miFilePrintPreview
            // 
            this.miFilePrintPreview.Name = "miFilePrintPreview";
            this.miFilePrintPreview.Size = new System.Drawing.Size(150, 22);
            this.miFilePrintPreview.Text = "Print Pre&view";
            this.miFilePrintPreview.Click += new System.EventHandler(this.miFilePrintPreview_Click);
            // 
            // miFilePageSetup
            // 
            this.miFilePageSetup.Name = "miFilePageSetup";
            this.miFilePageSetup.Size = new System.Drawing.Size(150, 22);
            this.miFilePageSetup.Text = "Page Set&up";
            this.miFilePageSetup.Click += new System.EventHandler(this.miFilePageSetup_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(147, 6);
            // 
            // miFileExit
            // 
            this.miFileExit.Name = "miFileExit";
            this.miFileExit.Size = new System.Drawing.Size(150, 22);
            this.miFileExit.Text = "E&xit";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miEditorFont,
            this.miEditorColor,
            this.miEditorBrowser});
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.editorToolStripMenuItem.Text = "&Editor";
            // 
            // miEditorFont
            // 
            this.miEditorFont.Name = "miEditorFont";
            this.miEditorFont.Size = new System.Drawing.Size(124, 22);
            this.miEditorFont.Text = "F&ont";
            this.miEditorFont.Click += new System.EventHandler(this.miEditorFont_Click);
            // 
            // miEditorColor
            // 
            this.miEditorColor.Name = "miEditorColor";
            this.miEditorColor.Size = new System.Drawing.Size(124, 22);
            this.miEditorColor.Text = "&Color";
            this.miEditorColor.Click += new System.EventHandler(this.miEditorColor_Click);
            // 
            // miEditorBrowser
            // 
            this.miEditorBrowser.Name = "miEditorBrowser";
            this.miEditorBrowser.Size = new System.Drawing.Size(124, 22);
            this.miEditorBrowser.Text = "&Browser";
            this.miEditorBrowser.Click += new System.EventHandler(this.miEditorBrowser_Click);
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            this.dlgOpenFile.Filter = "Text Documents (*.txt)|*.txt|Wrox Documents (*.worxtext)|*.worxtext|All Files|*.*" +
                "";
            this.dlgOpenFile.FilterIndex = 2;
            // 
            // dlgSaveFile
            // 
            this.dlgSaveFile.FileName = "Untitled";
            this.dlgSaveFile.Filter = "Text Documents (*.txt)|*.txt|Wrox Documents (*.worxtext)|*.worxtext|All Files|*.*" +
                "";
            this.dlgSaveFile.FilterIndex = 2;
            // 
            // printDocument
            // 
            this.printDocument.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_BeginPrint);
            this.printDocument.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument_EndPrint);
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // dlgPageSetup
            // 
            this.dlgPageSetup.Document = this.printDocument;
            // 
            // dlgPrint
            // 
            this.dlgPrint.Document = this.printDocument;
            this.dlgPrint.UseEXDialog = true;
            // 
            // dlgPrintPreview
            // 
            this.dlgPrintPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.dlgPrintPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.dlgPrintPreview.Document = this.printDocument;
            this.dlgPrintPreview.Enabled = true;
            this.dlgPrintPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("dlgPrintPreview.Icon")));
            this.dlgPrintPreview.Name = "dlgPrintPreview";
            this.dlgPrintPreview.Visible = false;
            // 
            // dlgFont
            // 
            this.dlgFont.Apply += new System.EventHandler(this.dlgFont_Apply);
            // 
            // dlgFolderBrowser
            // 
            this.dlgFolderBrowser.Description = "Select a directory";
            // 
            // SimpleEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 462);
            this.Controls.Add(this.TextBoxEdit);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "SimpleEditorForm";
            this.Text = "Simple Editor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEdit;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miFileNew;
        private System.Windows.Forms.ToolStripMenuItem miFileOpen;
        private System.Windows.Forms.ToolStripMenuItem miFileSave;
        private System.Windows.Forms.ToolStripMenuItem miFileSaveAs;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
        private System.Windows.Forms.SaveFileDialog dlgSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miFilePrint;
        private System.Windows.Forms.ToolStripMenuItem miFilePrintPreview;
        private System.Windows.Forms.ToolStripMenuItem miFilePageSetup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miFileExit;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PageSetupDialog dlgPageSetup;
        private System.Windows.Forms.PrintDialog dlgPrint;
        private System.Windows.Forms.PrintPreviewDialog dlgPrintPreview;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miEditorFont;
        private System.Windows.Forms.ToolStripMenuItem miEditorColor;
        private System.Windows.Forms.FontDialog dlgFont;
        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.FolderBrowserDialog dlgFolderBrowser;
        private System.Windows.Forms.ToolStripMenuItem miEditorBrowser;
    }
}

