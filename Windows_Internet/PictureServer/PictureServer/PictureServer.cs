using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace PictureServer
{
    class PictureServer
    {
        static void Main(string[] args)
        {
            int i = 0;

            //为服务指定端口号，再监听传入的请求
            TcpListener listener = new System.Net.Sockets.TcpListener(IPAddress.Any, Properties.Settings.Default.Port);
            listener.Start();

            while (true)
            {
                //返回与客户机的连接TcpClient对象，并在其中读取网络访问的基础数据流
                TcpClient client = listener.AcceptTcpClient();  //程序运行在此处会等待客户端请求的数据，请求一次循环回来会继续等待，并有黑色终端可用来打印，不会再往下走！！！
                NetworkStream clientStream = client.GetStream();
                Console.WriteLine("请求次数为：{0}", i++);


                //一下四行代码得到该数据流的请求字符串
                byte[] buffer = new byte[256];
                int readBytes = 0;
                readBytes = clientStream.Read(buffer, 0, 256);
                string request = Encoding.ASCII.GetString(buffer).Substring(0, readBytes);  //把字节数组转换为字符串

                //根据请求字符串，为客户的数据流写入相应的内容：图片列表、图片文件
                if (request.StartsWith("LIST"))
                {
                    byte[] responseBuffer = PictureHelper.GetFileListBytes();
                    //发送图片列表到客户端
                    clientStream.Write(responseBuffer, 0, responseBuffer.Length);
                }
                else if (request.StartsWith("FILE"))
                {
                    //得到文件名
                    string[] requestMessage = request.Split(':');
                    string filename = requestMessage[1];
                    byte[] data = File.ReadAllBytes(Path.Combine(Properties.Settings.Default.PictureDirectory, filename));

                    //发送图片到客户端
                    clientStream.Write(data, 0, data.Length);
                }
                else
                {
                    //unknown request
                    Console.WriteLine("请求字符串开头未匹配");
                }
                clientStream.Close();  //发现程序执行在此处时，客户端才会获得clientStream.Write()写给他的数据
            }
        }
    }
}
