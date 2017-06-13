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
    public partial class frmEditor : Form
    {
        public frmEditor(FrmContainer parent, int counter)
        {
            InitializeComponent();

            this.toolStripComboBoxFonts.SelectedIndex = 0;  //将工具栏中ComboBox的默认值设为第一个项

            this.MdiParent = parent;
            this.Text = "Editor " + counter.ToString();
        }

        //菜单栏：显示帮助
        private void MenuItemShowHelpMenu_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            MenuItemHelp.Visible = item.Checked;  //为false时，不显示该菜单项
        }

        //菜单栏：新建
        private void MenuItemNew_Click(object sender, EventArgs e)
        {
            richTextBoxText.Text = "";
        }

        //菜单栏：保存
        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.SaveFile(@".\Example.rtf");
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        //菜单栏：打开
        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.LoadFile(@".\Example.rtf");
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        //菜单栏：退出
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        //工具栏：修改字体三事件：
        private void toolStripButtonBold_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFond;

            bool checkState = ((ToolStripButton)sender).Checked;  //键按下时，Checked值为true

            oldFont = this.richTextBoxText.SelectionFont;  //获得当前字体属性

            if (!checkState)
                newFond = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFond = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            this.richTextBoxText.SelectionFont = newFond;
            this.richTextBoxText.Focus();

            //说明一下三行：工具栏和菜单栏的黑体按钮具备同样的功能，但它们之间互相要有同步联系。
            //当工具栏按钮的Checked值改变时，会触发本CheckedChanged事件函数。
            //使菜单栏按钮的Checked键变为选中状态就需要为其赋值为checkState的值，使菜单栏和工具栏按钮选中状态同步，但此时也会触发菜单栏的CheckedChanged事件。
            //这里为防止触发菜单栏的CheckedChanged事件造成资源浪费，在改变菜单栏Checked值之前先取消事件托管，改变完成后再恢复。
            this.ToolStripMenuItemBold.CheckedChanged -= new EventHandler(ToolStripMenuItemBold_CheckedChanged);
            this.ToolStripMenuItemBold.Checked = checkState;  //菜单栏上的黑体键属性
            this.ToolStripMenuItemBold.CheckedChanged += new EventHandler(ToolStripMenuItemBold_CheckedChanged);

            this.toolStripStatusLabelBold.Enabled = checkState;
        }

        private void toolStripButtonItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            oldFont = this.richTextBoxText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();

            this.ToolStripMenuItemItalic.CheckedChanged -= new EventHandler(ToolStripMenuItemItalic_CheckedChanged);
            this.ToolStripMenuItemItalic.Checked = checkState;
            this.ToolStripMenuItemItalic.CheckedChanged += new EventHandler(ToolStripMenuItemItalic_CheckedChanged);

            this.toolStripStatusLabelItalic.Enabled = checkState;
        }

        private void toolStripButtonUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            oldFont = this.richTextBoxText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();

            this.ToolStripMenuItemUnderline.CheckedChanged -= new EventHandler(ToolStripMenuItemUnderline_CheckedChanged);
            this.ToolStripMenuItemUnderline.Checked = checkState;
            this.ToolStripMenuItemUnderline.CheckedChanged +=new EventHandler(ToolStripMenuItemUnderline_CheckedChanged);

            this.toolStripStatusLabelUnderline.Enabled = checkState;
        }
        
        //菜单栏：修改字体三事件：
        private void ToolStripMenuItemBold_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStripButtonBold.Checked = ToolStripMenuItemBold.Checked;
        }

        private void ToolStripMenuItemItalic_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStripButtonItalic.Checked = ToolStripMenuItemItalic.Checked;
        }

        private void ToolStripMenuItemUnderline_CheckedChanged(object sender, EventArgs e)
        {
            this.toolStripButtonUnderline.Checked = ToolStripMenuItemUnderline.Checked;
        }

        //ComboBox修改字体事件
        private void toolStripComboBoxFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
            //MessageBox.Show(text);
            Font newFont = new Font(text, richTextBoxText.SelectionFont.Size, richTextBoxText.SelectionFont.Style);
            richTextBoxText.SelectionFont = newFont;
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            this.toolStripStatusLabelText.Text = "Number of charachers: " + richTextBoxText.Text.Length;
        }
    }
}
