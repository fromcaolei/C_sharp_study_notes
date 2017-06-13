namespace RichTextBoxTest
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
            this.buttonBold = new System.Windows.Forms.Button();
            this.buttonUNderline = new System.Windows.Forms.Button();
            this.buttonltalic = new System.Windows.Forms.Button();
            this.buttonCenter = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.textBoxSize = new System.Windows.Forms.TextBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBold
            // 
            this.buttonBold.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonBold.Location = new System.Drawing.Point(139, 12);
            this.buttonBold.Name = "buttonBold";
            this.buttonBold.Size = new System.Drawing.Size(75, 23);
            this.buttonBold.TabIndex = 0;
            this.buttonBold.Text = "buttonBold";
            this.buttonBold.UseVisualStyleBackColor = true;
            this.buttonBold.Click += new System.EventHandler(this.buttonBold_Click);
            // 
            // buttonUNderline
            // 
            this.buttonUNderline.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUNderline.Location = new System.Drawing.Point(220, 12);
            this.buttonUNderline.Name = "buttonUNderline";
            this.buttonUNderline.Size = new System.Drawing.Size(75, 23);
            this.buttonUNderline.TabIndex = 1;
            this.buttonUNderline.Text = "buttonUNderline";
            this.buttonUNderline.UseVisualStyleBackColor = true;
            this.buttonUNderline.Click += new System.EventHandler(this.buttonUNderline_Click);
            // 
            // buttonltalic
            // 
            this.buttonltalic.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonltalic.Location = new System.Drawing.Point(301, 12);
            this.buttonltalic.Name = "buttonltalic";
            this.buttonltalic.Size = new System.Drawing.Size(75, 23);
            this.buttonltalic.TabIndex = 2;
            this.buttonltalic.Text = "buttonltalic";
            this.buttonltalic.UseVisualStyleBackColor = true;
            this.buttonltalic.Click += new System.EventHandler(this.buttonltalic_Click);
            // 
            // buttonCenter
            // 
            this.buttonCenter.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCenter.Location = new System.Drawing.Point(382, 12);
            this.buttonCenter.Name = "buttonCenter";
            this.buttonCenter.Size = new System.Drawing.Size(75, 23);
            this.buttonCenter.TabIndex = 3;
            this.buttonCenter.Text = "buttonCenter";
            this.buttonCenter.UseVisualStyleBackColor = true;
            this.buttonCenter.Click += new System.EventHandler(this.buttonCenter_Click);
            // 
            // labelSize
            // 
            this.labelSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(200, 49);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(59, 12);
            this.labelSize.TabIndex = 4;
            this.labelSize.Text = "labelSize";
            // 
            // textBoxSize
            // 
            this.textBoxSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSize.Location = new System.Drawing.Point(265, 46);
            this.textBoxSize.MaxLength = 5;
            this.textBoxSize.Name = "textBoxSize";
            this.textBoxSize.Size = new System.Drawing.Size(100, 21);
            this.textBoxSize.TabIndex = 5;
            this.textBoxSize.Text = "10";
            this.textBoxSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSize_KeyPress);
            this.textBoxSize.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSize_Validating);
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxText.Location = new System.Drawing.Point(12, 73);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(570, 171);
            this.richTextBoxText.TabIndex = 6;
            this.richTextBoxText.Text = "richTextBoxText";
            this.richTextBoxText.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBoxText_LinkClicked);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonLoad.Location = new System.Drawing.Point(220, 250);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonLoad.TabIndex = 7;
            this.buttonLoad.Text = "buttonLoad";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.Location = new System.Drawing.Point(301, 250);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "buttonSave";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 285);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.textBoxSize);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.buttonCenter);
            this.Controls.Add(this.buttonltalic);
            this.Controls.Add(this.buttonUNderline);
            this.Controls.Add(this.buttonBold);
            this.MinimumSize = new System.Drawing.Size(610, 323);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBold;
        private System.Windows.Forms.Button buttonUNderline;
        private System.Windows.Forms.Button buttonltalic;
        private System.Windows.Forms.Button buttonCenter;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.TextBox textBoxSize;
        private System.Windows.Forms.RichTextBox richTextBoxText;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
    }
}

