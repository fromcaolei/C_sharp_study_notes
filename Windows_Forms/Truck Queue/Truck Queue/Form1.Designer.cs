namespace Truck_Queue
{
    partial class Truck_Queue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Truck_Queue));
            this.modelSelection = new System.Windows.Forms.GroupBox();
            this.bigTruck = new System.Windows.Forms.RadioButton();
            this.smallTruck = new System.Windows.Forms.RadioButton();
            this.licenseNumber = new System.Windows.Forms.TextBox();
            this.telephoneNumber = new System.Windows.Forms.TextBox();
            this.startQueuing = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.license = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.receiptInformation = new System.Windows.Forms.Label();
            this.complete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.labelInput = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.currentQueue = new System.Windows.Forms.Label();
            this.receiptInformationBox = new System.Windows.Forms.RichTextBox();
            this.currentQueueBox = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.modelSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // modelSelection
            // 
            this.modelSelection.Controls.Add(this.bigTruck);
            this.modelSelection.Controls.Add(this.smallTruck);
            this.modelSelection.Location = new System.Drawing.Point(14, 34);
            this.modelSelection.Name = "modelSelection";
            this.modelSelection.Size = new System.Drawing.Size(213, 56);
            this.modelSelection.TabIndex = 0;
            this.modelSelection.TabStop = false;
            this.modelSelection.Text = "车型选择：";
            // 
            // bigTruck
            // 
            this.bigTruck.AutoSize = true;
            this.bigTruck.Location = new System.Drawing.Point(137, 21);
            this.bigTruck.Name = "bigTruck";
            this.bigTruck.Size = new System.Drawing.Size(47, 16);
            this.bigTruck.TabIndex = 1;
            this.bigTruck.TabStop = true;
            this.bigTruck.Text = "大车";
            this.bigTruck.UseVisualStyleBackColor = true;
            // 
            // smallTruck
            // 
            this.smallTruck.AutoSize = true;
            this.smallTruck.Location = new System.Drawing.Point(24, 21);
            this.smallTruck.Name = "smallTruck";
            this.smallTruck.Size = new System.Drawing.Size(47, 16);
            this.smallTruck.TabIndex = 0;
            this.smallTruck.TabStop = true;
            this.smallTruck.Text = "小车";
            this.smallTruck.UseVisualStyleBackColor = true;
            // 
            // licenseNumber
            // 
            this.licenseNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.licenseNumber.Location = new System.Drawing.Point(83, 114);
            this.licenseNumber.Name = "licenseNumber";
            this.licenseNumber.Size = new System.Drawing.Size(143, 21);
            this.licenseNumber.TabIndex = 1;
            this.licenseNumber.Tag = "false";
            this.licenseNumber.TextChanged += new System.EventHandler(this.licenseNumber_TextChanged);
            this.licenseNumber.Validating += new System.ComponentModel.CancelEventHandler(this.licenseNumber_Validating);
            // 
            // telephoneNumber
            // 
            this.telephoneNumber.Location = new System.Drawing.Point(83, 155);
            this.telephoneNumber.Name = "telephoneNumber";
            this.telephoneNumber.Size = new System.Drawing.Size(144, 21);
            this.telephoneNumber.TabIndex = 2;
            this.telephoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telephoneNumber_KeyPress);
            // 
            // startQueuing
            // 
            this.startQueuing.Enabled = false;
            this.startQueuing.Location = new System.Drawing.Point(20, 189);
            this.startQueuing.Name = "startQueuing";
            this.startQueuing.Size = new System.Drawing.Size(75, 23);
            this.startQueuing.TabIndex = 3;
            this.startQueuing.Text = "开始排队";
            this.startQueuing.UseVisualStyleBackColor = true;
            this.startQueuing.Click += new System.EventHandler(this.startQueuing_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // license
            // 
            this.license.AutoSize = true;
            this.license.Location = new System.Drawing.Point(12, 117);
            this.license.Name = "license";
            this.license.Size = new System.Drawing.Size(53, 12);
            this.license.TabIndex = 6;
            this.license.Text = "车牌号：";
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.Location = new System.Drawing.Point(11, 158);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(65, 12);
            this.telephone.TabIndex = 7;
            this.telephone.Text = "司机电话：";
            // 
            // receiptInformation
            // 
            this.receiptInformation.AutoSize = true;
            this.receiptInformation.Location = new System.Drawing.Point(12, 228);
            this.receiptInformation.Name = "receiptInformation";
            this.receiptInformation.Size = new System.Drawing.Size(65, 12);
            this.receiptInformation.TabIndex = 8;
            this.receiptInformation.Text = "凭条信息：";
            // 
            // complete
            // 
            this.complete.Location = new System.Drawing.Point(311, 507);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(75, 23);
            this.complete.TabIndex = 11;
            this.complete.Text = "完成卸货";
            this.complete.UseVisualStyleBackColor = true;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(410, 507);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(509, 507);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(653, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(767, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(653, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(767, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(653, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(767, 342);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 12);
            this.label10.TabIndex = 19;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(653, 405);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 20;
            this.label11.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(767, 405);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "label12";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(810, 507);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 22;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(14, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(101, 12);
            this.labelInput.TabIndex = 23;
            this.labelInput.Text = "请录入车辆信息：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(624, 34);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(214, 95);
            this.textBox4.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(653, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 25;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(767, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 26;
            this.label14.Text = "label14";
            // 
            // currentQueue
            // 
            this.currentQueue.AutoSize = true;
            this.currentQueue.Location = new System.Drawing.Point(311, 13);
            this.currentQueue.Name = "currentQueue";
            this.currentQueue.Size = new System.Drawing.Size(65, 12);
            this.currentQueue.TabIndex = 28;
            this.currentQueue.Text = "当前队列：";
            // 
            // receiptInformationBox
            // 
            this.receiptInformationBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.receiptInformationBox.Location = new System.Drawing.Point(13, 244);
            this.receiptInformationBox.Name = "receiptInformationBox";
            this.receiptInformationBox.ReadOnly = true;
            this.receiptInformationBox.Size = new System.Drawing.Size(214, 286);
            this.receiptInformationBox.TabIndex = 27;
            this.receiptInformationBox.Text = "";
            // 
            // currentQueueBox
            // 
            this.currentQueueBox.CheckBoxes = true;
            this.currentQueueBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.currentQueueBox.FullRowSelect = true;
            this.currentQueueBox.Location = new System.Drawing.Point(313, 34);
            this.currentQueueBox.Name = "currentQueueBox";
            this.currentQueueBox.Size = new System.Drawing.Size(271, 467);
            this.currentQueueBox.SmallImageList = this.imageList1;
            this.currentQueueBox.TabIndex = 29;
            this.currentQueueBox.UseCompatibleStateImageBehavior = false;
            this.currentQueueBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "";
            this.columnHeader1.Text = "排队编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "车型";
            this.columnHeader2.Width = 40;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "车牌号";
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "司机电话";
            this.columnHeader4.Width = 102;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "small.jpg");
            this.imageList1.Images.SetKeyName(1, "large.jpg");
            // 
            // Truck_Queue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 542);
            this.Controls.Add(this.currentQueueBox);
            this.Controls.Add(this.currentQueue);
            this.Controls.Add(this.receiptInformationBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.receiptInformation);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.license);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startQueuing);
            this.Controls.Add(this.telephoneNumber);
            this.Controls.Add(this.licenseNumber);
            this.Controls.Add(this.modelSelection);
            this.MinimumSize = new System.Drawing.Size(913, 580);
            this.Name = "Truck_Queue";
            this.Text = "卡车排队";
            this.modelSelection.ResumeLayout(false);
            this.modelSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox modelSelection;
        private System.Windows.Forms.RadioButton bigTruck;
        private System.Windows.Forms.RadioButton smallTruck;
        private System.Windows.Forms.TextBox licenseNumber;
        private System.Windows.Forms.TextBox telephoneNumber;
        private System.Windows.Forms.Button startQueuing;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label license;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.Label receiptInformation;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label currentQueue;
        private System.Windows.Forms.RichTextBox receiptInformationBox;
        private System.Windows.Forms.ListView currentQueueBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

