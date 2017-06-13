using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ListViewTest
{
    public partial class ListView : Form
    {
        private System.Collections.Specialized.StringCollection folderCol;  //定义一个用于包含前面浏览过的文件夹的字段

        //在列表视图中创建列标题
        private void CreatHeadersAndFillListView()
        {
            ColumnHeader colHead;
            //First header
            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            this.listViewFilesAndFolders.Columns.Add(colHead);  //创建三个列标题，把它添加到ListView的Columns集合
            //Second header
            colHead = new ColumnHeader();
            colHead.Text = "Size";
            this.listViewFilesAndFolders.Columns.Add(colHead);
            //Third header
            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            this.listViewFilesAndFolders.Columns.Add(colHead);
        }

        //用硬盘上的文件和文件夹填充列表视图
        private void PaintListView(string root)
        {
            try
            {
                ListViewItem lvi;  //创建一个列表视图项和列表视图子项
                ListViewItem.ListViewSubItem lvsi;

                if (root.CompareTo("") == 0)
                    return;

                DirectoryInfo dir = new DirectoryInfo(root);  //获取有关根文件夹的信息

                DirectoryInfo[] dirs = dir.GetDirectories();  //从根文件夹中检索文件夹
                FileInfo[] files = dir.GetFiles();  //从根文件夹中检索文件

                this.listViewFilesAndFolders.Items.Clear();  //清除列表视图的项目集合

                this.labelCurrentPath.Text = root;  //为标签控件设置路径
                this.listViewFilesAndFolders.BeginUpdate();  //锁定列表视图

                //通过遍历根文件夹中的所有文件夹，插入它们
                foreach (System.IO.DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();  //创建主视图列表选项
                    lvi.Text = di.Name;  //文件夹名
                    lvi.ImageIndex = 0;  //文件夹图标指数为0，也就是用来指定ImageList中所储图像的编号！！！
                    lvi.Tag = di.FullName;  //将标签设置为文件夹的合格路径

                    lvsi = new ListViewItem.ListViewSubItem();  //创建两个视图列表子选项
                    lvsi.Text = "";  //一个文件夹没有大小，所以这个列是的空
                    lvi.SubItems.Add(lvsi);  //将子项目添加到列表视图项目中

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();  //上次访问的时间
                    lvi.SubItems.Add(lvsi);

                    this.listViewFilesAndFolders.Items.Add(lvi);  //将列表视图项目添加到列表视图的项目集合中
                }

                //遍历根文件夹中的所有文件
                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;  //文件图标指数为1

                    lvi.Tag = fi.FullName;  //将标签设置为文件夹的合格路径

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();  //文件的长度
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    this.listViewFilesAndFolders.Items.Add(lvi);
                }

                this.listViewFilesAndFolders.EndUpdate();  //解锁列表视图，将已插入的项目显示出来
            }
            catch (System.Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        //用于双击ListView中的选项浏览文件夹
        private void listViewFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();  //tag包含被双击文件或文件夹的完全限定路径

            if (lw.SelectedItems[0].ImageIndex != 0)  //找出不是文件夹的文件，用所指定的图标指数来确定是否为文件夹
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);  //尝试运行该文件
                }
                catch
                {
                    return;
                }
            }
            else
            {
                //插入项
                PaintListView(filename);
                folderCol.Add(filename);  //把新文件夹添加到folderCol集合中
            }
        }

        public ListView()
        {
            InitializeComponent();

            //初始化列表视图和文件夹集合
            folderCol = new System.Collections.Specialized.StringCollection();
            folderCol.Add(@"C:\");

            CreatHeadersAndFillListView();
            PaintListView(@"C:\");
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (folderCol.Count > 1)  //返回上级目录
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else  //留在根目录
            {
                PaintListView(folderCol[0].ToString());
            }
        }

        private void Largelcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rgb = (RadioButton)sender;
            if (rgb.Checked)
                this.listViewFilesAndFolders.View = View.LargeIcon ;
        }

        private void SmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rgb = (RadioButton)sender;
            if (rgb.Checked)
                this.listViewFilesAndFolders.View = View.SmallIcon;
        }

        private void List_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rgb = (RadioButton)sender;
            if (rgb.Checked)
                this.listViewFilesAndFolders.View = View.List;
        }

        private void Details_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rgb = (RadioButton)sender;
            if (rgb.Checked)
                this.listViewFilesAndFolders.View = View.Details;
        }

        private void Tile_CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rgb = (RadioButton)sender;
            if (rgb.Checked)
                this.listViewFilesAndFolders.View = View.Tile;
        }
    }
}
