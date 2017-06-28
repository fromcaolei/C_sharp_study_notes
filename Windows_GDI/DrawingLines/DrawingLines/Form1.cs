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
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

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
        }
    }
}
