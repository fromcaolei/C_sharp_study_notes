namespace LoopThroughXmlDocument
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
            this.buttonLoop = new System.Windows.Forms.Button();
            this.listBoxXmlNode = new System.Windows.Forms.ListBox();
            this.buttonCreateNode = new System.Windows.Forms.Button();
            this.buttonDeleteNode = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonLoop
            // 
            this.buttonLoop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoop.Location = new System.Drawing.Point(441, 12);
            this.buttonLoop.Name = "buttonLoop";
            this.buttonLoop.Size = new System.Drawing.Size(75, 23);
            this.buttonLoop.TabIndex = 1;
            this.buttonLoop.Text = "Loop";
            this.buttonLoop.UseVisualStyleBackColor = true;
            this.buttonLoop.Click += new System.EventHandler(this.buttonLoop_Click);
            // 
            // listBoxXmlNode
            // 
            this.listBoxXmlNode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxXmlNode.FormattingEnabled = true;
            this.listBoxXmlNode.ItemHeight = 12;
            this.listBoxXmlNode.Location = new System.Drawing.Point(12, 252);
            this.listBoxXmlNode.Name = "listBoxXmlNode";
            this.listBoxXmlNode.Size = new System.Drawing.Size(423, 220);
            this.listBoxXmlNode.TabIndex = 2;
            // 
            // buttonCreateNode
            // 
            this.buttonCreateNode.Location = new System.Drawing.Point(441, 41);
            this.buttonCreateNode.Name = "buttonCreateNode";
            this.buttonCreateNode.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateNode.TabIndex = 3;
            this.buttonCreateNode.Text = "Create Node";
            this.buttonCreateNode.UseVisualStyleBackColor = true;
            this.buttonCreateNode.Click += new System.EventHandler(this.buttonCreateNode_Click);
            // 
            // buttonDeleteNode
            // 
            this.buttonDeleteNode.Location = new System.Drawing.Point(441, 70);
            this.buttonDeleteNode.Name = "buttonDeleteNode";
            this.buttonDeleteNode.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteNode.TabIndex = 4;
            this.buttonDeleteNode.Text = "Delete";
            this.buttonDeleteNode.UseVisualStyleBackColor = true;
            this.buttonDeleteNode.Click += new System.EventHandler(this.buttonDeleteNode_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(12, 12);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(423, 234);
            this.textBoxResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 492);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonDeleteNode);
            this.Controls.Add(this.buttonCreateNode);
            this.Controls.Add(this.listBoxXmlNode);
            this.Controls.Add(this.buttonLoop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoop;
        private System.Windows.Forms.ListBox listBoxXmlNode;
        private System.Windows.Forms.Button buttonCreateNode;
        private System.Windows.Forms.Button buttonDeleteNode;
        private System.Windows.Forms.TextBox textBoxResult;
    }
}

