using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawingRegions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ////构造两个矩形
            //Rectangle r1 = new Rectangle(10, 10, 50, 50);
            //Rectangle r2 = new Rectangle(40, 40, 50, 50);

            //Region r = new Region(r1);  //表示一个复杂的图形，有矩形和路径组成。此时用第一个矩形对象进行初始化
            //r.Union(r2);  //联合第二个矩形对象

            //GraphicsPath path = new GraphicsPath(new Point[] { new Point(45, 45), new Point(145, 55), new Point(200, 150), new Point(75, 150), new Point(45, 45) },
            //                                     new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Bezier, (byte)PathPointType.Bezier, (byte)PathPointType.Bezier, (byte)PathPointType.Line });
            //r.Union(path);  //联合一个路径对象,使用r.Intersect(path);则获取一个图形对象与自身图形的交集部分

            ////定义一个颜色
            //if (colorDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    SolidBrush b = new SolidBrush(colorDialog1.Color);
            //    e.Graphics.FillRegion(b, r);
            //}
            //else
            //{
            //    e.Graphics.FillRegion(Brushes.Blue, r);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Graphics g = CreateGraphics())
            {
                //构造两个矩形
                Rectangle r1 = new Rectangle(10, 10, 50, 50);
                Rectangle r2 = new Rectangle(40, 40, 50, 50);

                Region r = new Region(r1);  //表示一个复杂的图形，有矩形和路径组成。此时用第一个矩形对象进行初始化
                r.Union(r2);  //联合第二个矩形对象

                GraphicsPath path = new GraphicsPath(new Point[] { new Point(45, 45), new Point(145, 55), new Point(200, 150), new Point(75, 150), new Point(45, 45) },
                                                     new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Bezier, (byte)PathPointType.Bezier, (byte)PathPointType.Bezier, (byte)PathPointType.Line });
                r.Union(path);  //联合一个路径对象
                //r.Intersect(path);  //获取一个图形对象与自身图形的交集部分

                //定义一个颜色
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    SolidBrush b = new SolidBrush(colorDialog1.Color);
                    g.FillRegion(b, r);
                }
                else
                {
                    g.FillRegion(Brushes.Blue, r);
                }
            }
        }
    }
}
