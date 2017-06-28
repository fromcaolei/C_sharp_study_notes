using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
            Bounds = new Rectangle(0, 0, 500, 300);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, ClientRectangle);  //将工作区域修改为白色

            int y = 0;
            Rectangle rect = new Rectangle(0, y, 400, Font.Height);  //绘制一个矩形用来放字
            g.DrawRectangle(Pens.Blue, rect);
            g.DrawString("This text is left justified.", Font, Brushes.Black, rect);  //将绘制的字符放入矩形中，并绘制，可以不设置sf
            y += Font.Height + 20;

            Font aFont = new Font("Arial", 16, FontStyle.Bold | FontStyle.Italic);  //设置字体对象，宋体、16号、加粗、倾斜
            rect = new Rectangle(0, y, 400, aFont.Height);  //修改矩形变量的参数
            g.DrawRectangle(Pens.Blue, rect);  //绘制这个矩形来放字符

            StringFormat sf = new StringFormat();  //设置格式对象
            sf.Alignment = StringAlignment.Far;
            g.DrawString("This text is right justified.", aFont, Brushes.Blue, rect, sf);  //将绘制的字符放入矩形中，并绘制
            y += aFont.Height + 20;
            aFont.Dispose();  //删除对象


            //一下代码功能重复，为效果不同的例子而已
            Font cFont = new Font("Courier New", 12, FontStyle.Underline);
            rect = new Rectangle(0, y, 400, cFont.Height);
            g.DrawRectangle(Pens.Blue, rect);
            sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            g.DrawString("This text is centered and underlined.", cFont, Brushes.Red, rect, sf);
            y += cFont.Height + 20;
            cFont.Dispose();

            Font trFont = new Font("Times New Roman", 12);
            rect = new Rectangle(0, y, 400, trFont.Height * 3);
            g.DrawRectangle(Pens.Blue, rect);
            string longString = "This text is much longer, and drawn ";
            longString += "into a rectangle that is higher than ";
            longString += "one line, so that it will wrap. It is ";
            longString += "very easy to wrap text using GDI+.";
            g.DrawString(longString, trFont, Brushes.Black, rect);
            trFont.Dispose();

        }
    }
}
