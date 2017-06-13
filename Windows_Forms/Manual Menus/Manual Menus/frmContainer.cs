using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manual_Menus
{
    public partial class FrmContainer : Form
    {
        private int mCounter;
        
        public FrmContainer()
        {
            InitializeComponent();

            this.MainMenuStrip = this.menuStrip1;  //设置主菜单这一句容易出现“漏掉”，导致和子窗口菜单栏无法合并的现象

            mCounter = 1;
            frmEditor newForm = new frmEditor(this, mCounter);
            newForm.Show();
        }

        private void ToolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            frmEditor newForm = new frmEditor(this, ++mCounter);
            newForm.Show();
        }

        private void ToolStripMenuItemTile_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);  //使MDI子窗口平铺
        }

        private void ToolStripMenuItemCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);  //使MDI子窗口重叠
        }
    }
}
