using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace JieYuCamera
{
    public partial class form_jieyucamera : Form
    {
        private string g_path = @"./temp.jpg";
        private int turn = 270;
        public Image g_img = null;
        public string g_filename = "";

        public form_jieyucamera()
        {
            InitializeComponent();
        }

        private void form_jieyucamera_Shown(object sender, EventArgs e)
        {
            if (axDoccameraOcx1.bStartPlayRotate(Convert.ToInt16(turn)) == false)
            {
                this.Close();
            }
            cb_xiuheibian.Text = "10";
        }

        private void bt_zuoxuanzhuan_Click(object sender, EventArgs e)
        {
            axDoccameraOcx1.bStopPlay();
            if (turn - 90 < 0)
            {
                turn = (turn - 90 + 360);
            }
            else
            {
                turn -= 90;
            }
            axDoccameraOcx1.bStartPlayRotate(Convert.ToInt16(turn));
        }

        private void bt_youxuanzhuan_Click(object sender, EventArgs e)
        {
            axDoccameraOcx1.bStopPlay();
            if (turn + 90 >= 360)
            {
                turn = (turn + 90 - 360);
            }
            else
            {
                turn += 90;
            }
            axDoccameraOcx1.bStartPlayRotate(Convert.ToInt16(turn));
        }

        private void bt_yulan_Click(object sender, EventArgs e)
        {
            if (File.Exists(g_path))
            {
                FileAttributes attr = File.GetAttributes(g_path);
                File.Delete(g_path);
            }
            if (Directory.Exists(g_path))
            {
                FileAttributes attr = File.GetAttributes(g_path);
                Directory.Delete(g_path, true);
            }

            axDoccameraOcx1.vSetSkewFlag(ckb_jiaozheng.Checked);
            axDoccameraOcx1.vSetDelHBFlag(ckb_quheibian.Checked);
            axDoccameraOcx1.vRepairEdgeFlag(Convert.ToInt16(ckb_xiuheibian.Checked == true ? 1 : 0), Convert.ToInt16(cb_xiuheibian.Text));
            axDoccameraOcx1.bSaveJPG(@"./", "temp");

            System.IO.FileStream fs = null;
            fs = new System.IO.FileStream(g_path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            pictureBox1.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
        }

        private void bt_queding_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("请生成一个预览图片！");
                return;
            }
            if (txt_mingcheng.Text.Trim().Length == 0)
            {
                MessageBox.Show("请先输入一个图片文件名！");
                return;
            }

            g_img = null;
            g_filename = "";

            Image temp = Image.FromFile(g_path);
            Bitmap bmp = new Bitmap(temp);
            g_img = bmp;
            temp.Dispose();

            g_filename = txt_mingcheng.Text.Trim() + ".jpg";
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }

        private void bt_shuaxin_Click(object sender, EventArgs e)
        {
            axDoccameraOcx1.bStopPlay();
            axDoccameraOcx1.bStartPlayRotate(Convert.ToInt16(turn));
        }

        private void form_jieyucamera_FormClosing(object sender, FormClosingEventArgs e)
        {
            axDoccameraOcx1.bStopPlay();
        }
    }
}
