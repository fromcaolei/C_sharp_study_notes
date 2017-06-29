using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingLines
{
    public partial class Form1 : Form
    {
        //在图像中创建钢笔用到
        private Image theImage;
        private Image smallImage;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);

            //在图像中创建钢笔用到
            theImage = new Bitmap("../../../taylor.jpg");
            smallImage = new Bitmap(theImage, new Size(theImage.Width / 10, theImage.Height / 10));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, ClientRectangle);  //将工作区域修改为白色

            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                if (ClientRectangle.Height / 10 > 0)
                {
                    for (int y = 0; y < ClientRectangle.Height; y += ClientRectangle.Height / 10)
                    {
                        g.DrawLine(blackPen, new Point(0, 0), new Point(ClientRectangle.Width, y));
                    }
                }
            }

            //在图像中创建钢笔
            Brush tBrush = new TextureBrush(smallImage, new Rectangle(0, 0, smallImage.Width, smallImage.Height));
            Pen tPen = new Pen(tBrush, 40);
            g.DrawRectangle(tPen, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            //g.FillRectangle(tBrush, ClientRectangle);  //描绘Draw不同于填充Fill，无法使用Brush对象进行描绘，只能使用Pen对象
            tPen.Dispose();
            tBrush.Dispose();

            //用图像绘制文本
            Brush mBrush = new TextureBrush(smallImage, new Rectangle(0, 0, smallImage.Width, smallImage.Height));
            Font trFont = new Font("Times New Roman", 16, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Taylor Swift", trFont, mBrush, new Rectangle(30, 200, 160, trFont.Height));
            mBrush.Dispose();
            trFont.Dispose();
        }
    }
}
