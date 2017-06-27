using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PictureServer
{
    class PictureHelper
    {
        //返回所有文件的列表
        public static string[] GetFileList()
        {
            string[] files = Directory.GetFiles(Properties.Settings.Default.PictureDirectory);
            for (int i = 0; i < files.Length; i++)
            {
                files[i] = Path.GetFileName(files[i]);
            }
            return files;
        }

        //返回图片文件的字节数
        public static byte[] GetPictureBytes(string filename)
        {
            FileInfo fileInfo = new FileInfo(filename);
            byte[] buffer = new byte[fileInfo.Length];
            using (FileStream stream = fileInfo.OpenRead())
            {
                stream.Read(buffer, 0, buffer.Length);
            }
            return buffer;
        }

        //在字节数组中返回文件列表
        public static byte[] GetFileListBytes()
        {
            string[] files = PictureHelper.GetFileList();
            StringBuilder responseMessage = new StringBuilder();
            foreach (string s in files)
            {
                responseMessage.Append(s);
                responseMessage.Append(":");  //使用冒号分割文件名，在客户端调用时会以冒号为分隔符获得文件名
            }
            byte[] responseBuffer = Encoding.ASCII.GetBytes(responseMessage.ToString());

            return responseBuffer;
        }
    }
}
