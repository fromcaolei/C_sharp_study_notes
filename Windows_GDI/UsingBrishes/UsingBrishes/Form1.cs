using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace UsingBrishes
{
    public partial class Form1 : Form
    {
        //Brush类的TextureBrush子类用到的变量
        private Image theImage;
        private Image smallImage;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);

            //Brush类的TextureBrush子类用到的变量
            theImage = new Bitmap("../../../taylor.jpg");
            smallImage = new Bitmap(theImage, new Size(theImage.Width / 10, theImage.Height / 10));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, ClientRectangle);  //将工作区域修改为白色


            //①
            g.FillRectangle(Brushes.Red, new Rectangle(10, 10, 50, 50));  //新建红色正方形
            //②即LinearGradientBrush子类的使用：
            Brush linearGradientBrush = new LinearGradientBrush(new Rectangle(10, 60, 50, 50), Color.Blue, Color.White, 45);  //新建一个Brush对象，定义染色区域大小、渐变的两个颜色、渐变角度
            g.FillRectangle(linearGradientBrush, new Rectangle(10, 60, 50, 50));  //使用这个渐变Brush填充这个矩形
            linearGradientBrush.Dispose();  //删除Brush对象
            //③、④、⑤
            g.FillEllipse(Brushes.Aquamarine, new Rectangle(60, 20, 50, 30));  //使用海蓝色填充这个矩形定义的椭圆内部
            g.FillPie(Brushes.Chartreuse, new Rectangle(60, 60, 50, 30), 90, 210);  //使用黄绿色填充这个扇形椭圆的内部
            g.FillPolygon(Brushes.BlueViolet, new Point[] { new Point(110, 10), new Point(150, 10), new Point(160, 40), new Point(120, 20), new Point(120, 60) });  //使用紫罗兰色填充这个多边形内部

            //⑥即TextureBrush子类的使用：
            Brush tBrush = new TextureBrush(smallImage, new Rectangle(0, 0, smallImage.Width, smallImage.Height));  //使用图片作为填充物，而不是像LinearGradientBrush子类（渐变）一样使用纯色填充
            g.FillEllipse(tBrush, new Rectangle(100, 100, ClientRectangle.Width, ClientRectangle.Height));  //使用图片填充这个扇形椭圆的内部
            tBrush.Dispose();
        }
    }
}
