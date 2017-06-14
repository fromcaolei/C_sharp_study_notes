using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataReading
{
    class Program
    {
        static void Main(string[] args)
        {
            //连接远程数据库字符串示例：SERVER=192.168.1.1;UID=sa;PWD=******;database=tableName，此处的Integrated Security=True表示使用Windows身份验证
            SqlConnection thisConnection = new SqlConnection(@"Server=(local);Integrated Security=True;Database=StudyADONET");
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

            #region 使用DataSet读取数据
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
            #endregion
        }
    }
}
