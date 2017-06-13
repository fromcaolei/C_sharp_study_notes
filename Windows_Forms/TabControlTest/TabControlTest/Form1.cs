using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TabControlTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowMessage_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.textBoxMessage.Text);  //此处的this为全局标题栏的指针，而不是标签页的指针
        }
    }
}
