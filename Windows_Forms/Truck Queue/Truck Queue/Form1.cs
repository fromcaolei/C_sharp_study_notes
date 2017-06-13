using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Truck_Queue
{
    public partial class Truck_Queue : Form
    {
        public static int number = 0;
        ListViewGroup lvgInside = new ListViewGroup();
        ListViewGroup lvgExternal = new ListViewGroup();
        public Truck_Queue()
        {
            InitializeComponent();

            this.licenseNumber.Tag = false;

            lvgInside.Header = "正在卸货";
            lvgInside.HeaderAlignment = HorizontalAlignment.Center;
            lvgExternal.Header = "正在排队";
            lvgExternal.HeaderAlignment = HorizontalAlignment.Center;
        }

        //返回ListViewItem的数量
        private int listViewItemSize(ListView lv)
        {
            int itemNumber = 0;
            foreach (ListViewItem lvi in lv.Items)
                itemNumber++;
            return itemNumber;
        }

        //用排队信息填充列表视图
        private void PaintListView(string number, string model, string licenseNumber, string telephoneNumber)
        {
            try
            {
                ListViewItem lvi;  //创建一个列表视图项和列表视图子项
                ListViewItem.ListViewSubItem lvsi;

                this.currentQueueBox.Groups.Add(lvgInside);
                this.currentQueueBox.Groups.Add(lvgExternal);

                if (licenseNumber.CompareTo("") == 0)
                    return;

                this.currentQueueBox.BeginUpdate();

                lvi = new ListViewItem();  //创建主视图列表选项
                lvi.Text = number;  //文件夹名
                lvi.Tag = number;
                if (model == "小车")
                    lvi.ImageIndex = 0;  //文件夹图标指数为0，用来指定ImageList中所储图像的编号
                else if (model == "大车")
                    lvi.ImageIndex = 1;

                lvsi = new ListViewItem.ListViewSubItem();  //创建视图列表子选项
                lvsi.Text = model;
                lvi.SubItems.Add(lvsi);  //将子项目添加到列表视图项目中

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = licenseNumber;
                lvi.SubItems.Add(lvsi);

                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = telephoneNumber;
                lvi.SubItems.Add(lvsi);

                if (listViewItemSize(this.currentQueueBox) < 3)  //！！！！！！！还未按大小车进行优化，需修改
                    lvgInside.Items.Add(lvi);
                else
                    lvgExternal.Items.Add(lvi);

                this.currentQueueBox.Items.Add(lvi);
                this.currentQueueBox.EndUpdate();
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        //开始排队键的单击事件，功能实现
        private void startQueuing_Click(object sender, EventArgs e)
        {
            //string input = "\0";
            string model = "\0";

            number++;

            //调用核心排队函数
            core_Queue();

            //将录入数据放入ListViewBox
            if (this.bigTruck.Checked == true)
                model = "大车";
            else if (this.smallTruck.Checked == true)
                model = "小车";
            PaintListView(number.ToString(), model, this.licenseNumber.Text, this.telephoneNumber.Text);
            
            //将录入数据凭条打印预览显示出来
            this.receiptInformationBox.Clear();
            string regions, attribute, licensePlate, queueNumber, driverPhone;
            regions = "北郊一号库" + "\r\n\n";
            queueNumber = "排队编号：" + number.ToString() + "\r\n\n";
            attribute = "车型：" + model + "\r\n";
            licensePlate = "车牌号： " + this.licenseNumber.Text + "\r\n";
            driverPhone = "司机电话：" + this.telephoneNumber.Text + "\r\n";
            #region 字体变化
            this.receiptInformationBox.Text = regions;
            this.receiptInformationBox.Text += queueNumber;
            this.receiptInformationBox.Text += attribute;
            this.receiptInformationBox.Text += licensePlate;
            this.receiptInformationBox.Text += driverPhone;

            this.receiptInformationBox.SelectionStart = 0;
            this.receiptInformationBox.SelectionLength = regions.Length - 1;
            this.receiptInformationBox.SelectionFont = new System.Drawing.Font("黑体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.receiptInformationBox.SelectionColor = System.Drawing.Color.Blue;
            this.receiptInformationBox.SelectionAlignment = HorizontalAlignment.Center;

            this.receiptInformationBox.SelectionStart = regions.Length - 1;
            this.receiptInformationBox.SelectionLength = queueNumber.Length;
            this.receiptInformationBox.SelectionFont = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.receiptInformationBox.SelectionAlignment = HorizontalAlignment.Center;
            this.receiptInformationBox.SelectionColor = System.Drawing.Color.Red;

            this.receiptInformationBox.SelectionStart = regions.Length + queueNumber.Length - 2;
            this.receiptInformationBox.SelectionLength = attribute.Length;
            this.receiptInformationBox.SelectionFont = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.receiptInformationBox.SelectionAlignment = HorizontalAlignment.Left;
            this.receiptInformationBox.SelectionColor = System.Drawing.Color.Black;

            this.receiptInformationBox.SelectionStart = regions.Length + queueNumber.Length + attribute.Length - 3;
            this.receiptInformationBox.SelectionLength = licensePlate.Length;
            this.receiptInformationBox.SelectionFont = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.receiptInformationBox.SelectionAlignment = HorizontalAlignment.Left;
            this.receiptInformationBox.SelectionColor = System.Drawing.Color.Black;

            this.receiptInformationBox.SelectionStart = regions.Length + queueNumber.Length + attribute.Length + licensePlate.Length - 4;
            this.receiptInformationBox.SelectionLength = driverPhone.Length;
            this.receiptInformationBox.SelectionFont = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.receiptInformationBox.SelectionAlignment = HorizontalAlignment.Left;
            this.receiptInformationBox.SelectionColor = System.Drawing.Color.Black;
            #endregion

            this.licenseNumber.Text = "";
            this.telephoneNumber.Text = "";
            this.licenseNumber.Focus();
        }

        //电话号码的文本框每按一键事件，只允许输入数字
        private void telephoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        //车牌号文本框失去焦点验证事件，提示为输入车牌号显示红色
        private void licenseNumber_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                //tb.Tag = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                //tb.Tag = true;
            }
        }

        //车牌号文本框文本变化事件，不输入车牌号不允许排队
        private void licenseNumber_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                this.startQueuing.Enabled = false;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                this.startQueuing.Enabled = true;
            }
        }

        //核心排队函数
        private void core_Queue()
        { 
            
        }

        //删除选中的项，表示卸货完毕
        private void complete_Click(object sender, EventArgs e)
        {
            /*int Index = 0, countNumber = 0;
            ListViewItem lvi;
            //lvi = this.currentQueueBox.Items[upper];

            foreach (ListViewItem rm in this.currentQueueBox.CheckedItems)
            {
                Index = rm.Index;  //取当前选中项的index,SelectedItems[0]这必须为0
                this.currentQueueBox.Items[Index].Remove();
                countNumber++;
            }

            //将排队中的最靠前车辆放入卸货区
            if (lvgInside.Items.Count < 3 && lvgExternal.Items.Count > 0)
            {
                //lvgExternal.Items.Remove(this.currentQueueBox.Items[upper]);
                //lvgInside.Items.Add((ListViewItem)this.currentQueueBox.Items[upper]);  //！！！！！！！！！！！！！也未做优化
            }*/

            int indexMax = currentQueueBox.CheckedItems[currentQueueBox.CheckedItems.Count - 1].Index;

            if (indexMax < currentQueueBox.Items.Count - 1)
            {
                for (int i = currentQueueBox.CheckedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem lvi = currentQueueBox.CheckedItems[i];
                    int index = currentQueueBox.CheckedItems[i].Index;
                    currentQueueBox.Items.RemoveAt(index);
                    //lvgInside.Items.Insert(index + 1, lvi);
                    currentQueueBox.Items.Insert(index + 1, lvi);
                }
            }

            if (currentQueueBox.Items.Count > 0 && currentQueueBox.CheckedItems.Count > 0)
            {
                currentQueueBox.Focus();
                currentQueueBox.CheckedItems[currentQueueBox.CheckedItems.Count - 1].Focused = true;
                currentQueueBox.CheckedItems[currentQueueBox.CheckedItems.Count - 1].EnsureVisible();
            }

        }
    }
}
