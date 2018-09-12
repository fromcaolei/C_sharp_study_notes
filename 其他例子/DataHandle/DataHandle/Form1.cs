using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace DataHandle
{
    public partial class Form1 : Form
    {
        List<double[]> d1=new List<double[]>();
        List<double[]> d2=new List<double[]>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";

            if (label4.Text.Length > 0)
            {
                label3.Text = getFilePath();
            }
            else
            {
                label4.Text = getFilePath();
            }
            
        }

        public string getFilePath()
        {
            string filepath = "";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = this.openFileDialog1.FileName;
            }
            return filepath;
        }
        public List<string> strPath(string name)
        {
            StreamReader sr;
            List<string> path = new List<string>();
            try
            {
                int i = 0;
                string sLine = "";
                sr = File.OpenText(name);
                while (sLine != null)
                {
                    sLine = sr.ReadLine();
                    if (sLine == null)
                        break;//如果遇到未使用的行则停止动作，退出循环,停止读入 。  
                    //注意以上情况不包括空行，空行的S.Line值为：""而不是null。  
                    path.Add(sLine);
                    i++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return path;
            }
            sr.Close();
            return path;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> data1, data2;
            if (label3.Text.Length > 0)
            {
                string path = label3.Text;
                path = path.Replace("/","\\");
                data1 = strPath(label3.Text);
                data1=DataCL(data1,d1);
                string temp = "";
                for (int i = 0; i < data1.Count; i++)
                {
                    temp += data1[i]+"\r\n";
                    
                }
                richTextBox1.Text = temp;

            }
            else
            {
                MessageBox.Show("请导入数据1！");
            }
            if (label4.Text.Length > 0)
            {
                string path = label4.Text;
                path = path.Replace("/", "\\");
                data2 = strPath(label4.Text);
                data2 = DataCL(data2, d2);
                string temp = "";
                for (int i = 0; i < data2.Count; i++)
                {
                    temp += data2[i] + "\r\n";
                }
                richTextBox2.Text = temp;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("请导入数据2！");
            }
            
        }
        public List<string> DataCL(List<string> list,List<double[]> dd)
        {
            List<string> ls = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {                
                string str=list[i];
                string[] rs = Regex.Split(str, " ", RegexOptions.IgnoreCase);
                if (rs.Length<2)
                {
                    continue;
                }
                double[] ss=new double[rs.Length-1];
                string d = rs[0]+"";
                double n2=Convert.ToDouble(rs[1]);
                ss[0] = Convert.ToDouble(rs[0]);
                for (int j = 2; j < rs.Length; j++)
                {
                    double t = (Convert.ToDouble(rs[j])) - n2;
                    ss[j-1]=t;
                    d += " " + t.ToString("#0.00000");
                }
                dd.Add(ss);
                ls.Add(d);
            }
            return ls;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog objSave = new System.Windows.Forms.SaveFileDialog();
            objSave.Filter = "(*.txt)|*.txt|" + "(*.*)|*.*";

            objSave.FileName = "对比结果" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            if (objSave.ShowDialog() == DialogResult.OK)
              {
                   StreamWriter FileWriter = new StreamWriter(objSave.FileName, true); //写文件
                   FileWriter.Write(checkData(d1,d2));//将字符串写入
                   FileWriter.Close(); //关闭StreamWriter对象
               }
        }
        public string checkData(List<double[]> dd1,List<double[]> dd2)
        {
            string sss="";
            for(int i=0;i<dd1.Count;i++)
            {
                double[] db1=dd1[i];
                double[] db2=dd2[i];
                string str="";
                 for (int j = 0; j < db1.Length; j++)
                {
                    if (j == 0)
                    {
                        str += db1[j].ToString("#0.00000") + " ";
                    }
                    else
                    {
                        str += (db1[j] / db2[j]).ToString("#0.00000") + " ";
                    }
                     
                 }
                sss+=str+"\r\n";
            }
            return sss;
        }
    }
}
