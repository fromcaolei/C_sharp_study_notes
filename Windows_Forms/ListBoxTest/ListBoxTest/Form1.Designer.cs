namespace ListBoxTest
{
    partial class Form1
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
            this.listBoxSelected = new System.Windows.Forms.ListBox();
            this.buttonMove = new System.Windows.Forms.Button();
            this.checkedListBoxPossibleValue = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // listBoxSelected
            // 
            this.listBoxSelected.FormattingEnabled = true;
            this.listBoxSelected.ItemHeight = 12;
            this.listBoxSelected.Location = new System.Drawing.Point(323, 12);
            this.listBoxSelected.Name = "listBoxSelected";
            this.listBoxSelected.Size = new System.Drawing.Size(227, 328);
            this.listBoxSelected.TabIndex = 0;
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(232, 162);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(85, 23);
            this.buttonMove.TabIndex = 1;
            this.buttonMove.Text = "buttonMove";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // checkedListBoxPossibleValue
            // 
            this.checkedListBoxPossibleValue.FormattingEnabled = true;
            this.checkedListBoxPossibleValue.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine"});
            this.checkedListBoxPossibleValue.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxPossibleValue.Name = "checkedListBoxPossibleValue";
            this.checkedListBoxPossibleValue.Size = new System.Drawing.Size(214, 324);
            this.checkedListBoxPossibleValue.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 348);
            this.Controls.Add(this.checkedListBoxPossibleValue);
            this.Controls.Add(this.buttonMove);
            this.Controls.Add(this.listBoxSelected);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelected;
        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.CheckedListBox checkedListBoxPossibleValue;
    }
}

