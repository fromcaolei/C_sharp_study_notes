using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace PictureClient
{
    public partial class PictureClientForm : Form
    {
        public PictureClientForm()
        {
            InitializeComponent();
        }

        private void buttonListPictures_Click(object sender, EventArgs e)
        {
            const int bufferSize = 256;

            TcpClient client = new TcpClient();  //和服务端不同，不使用listener.AcceptTcpClient();构造它

            IPHostEntry host = Dns.GetHostEntry(Properties.Settings.Default.Server);
            client.Connect(host.AddressList[1], Properties.Settings.Default.ServerPort);  //当目标服务器打开了IPV6，需要使用host.AddressList[2]

            //在与服务机的连接TcpClient对象中读取网络访问的基础数据流
            NetworkStream clientStream = client.GetStream();

            //设置请求字符串为LIST，发送给服务机
            string request = "LIST";
            byte[] requestBuffer = Encoding.ASCII.GetBytes(request);  //把字符串转换为字节数组
            clientStream.Write(requestBuffer, 0, requestBuffer.Length);

            //构造一个memStream对象用来保存服务器返回的数据
            byte[] responseBuffer = new byte[bufferSize];
            MemoryStream memStream = new MemoryStream();
            int bytesRead = 0;
            do
            {
                bytesRead = clientStream.Read(responseBuffer, 0, bufferSize);  //从服务器返回的数据用Read()方法读取
                memStream.Write(responseBuffer, 0, bytesRead);  //读取的数据追加到MemoryStream中，该对象可以自动调整大小
            } while (bytesRead > 0);
            clientStream.Close();
            client.Close();

            byte[] buffer = memStream.GetBuffer();
            string response = Encoding.ASCII.GetString(buffer);
            string[] fileNames = response.Split(':');
            this.listFiles.DataSource = fileNames;  //将所得到的字符串填充到ListBox控件中
        }

        private void buttonGetPicture_Click(object sender, EventArgs e)
        {
            const int bufferSize = 256;

            TcpClient client = new TcpClient();  //和服务端不同，不使用listener.AcceptTcpClient();构造它

            IPHostEntry host = Dns.GetHostEntry(Properties.Settings.Default.Server);
            client.Connect(host.AddressList[1], Properties.Settings.Default.ServerPort);  //当目标服务器打开了IPV6，需要使用host.AddressList[2]

            //在与服务机的连接TcpClient对象中读取网络访问的基础数据流
            NetworkStream clientStream = client.GetStream();

            //设置请求字符串为FILE和所选文件名，发送给服务机
            string request = "FILE:" + this.listFiles.SelectedItem.ToString();
            byte[] requestBuffer = Encoding.ASCII.GetBytes(request);  //把字符串转换为字节数组
            clientStream.Write(requestBuffer, 0, requestBuffer.Length);

            //构造一个memStream对象用来保存服务器返回的数据
            byte[] responseBuffer = new byte[bufferSize];
            MemoryStream memStream = new MemoryStream();
            int bytesRead = 0;
            do
            {
                bytesRead = clientStream.Read(responseBuffer, 0, bufferSize);  //从服务器返回的数据用Read()方法读取
                memStream.Write(responseBuffer, 0, bytesRead);  //读取的数据追加到MemoryStream中，该对象可以自动调整大小
            } while (bytesRead > 0);
            clientStream.Close();
            client.Close();

            Image picture = Image.FromStream(memStream);  //将memStream对象以图片形式显示出来
            this.pictureBox.Image = picture;
        }
    }
}
