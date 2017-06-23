using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace FtpClient
{
    public partial class FtpClientForm : Form
    {
        private string serverDirectory;

        public FtpClientForm()
        {
            InitializeComponent();
        }

        //将数据流中的字符串按换行符转换为字符串数组，用来为ListBox初始化
        private void FillDirectoryList(Stream stream)
        {
            StreamReader reader = new StreamReader(stream);
            string content = reader.ReadToEnd();
            string[] files = content.Split('\n');
            listFiles.DataSource = files;
            reader.Close();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Cursor currentCursor = this.Cursor;  //先保存鼠标当前状态
            FtpWebResponse response = null;  //反馈
            Stream stream = null;
            try
            {
                this.Cursor = Cursors.WaitCursor;  //让鼠标变成沙漏状

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(textServer.Text);  //请求，FtpWebRequest对象由构造方法WebRequest.Create()创建
                request.Credentials = new NetworkCredential(textUsername.Text, textPassword.Text);  //输入ftp账号密码
                request.Method = WebRequestMethods.Ftp.ListDirectory;  //设置所要内容：获取文件列表
                response = (FtpWebResponse)request.GetResponse();  //返回服务器响应
                stream = response.GetResponseStream();  //获得反馈信息的数据流
                FillDirectoryList(stream);  //将数据流中的字符串按换行符转换为字符串数组，用来为ListBox初始化

                serverDirectory = null;
                buttonOpenDirectory.Enabled = false;
                buttonGetFile.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error FTP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (response != null)
                    response.Close();
                if (stream != null)
                    stream.Close();
                this.Cursor = currentCursor;  //完事后，将鼠标恢复为点击前状态
            }
        }

        private void buttonOpenDirectory_Click(object sender, EventArgs e)
        {
            FtpWebResponse response = null;
            Stream stream = null;
            try
            {
                string subDirectory = listFiles.SelectedValue.ToString().Trim();  //一下四行用于记忆需要进入的目录，并初始化uri对象
                serverDirectory += @"/" + subDirectory;
                Uri baseUri = new Uri(textServer.Text);
                Uri uri = new Uri(baseUri, serverDirectory);

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);  //一下六行和Open按钮的一样，不同的是使用uri对象初始化请求对象
                request.Credentials = new NetworkCredential(textUsername.Text, textPassword.Text);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                response = (FtpWebResponse)request.GetResponse();
                stream = response.GetResponseStream();
                FillDirectoryList(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error FTP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (response != null)
                    response.Close();
                if (stream != null)
                    stream.Close();
            }
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            FtpWebResponse response = null;
            Stream inStream = null;
            Stream outStream = null;
            try
            {
                string filename = listFiles.SelectedValue.ToString().Trim();  //一下四行用于记忆需要进入的目录，并初始化uri对象
                string fullFilename = serverDirectory + @"/" + filename;
                Uri baseUri = new Uri(textServer.Text);
                Uri uri = new Uri(baseUri, fullFilename);

                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);  //区别于Open功能，但又很多老套路
                request.Credentials = new NetworkCredential(textUsername.Text, textPassword.Text);
                request.Method = WebRequestMethods.Ftp.DownloadFile;  //设置所要内容：下载文件（相对于Open不同的地方）
                request.UseBinary = checkBoxBinary.Checked;  //根据复选框决定是否下载为二进制文件（相对于Open多出的地方）
                response = (FtpWebResponse)request.GetResponse();  //老规矩，返回服务器响应
                inStream = response.GetResponseStream();  //老规矩，获得反馈信息的数据流


                saveFileDialog1.FileName = filename;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    outStream = File.OpenWrite(saveFileDialog1.FileName);  //指定用于写入文件的位置
                    byte[] buffer = new byte[4096];
                    int size = 0;
                    while ((size = inStream.Read(buffer, 0, 4096)) > 0)  //将流写入文件
                    {
                        outStream.Write(buffer, 0, size);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error FTP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (inStream != null)
                    inStream.Close();
                if (outStream != null)
                    outStream.Close();
                if (response != null)
                    response.Close();
            }
        }

        private void listFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.buttonGetFile.Enabled = true;
            this.buttonOpenDirectory.Enabled = true;
        }
    }
}
