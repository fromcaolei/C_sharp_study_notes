namespace EncryptString
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
            this.encryption = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.plainText = new System.Windows.Forms.TextBox();
            this.encryptionResults = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keyString = new System.Windows.Forms.TextBox();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.decryptionResult = new System.Windows.Forms.TextBox();
            this.decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // encryption
            // 
            this.encryption.Location = new System.Drawing.Point(139, 143);
            this.encryption.Name = "encryption";
            this.encryption.Size = new System.Drawing.Size(75, 23);
            this.encryption.TabIndex = 0;
            this.encryption.Text = "加密";
            this.encryption.UseVisualStyleBackColor = true;
            this.encryption.Click += new System.EventHandler(this.encryption_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入明文字符串";
            // 
            // plainText
            // 
            this.plainText.Location = new System.Drawing.Point(107, 6);
            this.plainText.Name = "plainText";
            this.plainText.Size = new System.Drawing.Size(382, 21);
            this.plainText.TabIndex = 2;
            // 
            // encryptionResults
            // 
            this.encryptionResults.Location = new System.Drawing.Point(107, 89);
            this.encryptionResults.Name = "encryptionResults";
            this.encryptionResults.ReadOnly = true;
            this.encryptionResults.Size = new System.Drawing.Size(382, 21);
            this.encryptionResults.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "加密结果";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "输入密钥字符串";
            // 
            // keyString
            // 
            this.keyString.Location = new System.Drawing.Point(107, 62);
            this.keyString.Name = "keyString";
            this.keyString.Size = new System.Drawing.Size(382, 21);
            this.keyString.TabIndex = 6;
            this.keyString.Text = "helloworld";
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(107, 33);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(382, 21);
            this.cipherText.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "输入密文字符串";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "解密结果";
            // 
            // decryptionResult
            // 
            this.decryptionResult.Location = new System.Drawing.Point(107, 116);
            this.decryptionResult.Name = "decryptionResult";
            this.decryptionResult.ReadOnly = true;
            this.decryptionResult.Size = new System.Drawing.Size(382, 21);
            this.decryptionResult.TabIndex = 9;
            // 
            // decrypt
            // 
            this.decrypt.Location = new System.Drawing.Point(287, 143);
            this.decrypt.Name = "decrypt";
            this.decrypt.Size = new System.Drawing.Size(75, 23);
            this.decrypt.TabIndex = 11;
            this.decrypt.Text = "解密";
            this.decrypt.UseVisualStyleBackColor = true;
            this.decrypt.Click += new System.EventHandler(this.decrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 178);
            this.Controls.Add(this.decrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.decryptionResult);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.keyString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.encryptionResults);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encryption);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "哈希算法加密解密程序";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button encryption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.TextBox encryptionResults;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keyString;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decryptionResult;
        private System.Windows.Forms.Button decrypt;
    }
}

