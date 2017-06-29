using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DoubleBuffer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, ClientRectangle);  //将工作区域修改为白色

            Random r = new Random();

            //双倍缓冲用到的代码
            Image i = new Bitmap(ClientRectangle.Width, ClientRectangle.Height);
            Graphics dg = Graphics.FromImage(i);  //不应使用new，FromImage是一个静态方法，而不是一个类型

            for (int x = 0; x < ClientRectangle.Width; x++)
            {
                for (int y = 0; y < ClientRectangle.Height; y += 10)
                {
                    Color c = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255));
                    using (Pen p = new Pen(c, 1))
                    {
                        //低性能原代码
                        //g.DrawLine(p, new Point(0, 0), new Point(x, y));  ///////////////////

                        //双倍缓冲用到的代码
                        dg.DrawLine(p, new Point(0, 0), new Point(x, y));  ////////////////////
                    }
                }
            }

            //双倍缓冲用到的代码
            g.DrawImage(i, ClientRectangle);  /////////////////////
            i.Dispose();
        }
    }
}
