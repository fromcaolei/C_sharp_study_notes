using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LoopThroughXmlDocument
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLoop_Click(object sender, EventArgs e)
        {
            listBoxXmlNode.Items.Clear();
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\Administrator\Desktop\C_sharp_study_notes\Windows_XML\GhostStories_LoopThrough.xml");

            //为ListBox填充内容
            RecurseXmlDocument((XmlNode)document.DocumentElement, 0);
            //为TextBox填充内容
            textBoxResult.Text = FormatText(document.DocumentElement as XmlNode, "", "");
        }

        #region TextBox使用的子函数,用于打印XML内容
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

        #region ListBox使用的子函数,用于打印XML内容
        private void RecurseXmlDocument(XmlNode root, int indent)
        {
            if (root == null)
                return;
            if (root is XmlElement)  //检查对象类型
            {
                listBoxXmlNode.Items.Add(root.Name.PadLeft(root.Name.Length + indent));  //设置指定长度，添加空格使其达到指定长度
                
                if (root.HasChildNodes)
                    RecurseXmlDocument(root.FirstChild, indent + 2);

                if (root.NextSibling != null)
                    RecurseXmlDocument(root.NextSibling, indent);
            }
            else if (root is XmlText)
            {
                string text = ((XmlText)root).Value;
                listBoxXmlNode.Items.Add(text.PadLeft(text.Length + indent));
            }
            else if (root is XmlComment)
            {
                string text = root.Value;
                listBoxXmlNode.Items.Add(text.PadLeft(text.Length + indent));

                if (root.HasChildNodes)
                    RecurseXmlDocument(root.FirstChild, indent + 2);

                if (root.NextSibling != null)
                    RecurseXmlDocument(root.NextSibling, indent);
            }
        }
        #endregion

        private void buttonCreateNode_Click(object sender, EventArgs e)
        {
            XmlDataDocument document = new XmlDataDocument();
            document.Load(@"C:\Users\Administrator\Desktop\C_sharp_study_notes\Windows_XML\GhostStories_LoopThrough.xml");
            XmlElement root = document.DocumentElement;

            XmlElement newBook = document.CreateElement("book");
            XmlElement newTitle = document.CreateElement("title");
            XmlElement newAuthor = document.CreateElement("author");
            XmlElement newCode = document.CreateElement("code");

            XmlText title = document.CreateTextNode("Beginning Visual C# 3rd Edition");
            XmlText author = document.CreateTextNode("Karli Watson et al");
            XmlText code = document.CreateTextNode("1234567890");
            XmlComment comment = document.CreateComment("This book is the book you are reading");

            newBook.AppendChild(comment);
            newBook.AppendChild(newTitle);
            newBook.AppendChild(newAuthor);
            newBook.AppendChild(newCode);
            newTitle.AppendChild(title);
            newAuthor.AppendChild(author);
            newCode.AppendChild(code);

            root.InsertAfter(newBook, root.FirstChild);

            document.Save(@"C:\Users\Administrator\Desktop\C_sharp_study_notes\Windows_XML\GhostStories_LoopThrough.xml");

            buttonLoop_Click(sender, e);
        }

        private void buttonDeleteNode_Click(object sender, EventArgs e)
        {
            XmlDocument document = new XmlDocument();
            document.Load(@"C:\Users\Administrator\Desktop\C_sharp_study_notes\Windows_XML\GhostStories_LoopThrough.xml");

            XmlElement root = document.DocumentElement;

            if (root.HasChildNodes)
            {
                XmlNode book = root.LastChild;
                root.RemoveChild(book);
                document.Save(@"C:\Users\Administrator\Desktop\C_sharp_study_notes\Windows_XML\GhostStories_LoopThrough.xml");
            }

            buttonLoop_Click(sender, e);
        }
    }
}
