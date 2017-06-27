using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DrawingPaths
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path;  //表示一系列连接的线条和曲线，构造一条路径
            Point[] pointArray = { new Point(10, 10), new Point(150, 10), new Point(200, 150), new Point(10, 150), new Point(200, 160) };
            byte[] byteArray = { (byte)PathPointType.Start, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line };

            path = new GraphicsPath(pointArray, byteArray);  //这两行作用一致
            /*path = new GraphicsPath(new Point[] { new Point(10, 10), new Point(150, 10), new Point(200, 150), new Point(10, 150), new Point(200, 160) },
                                    new byte[] { (byte)PathPointType.Start, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line, (byte)PathPointType.Line });*/

            e.Graphics.DrawPath(Pens.Black, path);  //调用DrawPath()方法绘制
        }
    }
}
