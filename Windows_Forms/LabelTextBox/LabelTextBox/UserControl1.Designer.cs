namespace LabelTextBox
{
    partial class ctLabelTextbox
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

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTextBox = new System.Windows.Forms.Label();
            this.txtLabelText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTextBox
            // 
            this.lblTextBox.AutoSize = true;
            this.lblTextBox.Location = new System.Drawing.Point(0, 0);
            this.lblTextBox.Name = "lblTextBox";
            this.lblTextBox.Size = new System.Drawing.Size(35, 12);
            this.lblTextBox.TabIndex = 0;
            this.lblTextBox.Text = "Label";
            // 
            // txtLabelText
            // 
            this.txtLabelText.Location = new System.Drawing.Point(3, 15);
            this.txtLabelText.Name = "txtLabelText";
            this.txtLabelText.Size = new System.Drawing.Size(100, 21);
            this.txtLabelText.TabIndex = 1;
            // 
            // ctLabelTextbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtLabelText);
            this.Controls.Add(this.lblTextBox);
            this.Name = "ctLabelTextbox";
            this.Load += new System.EventHandler(this.ctLabelTextbox_Load);
            this.SizeChanged += new System.EventHandler(this.ctLabelTextbox_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctLabelTextbox_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctLabelTextbox_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ctLabelTextbox_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextBox;
        private System.Windows.Forms.TextBox txtLabelText;
    }
}
