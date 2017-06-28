using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawImage
{
    public partial class Form1 : Form
    {
        private Image theImage;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.Opaque, true);
            theImage = new Bitmap("taylor.jpg");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(theImage, ClientRectangle);
        }

        //修改Designer代码中的Dispose方法为：
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        theImage.Dispose();
        //    }
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
