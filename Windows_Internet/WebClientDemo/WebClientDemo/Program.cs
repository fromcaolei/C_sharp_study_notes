using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace WebClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            WebClient client = new WebClient();
            client.BaseAddress = "http://www.microsoft.com";
            string data = client.DownloadString("Office");  //请求http://www.microsoft.com/Office页面，返回的数据在string中
            Console.WriteLine(data);
            Console.ReadKey();
        }
    }
}
