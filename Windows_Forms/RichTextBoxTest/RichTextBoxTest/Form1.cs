using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RichTextBoxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBold_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.richTextBoxText.SelectionFont;  //获取当前选中文本使用的字体
            if (oldFont.Bold)  //检查被选中文本是否为黑体
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);  //使用oldFont作为原型，创建一个新字体，根据需要添加或删除黑体格式
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();  //把焦点返回给RichTextBoxText
        }

        private void buttonltalic_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.richTextBoxText.SelectionFont;
            if (oldFont.Italic)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();
        }

        private void buttonUNderline_Click(object sender, EventArgs e)
        {
            Font oldFont, newFont;
            oldFont = this.richTextBoxText.SelectionFont;
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            this.richTextBoxText.SelectionFont = newFont;
            this.richTextBoxText.Focus();
        }

        private void buttonCenter_Click(object sender, EventArgs e)
        {
            if (this.richTextBoxText.SelectionAlignment == HorizontalAlignment.Center)
                this.richTextBoxText.SelectionAlignment = HorizontalAlignment.Left;
            else
                this.richTextBoxText.SelectionAlignment = HorizontalAlignment.Center;
            this.richTextBoxText.Focus();
        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Length > 0)
                    ApplyTextSize(txt.Text);
                e.Handled = true;
                this.richTextBoxText.Focus();
            }
        }

        private void textBoxSize_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            ApplyTextSize(txt.Text);
            this.richTextBoxText.Focus();
        }

        private void ApplyTextSize(string textSize)
        {
            float newSize = Convert.ToSingle(textSize);
            FontFamily currentFontFamily;
            Font newFont;

            currentFontFamily = this.richTextBoxText.SelectionFont.FontFamily;  //获取字体所属的字体系列
            newFont = new Font(currentFontFamily, newSize);  //从该系列中创建一个带有新字号的新字体
            this.richTextBoxText.SelectionFont = newFont;  //把选中文本的字体设置为新字体
        }

        private void richTextBoxText_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);  //打开默认浏览器，进入链接
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.LoadFile("Test.rtf");
            }
            catch
            {
                MessageBox.Show("No file to load yet");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBoxText.SaveFile("Test.rtf");
            }
            catch
            {
                MessageBox.Show("Save error");
            }
        }
    }
}
