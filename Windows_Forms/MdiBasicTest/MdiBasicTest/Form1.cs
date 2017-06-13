using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MdiBasicTest
{
    public partial class frmContainer : Form
    {
        public frmContainer()
        {
            InitializeComponent();

            MdiBasicTest.frmChild child = new MdiBasicTest.frmChild(this);
            child.Show();

            frmChild child2 = new frmChild();
            child2.MdiParent = this;
            child2.Show();
        }
    }
}
