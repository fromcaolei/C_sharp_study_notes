using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Web;

namespace DataReading
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接远程数据库字符串示例：SERVER=192.168.1.1;UID=sa;PWD=******;database=tableName，此处的Integrated Security=True表示使用Windows身份验证
            SqlConnection thisConnection = new SqlConnection(ConnectionString);  //此处使用了加密的app.config的连接字符串
            thisConnection.Open();

            #region 使用SqlDataReader读取数据
            //为这个连接创建命令
            SqlCommand thisCommand = thisConnection.CreateCommand();
            //指定此命令的SQL查询
            thisCommand.CommandText = "select id,Title from [StudyADONET].[dbo].[Events]";

            SqlDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read())
            {
                Console.WriteLine("\t{0}\t{1}", thisReader["ID"], thisReader["Title"]);
            }

            thisReader.Close();
            thisConnection.Close();

            //Console.Write("Program finished, press Enter/Return to continue:");
            //Console.ReadLine();
            Console.ReadKey();
            #endregion

            //使用DataSet读取数据
            thisConnection.Open();
            DataSet thisDataSet = new DataSet();

            //用来填充DataSet和设置数据库命令
            SqlDataAdapter thisAdapter = new SqlDataAdapter("select id,Title from [StudyADONET].[dbo].[Events]", thisConnection);
            thisAdapter.Fill(thisDataSet, "Events");  //Events为DataSet内部表的名称

            foreach (DataRow theRow in thisDataSet.Tables["Events"].Rows)  //也可使用Tables[0]获取第一个表
            {
                Console.WriteLine(theRow["ID"] + "\t" + theRow["Title"]);
            }

            thisConnection.Close();

            Console.ReadKey();
        }

        //获取连接字符串
        public static string ConnectionString
        {
            get
            {
                string _connectionString = ConfigurationManager.AppSettings["ConnectionString"];  //访问app.config文件中的元素内容
                string ConStringEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (ConStringEncrypt == "true")
                {
                    _connectionString = Decrypt(_connectionString, "helloworld");
                }
                return _connectionString;
            }
        }

        //解密连接字符串数据
        public static string Decrypt(string Text, string sKey)
        {
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            int len;
            len = Text.Length / 2;
            byte[] inputByteArray = new byte[len];
            int x, i;
            for (x = 0; x < len; x++)
            {
                i = Convert.ToInt32(Text.Substring(x * 2, 2), 16);
                inputByteArray[x] = (byte)i;
            }
            des.Key = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            des.IV = ASCIIEncoding.ASCII.GetBytes(System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sKey, "md5").Substring(0, 8));
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            return Encoding.Default.GetString(ms.ToArray());
        }
    }
}
