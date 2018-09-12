namespace JieYuCamera
{
    partial class form_jieyucamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_jieyucamera));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_queding = new System.Windows.Forms.Button();
            this.bt_yulan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mingcheng = new System.Windows.Forms.TextBox();
            this.bt_shuaxin = new System.Windows.Forms.Button();
            this.cb_xiuheibian = new System.Windows.Forms.ComboBox();
            this.ckb_xiuheibian = new System.Windows.Forms.CheckBox();
            this.ckb_quheibian = new System.Windows.Forms.CheckBox();
            this.ckb_jiaozheng = new System.Windows.Forms.CheckBox();
            this.bt_youxuanzhuan = new System.Windows.Forms.Button();
            this.bt_zuoxuanzhuan = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axDoccameraOcx1 = new AxDOCCAMERAOCXLib.AxDoccameraOcx();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axDoccameraOcx1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "图片预览：";
            // 
            // bt_queding
            // 
            this.bt_queding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_queding.Location = new System.Drawing.Point(1050, 263);
            this.bt_queding.Name = "bt_queding";
            this.bt_queding.Size = new System.Drawing.Size(63, 23);
            this.bt_queding.TabIndex = 18;
            this.bt_queding.Text = "确定";
            this.bt_queding.UseVisualStyleBackColor = true;
            // 
            // bt_yulan
            // 
            this.bt_yulan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_yulan.Location = new System.Drawing.Point(972, 263);
            this.bt_yulan.Name = "bt_yulan";
            this.bt_yulan.Size = new System.Drawing.Size(63, 23);
            this.bt_yulan.TabIndex = 17;
            this.bt_yulan.Text = "预览";
            this.bt_yulan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_mingcheng);
            this.groupBox1.Controls.Add(this.bt_shuaxin);
            this.groupBox1.Controls.Add(this.cb_xiuheibian);
            this.groupBox1.Controls.Add(this.ckb_xiuheibian);
            this.groupBox1.Controls.Add(this.ckb_quheibian);
            this.groupBox1.Controls.Add(this.ckb_jiaozheng);
            this.groupBox1.Controls.Add(this.bt_youxuanzhuan);
            this.groupBox1.Controls.Add(this.bt_zuoxuanzhuan);
            this.groupBox1.Location = new System.Drawing.Point(951, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 225);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像设置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = ".jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "图片名称：";
            // 
            // txt_mingcheng
            // 
            this.txt_mingcheng.Location = new System.Drawing.Point(6, 198);
            this.txt_mingcheng.Name = "txt_mingcheng";
            this.txt_mingcheng.Size = new System.Drawing.Size(135, 21);
            this.txt_mingcheng.TabIndex = 15;
            this.txt_mingcheng.Tag = "图片名称";
            // 
            // bt_shuaxin
            // 
            this.bt_shuaxin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_shuaxin.Location = new System.Drawing.Point(37, 20);
            this.bt_shuaxin.Name = "bt_shuaxin";
            this.bt_shuaxin.Size = new System.Drawing.Size(109, 28);
            this.bt_shuaxin.TabIndex = 7;
            this.bt_shuaxin.Text = "刷新高拍仪图像";
            this.bt_shuaxin.UseVisualStyleBackColor = true;
            // 
            // cb_xiuheibian
            // 
            this.cb_xiuheibian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_xiuheibian.FormattingEnabled = true;
            this.cb_xiuheibian.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.cb_xiuheibian.Location = new System.Drawing.Point(96, 154);
            this.cb_xiuheibian.Name = "cb_xiuheibian";
            this.cb_xiuheibian.Size = new System.Drawing.Size(39, 20);
            this.cb_xiuheibian.TabIndex = 6;
            // 
            // ckb_xiuheibian
            // 
            this.ckb_xiuheibian.AutoSize = true;
            this.ckb_xiuheibian.Location = new System.Drawing.Point(6, 156);
            this.ckb_xiuheibian.Name = "ckb_xiuheibian";
            this.ckb_xiuheibian.Size = new System.Drawing.Size(84, 16);
            this.ckb_xiuheibian.TabIndex = 5;
            this.ckb_xiuheibian.Text = "彩色修黑边";
            this.ckb_xiuheibian.UseVisualStyleBackColor = true;
            // 
            // ckb_quheibian
            // 
            this.ckb_quheibian.AutoSize = true;
            this.ckb_quheibian.Checked = true;
            this.ckb_quheibian.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_quheibian.Location = new System.Drawing.Point(6, 123);
            this.ckb_quheibian.Name = "ckb_quheibian";
            this.ckb_quheibian.Size = new System.Drawing.Size(84, 16);
            this.ckb_quheibian.TabIndex = 4;
            this.ckb_quheibian.Text = "自动去黑边";
            this.ckb_quheibian.UseVisualStyleBackColor = true;
            // 
            // ckb_jiaozheng
            // 
            this.ckb_jiaozheng.AutoSize = true;
            this.ckb_jiaozheng.Checked = true;
            this.ckb_jiaozheng.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckb_jiaozheng.Location = new System.Drawing.Point(6, 92);
            this.ckb_jiaozheng.Name = "ckb_jiaozheng";
            this.ckb_jiaozheng.Size = new System.Drawing.Size(48, 16);
            this.ckb_jiaozheng.TabIndex = 3;
            this.ckb_jiaozheng.Text = "矫正";
            this.ckb_jiaozheng.UseVisualStyleBackColor = true;
            // 
            // bt_youxuanzhuan
            // 
            this.bt_youxuanzhuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_youxuanzhuan.Location = new System.Drawing.Point(99, 54);
            this.bt_youxuanzhuan.Name = "bt_youxuanzhuan";
            this.bt_youxuanzhuan.Size = new System.Drawing.Size(47, 23);
            this.bt_youxuanzhuan.TabIndex = 2;
            this.bt_youxuanzhuan.Text = "旋转↷";
            this.bt_youxuanzhuan.UseVisualStyleBackColor = true;
            // 
            // bt_zuoxuanzhuan
            // 
            this.bt_zuoxuanzhuan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_zuoxuanzhuan.Location = new System.Drawing.Point(37, 54);
            this.bt_zuoxuanzhuan.Name = "bt_zuoxuanzhuan";
            this.bt_zuoxuanzhuan.Size = new System.Drawing.Size(47, 23);
            this.bt_zuoxuanzhuan.TabIndex = 1;
            this.bt_zuoxuanzhuan.Text = "↶旋转";
            this.bt_zuoxuanzhuan.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 607F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(933, 607);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 601);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 601);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.axDoccameraOcx1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(469, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 601);
            this.panel2.TabIndex = 1;
            // 
            // axDoccameraOcx1
            // 
            this.axDoccameraOcx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axDoccameraOcx1.Enabled = true;
            this.axDoccameraOcx1.Location = new System.Drawing.Point(0, 0);
            this.axDoccameraOcx1.Name = "axDoccameraOcx1";
            this.axDoccameraOcx1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axDoccameraOcx1.OcxState")));
            this.axDoccameraOcx1.Size = new System.Drawing.Size(461, 601);
            this.axDoccameraOcx1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 20;
            this.label2.Text = "高拍仪图像：";
            // 
            // form_jieyucamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_queding);
            this.Controls.Add(this.bt_yulan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "form_jieyucamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高拍仪图像采集";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_jieyucamera_FormClosing);
            this.Shown += new System.EventHandler(this.form_jieyucamera_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axDoccameraOcx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_queding;
        private System.Windows.Forms.Button bt_yulan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mingcheng;
        private System.Windows.Forms.Button bt_shuaxin;
        private System.Windows.Forms.ComboBox cb_xiuheibian;
        private System.Windows.Forms.CheckBox ckb_xiuheibian;
        private System.Windows.Forms.CheckBox ckb_quheibian;
        private System.Windows.Forms.CheckBox ckb_jiaozheng;
        private System.Windows.Forms.Button bt_youxuanzhuan;
        private System.Windows.Forms.Button bt_zuoxuanzhuan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        public AxDOCCAMERAOCXLib.AxDoccameraOcx axDoccameraOcx1;
        private System.Windows.Forms.Label label2;

    }
}

