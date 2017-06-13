using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileStreamObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 该对象用于表示磁盘或网络位置上的文件
            //FileInfo aFile = new FileInfo(@"C:/Log.txt");
            //aFile.Close();
            #endregion

            #region 创建一个文件流对象，以字节形式读取后转换为字符数组，打印
            //byte[] byData = new byte[100];  //0~255
            //char[] charData = new char[100];  //0~65535
            //FileStream bFile = new FileStream(@"C:/Log.txt", FileMode.Open);  //默认开启读写权限
            //bFile.Seek(135, SeekOrigin.Begin);  //修改初始文件内指针位置
            //bFile.Read(byData, 0, 200);  //  //以上三个函数最好写在try里，从当前指针位置处开始读取200字节
            //Decoder d = Encoding.UTF8.GetDecoder();
            //d.GetChars(byData, 0, byData.Length, charData, 0);  //转换为char[]形式
            //Console.WriteLine(charData);
            //bFile.Close();
            #endregion

            #region 创建一个文件流对象，将字符数组以字节形式写入文件
            //byte[] byData;
            //char[] charData;
            //FileStream bFile = new FileStream("Temp.txt", FileMode.Create);
            //charData = "hello world".ToCharArray();
            //byData = new byte[charData.Length];
            //Encoder e = Encoding.UTF8.GetEncoder();
            //e.GetBytes(charData, 0, charData.Length, byData, 0, true);
            //bFile.Seek(0, SeekOrigin.Begin);
            //bFile.Write(byData, 0, byData.Length);  //以上最好写在try里
            //bFile.Close();
            #endregion

            #region StreamWriter对象的两个构造函数
            //FileStream bFile = new FileStream("Temp.txt", FileMode.Create);
            //StreamWriter ws = new StreamWriter(bFile);  //一般用这个
            //StreamWriter sw = new StreamWriter("Log.txt", true);
            //sw.Write("{0},{1},{2}", 100, "A nice product", 10.50);  //用逗号分隔的文件写法
            //ws.Close();
            //sw.Close();
            #endregion

            #region StreamReader对象,读取用逗号分隔符分隔的文件，打印
            //List<string> columns;
            //List<Dictionary<string, string>> myData = GetData(out columns);

            //foreach (string column in columns)
            //{
            //    Console.Write("{0, -20}", column);  //先打印出表头
            //}
            //Console.WriteLine();

            //foreach (Dictionary<string, string> row in myData)
            //{
            //    foreach (string column in columns)
            //    {
            //        Console.Write("{0, -20}", row[column]);  //根据键值对的键，即表头，逐行打印出表中内容
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region StreamReader对象，读写压缩文件
            //try
            //{
            //    string filename = "compressedFile.txt";
            //    Console.WriteLine("Enter a string to compress (will be repeated 1000 times):");
            //    string sourceString = Console.ReadLine();
            //    StringBuilder sourceStringMultiplier = new StringBuilder(sourceString.Length * 100);
            //    for (int i = 0; i < 100; i++)
            //    {
            //        sourceStringMultiplier.Append(sourceString);
            //    }
            //    sourceString = sourceStringMultiplier.ToString();
            //    Console.WriteLine("Source data is {0} bytes long.", sourceString.Length);

            //    SaveCompressedFile(filename, sourceString);
            //    Console.WriteLine("\nData saved to {0}.", filename);

            //    FileInfo compressedFileData = new FileInfo(filename);
            //    Console.WriteLine("Compressed file is {0} byte long.", compressedFileData.Length);

            //    string recoveredString = LoadCompressedFile(filename);
            //    recoveredString = recoveredString.Substring(0, recoveredString.Length / 100);
            //    Console.WriteLine("\nRecovered data: {0}", recoveredString);

            //    Console.ReadKey();
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine("An IO exception has been thrown!");
            //    Console.WriteLine(ex.ToString());
            //    Console.ReadKey();
            //}
            #endregion

            #region IFormatter类，串行化、并行化对象
            //try
            //{
            //    List<IFormatterExample> iformatterExample = new List<IFormatterExample>();  //创建一个对象列表
            //    iformatterExample.Add(new IFormatterExample(1, "Spiky Pung", 1000.0, "Good stuff."));
            //    iformatterExample.Add(new IFormatterExample(2, "Gloop Galloop Soup", 25.0, "Tasty."));
            //    iformatterExample.Add(new IFormatterExample(4, "Hat Sauce", 12.0, "One for the kids."));

            //    Console.WriteLine("IFormatterExample to save:");
            //    foreach (IFormatterExample iformatter in iformatterExample)
            //    {
            //        Console.WriteLine(iformatter);
            //    }
            //    Console.WriteLine();

            //    IFormatter serializer = new BinaryFormatter();

            //    FileStream saveFile = new FileStream("../../../IFormatterExample.bin", FileMode.Create, FileAccess.Write);
            //    serializer.Serialize(saveFile, iformatterExample);  //将对象列表串行化写入IFormatterExample.bin文件
            //    saveFile.Close();

            //    FileStream loadFile = new FileStream("../../../IFormatterExample.bin", FileMode.Open, FileAccess.Read);
            //    List<IFormatterExample> savedIFormatterExample = serializer.Deserialize(loadFile) as List<IFormatterExample>;  //将对象并行化读取到savedIFormatterExample对象列表里
            //    loadFile.Close();

            //    Console.WriteLine("IFormatterExample loaded:");
            //    foreach (IFormatterExample iformatter in savedIFormatterExample)
            //    {
            //        Console.WriteLine(iformatter);
            //    }
            //}
            //catch (SerializationException e)
            //{
            //    Console.WriteLine("串行化操作抛出异常！");
            //    Console.WriteLine(e.Message);
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("文件流操作抛出异常！");
            //    Console.WriteLine(e.ToString());
            //}

            //Console.ReadKey();
            #endregion
        }

        #region StreamReader对象,读取用逗号分隔符分隔的文件，打印
        private static List<Dictionary<string, string>> GetData(out List<string> colums)
        {
            string strLine;
            string[] strArray;
            char[] charArray = new char[]{','};
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            colums = new List<string>();

            try
            {
                FileStream aFile = new FileStream("../../../SomeData.txt", FileMode.Open);
                StreamReader sr = new StreamReader(aFile);

                strLine = sr.ReadLine();
                strArray = strLine.Split(charArray);  //将第一行表头放入字符串数组

                for (int x = 0; x <= strArray.GetUpperBound(0); x++)
                {
                    colums.Add(strArray[x]);  //将表头该字符串数组放入字符串列表
                }

                strLine = sr.ReadLine();  //读取下一行表中内容
                while (strLine != null)
                {
                    strArray = strLine.Split(charArray);
                    Dictionary<string, string> dataRow = new Dictionary<string, string>();

                    for (int x = 0; x <= strArray.GetUpperBound(0); x++)
                    {
                        dataRow.Add(colums[x], strArray[x]);  //将表中内容与表头做成键值对
                    }

                    data.Add(dataRow);  //将每一行的键值对添加到总键值对列表中

                    strLine = sr.ReadLine();  //再读取下一行，此行代码必须写在srtLine变量使用完成之后
                }

                sr.Close();
                return data;
            }
            catch (IOException ex)
            {
                Console.WriteLine("An IO exception has been thrown!");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
                return data;
            }
        }
        #endregion

        #region StreamReader对象，读写压缩文件
        static void SaveCompressedFile(string filename, string data)
        {
            FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Compress);
            StreamWriter writer = new StreamWriter(compressionStream);
            writer.Write(data);
            writer.Close();
        }

        static string LoadCompressedFile(string filename)
        {
            FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
            GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Decompress);
            StreamReader reader = new StreamReader(compressionStream);
            string data = reader.ReadToEnd();
            reader.Close();
            return data;
        }
        #endregion
    }
}
