using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabelTextboxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ctLabelTextbox1_PositionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctLabelTextbox1.Position = ctLabelTextbox1.Position == LabelTextBox.ctLabelTextbox.PositionEnum.Right ? LabelTextBox.ctLabelTextbox.PositionEnum.Below : LabelTextBox.ctLabelTextbox.PositionEnum.Right;
        }
    }
}
