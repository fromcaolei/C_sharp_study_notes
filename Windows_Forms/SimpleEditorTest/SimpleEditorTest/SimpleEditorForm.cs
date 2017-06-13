using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Printing;

namespace SimpleEditorTest
{
    public partial class SimpleEditorForm : Form
    {
        private string filename = "Untitled";

        private string[] lines;
        private int linesPrinted;

        //用于打开一个文件（txt）
        protected void OpenFile()
        {
            try
            {
                TextBoxEdit.Clear();
                TextBoxEdit.Text = File.ReadAllText(filename);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //用于保存一个文件（txt）
        protected void saveFile()
        {
            try
            {
                File.WriteAllText(filename, TextBoxEdit.Text);
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //用于提取打开或保存的文件名，设置给窗体的标题
        protected void SetFormTitle()
        {
            FileInfo fileinfo = new FileInfo(filename);  //FileInfo类用于获取文件名，但不包括存储在fileName变量中的路径
            this.Text = fileinfo.Name + " - Simple Editor";
        }

        public SimpleEditorForm(string filename)
        {
            InitializeComponent();

            if (filename != null)
            {
                this.filename = filename;
                OpenFile();
            }
        }

        //New选项的事件处理函数
        private void miFileNew_Click(object sender, EventArgs e)
        {
            filename = "Untitled";
            SetFormTitle();  //需要放在filename变量被重置了以后
            TextBoxEdit.Clear();
        }

        //Open选项的事件处理函数
        private void miFileOpen_Click(object sender, EventArgs e)
        {
            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                filename = dlgOpenFile.FileName;
                SetFormTitle();
                OpenFile();
            }
        }

        //Save As选项的事件处理函数
        private void miFileSaveAs_Click(object sender, EventArgs e)
        {
            if (dlgSaveFile.ShowDialog() == DialogResult.OK)
            {
                filename = dlgSaveFile.FileName;
                SetFormTitle();
                saveFile();
            }
        }

        //Save选项的事件处理函数
        private void miFileSave_Click(object sender, EventArgs e)
        {
            if (filename == "Untitled")
            {
                miFileSaveAs_Click(sender, e);
            }
            else
            {
                saveFile();
            }
        }

        //Print选项的事件处理函数
        private void miFilePrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (TextBoxEdit.SelectedText != "")  //当有选中的文本时，开启打印“选定范围”的选项
                    dlgPrint.AllowSelection = true;
                else if (TextBoxEdit.SelectedText == "")
                    dlgPrint.AllowSelection = false;
                if (dlgPrint.ShowDialog() == DialogResult.OK)
                    printDocument.Print();  //触发Print函数触发PrintPage事件
            }
            catch (InvalidPrinterException ex)
            {
                MessageBox.Show(ex.Message, "Simple Editor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Page Setup选项的事件处理函数
        private void miFilePageSetup_Click(object sender, EventArgs e)
        {
            dlgPageSetup.ShowDialog();
        }

        //Print Preview选项的事件处理函数
        private void miFilePrintPreview_Click(object sender, EventArgs e)
        {
            dlgPrintPreview.ShowDialog();
            //dlgPreviewControl.Visible = true;
        }

        /*PrintDocument控件的PrintPage事件处理函数(简单实例，只执行一次，只能打印一页，且不需要BeginPrint事件)*/
        //private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        //{
        //    char[] param = {'\n'};
        //    string[] lines = TextBoxEdit.Text.Split(param);  //逐行分解文本框中的文本

        //    int i = 0;
        //    char[] trimParam = {'\r'};
        //    foreach (string s in lines)  //从每个字符串中删除字符\r（文本文件文本行用字符\n和\r分割的）
        //    { 
        //        lines[i++] = s.TrimEnd(trimParam);
        //    }

        //    int x = 20;
        //    int y = 20;
        //    foreach (string line in lines)
        //    {
        //        e.Graphics.DrawString(line, new Font("Arial", 10), Brushes.Black, x, y);  //把每行文本发送给打印机，宋体、字号10、黑色、输出结果位置（x，y）像素。
        //        y += 15;  //水平位置固定为20像素，垂直位置每行增加15像素
        //    }
        //}

        /*PrintDocument控件的PrintPage事件处理函数(重要，打印多个页面)*/
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            int x = e.MarginBounds.Left, y = e.MarginBounds.Top;  //int x = 20, y = 20;使用由PageSetupDialog设置的页边距

            while (linesPrinted < lines.Length)  //已打印的行数小于希望打印的行数，就继续打印
            {
                e.Graphics.DrawString(lines[linesPrinted++], new Font("Arial", 10), Brushes.Black, x, y);  //把每行文本发送给打印机，宋体、字号10、黑色、输出结果位置（x，y）像素。
                y += 15;  //水平位置固定为20像素，垂直位置每行增加15像素

                //if (y >= e.PageBounds.Height - 80)  //检查下一行打印的位置是否超出本页（使纸张下方有80像素的边距），超出就在下一页打印，用HasMorePages变量操作再执行一次PrintPage事件
                if (y >= e.MarginBounds.Bottom)  //注意：右侧边距无法控制
                {
                    e.HasMorePages = true;  //PrintController的一个方法PrintLoop()有一个用于每个要打印的页面的序列。如果HasMorePages是false，PrintLoop()就会停止
                    return;
                }
            }

            linesPrinted = 0;
            e.HasMorePages = false;
        }

        /*PrintDocument控件的BeginPrint事件处理函数（把文本分解到一个字符串数组中）*/
        private void printDocument_BeginPrint(object sender, PrintEventArgs e)
        {
            char[] param = {'\n'};

            if (dlgPrint.PrinterSettings.PrintRange == PrintRange.Selection)  //检查打印"选定范围"选项是否被选中
                lines = TextBoxEdit.SelectedText.Split(param);
            else
                lines = TextBoxEdit.Text.Split(param);  //逐行分解文本框中的文本

            int i = 0;
            char[] trimParam = {'\r'};
            foreach (string s in lines)  //从每个字符串中删除字符\r（文本文件文本行用字符\n和\r分割的）
            {
                lines[i++] = s.TrimEnd(trimParam);
            }
        }

        /*PrintDocument控件的EndPrint事件处理函数*/
        private void printDocument_EndPrint(object sender, PrintEventArgs e)
        {
            lines = null;  //释放在BeginPrint事件中，lines变量占用的内存
        }



        //Font选项的事件处理函数
        private void miEditorFont_Click(object sender, EventArgs e)
        {
            //dlgFont.AllowVectorFonts = false;  //是否可以在字体列表中选择矢量字体
            //dlgFont.FixedPitchOnly = true;  //将只在字体列表中显示固定大小的字体
            dlgFont.ShowApply = true;  //用于无需退出字体对话框，修改字体
            //dlgFont.ShowColor = true;  //开启颜色选择功能，修改字体颜色
            if (dlgFont.ShowDialog() == DialogResult.OK)
                TextBoxEdit.Font = dlgFont.Font;  //因为TextBox没有类似RichTextBox的SelectionFont属性，所以只能这样修改，无法使用更复杂的方式
        }

        //Apply（字体对话框应用键）事件处理程序
        private void dlgFont_Apply(object sender, EventArgs e)
        {
            TextBoxEdit.Font = dlgFont.Font;
        }

        //Color选项的事件处理函数
        private void miEditorColor_Click(object sender, EventArgs e)
        {
            //dlgColor.FullOpen = true;  //会自动打开颜色自定义选项
            if (dlgColor.ShowDialog() == DialogResult.OK)
                TextBoxEdit.ForeColor = dlgColor.Color;  //因为TextBox没有类似RichTextBox的SelectionColor属性，所以只能这样修改，无法使用更复杂的方式
        }

        //Browser选项的事件处理函数
        private void miEditorBrowser_Click(object sender, EventArgs e)
        {
            if (dlgFolderBrowser.ShowDialog() == DialogResult.OK)
                MessageBox.Show("The folder " + dlgFolderBrowser.SelectedPath + " was selected.");
        }
    }
}
