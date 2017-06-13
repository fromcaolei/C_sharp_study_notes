using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XPathQuery
{
    public partial class Form1 : Form
    {
        private XmlDocument mDocument;

        Boolean textboxHasText = false;  //判断输入框是否有文本

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mDocument = new XmlDocument();
            mDocument.Load(@"C:\Users\Administrator\Desktop\C_sharp_study_notes\Windows_XML\Elements.xml");

            Update(mDocument.DocumentElement.SelectNodes("."));  //选择当前节点

            textBoxQuery_Leave(sender, e);
        }

        //将返回的XmlNodeList结果打印到文本框中
        private void Update(XmlNodeList nodes)
        {
            if (nodes == null || nodes.Count == 0)
            {
                textBoxResult.Text = "The query yielded no results";
                return;
            }
            string text = "";
            foreach (XmlNode node in nodes)
            {
                text = FormatText(node, text, "") + "\r\n";
            }
            textBoxResult.Text = text;
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            try
            {
                XmlNodeList node = mDocument.DocumentElement.SelectNodes(textBoxQuery.Text);
                Update(node);
            }
            catch (Exception err)
            {
                textBoxResult.Text = err.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxQuery.Text = "element[name='Hydrogen']";
            textboxHasText = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update(mDocument.DocumentElement.SelectNodes("."));  //选择当前节点
        }

        #region 例子LoopThroughXmlDocument中的用于为TextBox填充内容使用的两个子函数
        private string FormatText(XmlNode node, string text, string indent)
        {
            if (node is XmlText)
            {
                text += node.Value;
                return text;
            }

            if (string.IsNullOrEmpty(indent))
                indent = "";
            else
            {
                text += "\r\n" + indent;
            }

            if (node is XmlComment)
            {
                text += node.OuterXml;
                return text;
            }

            text += "<" + node.Name;
            if (node.Attributes.Count > 0)
            {
                AddAttributes(node, ref text);
            }

            if (node.HasChildNodes)
            {
                text += ">";
                foreach (XmlNode child in node.ChildNodes)
                {
                    text = FormatText(child, text, indent + " ");
                }
                if (node.ChildNodes.Count == 1 && (node.FirstChild is XmlText || node.FirstChild is XmlComment))
                    text += "</" + node.Name + ">";
                else
                    text += "\r\n" + indent + "</" + node.Name + ">";
            }
            else
                text += " />";
            return text;
        }

        private void AddAttributes(XmlNode node, ref string text)
        {
            foreach (XmlAttribute xa in node.Attributes)
            {
                text += " " + xa.Name + "='" + xa.Value + "'";
            }
        }
        #endregion

        #region 用于在文本框中显示提示文字使用
        private void textBoxQuery_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                textBoxQuery.Text = "";

            textBoxQuery.ForeColor = Color.Black;  
        }

        private void textBoxQuery_Leave(object sender, EventArgs e)
        {
            if (textBoxQuery.Text == "")
            {
                textBoxQuery.Text = "请输入XPath查询指令...";
                textBoxQuery.ForeColor = Color.Black;
                textboxHasText = false;
            }
            else
                textboxHasText = true;  
        }
        #endregion
    }
}
