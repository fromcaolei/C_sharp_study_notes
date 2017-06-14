using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace UpdatingData
{
    class Program
    {
        //最最最初级的数据库增删改查功能，基本没什么用
        static void Main(string[] args)
        {
            DataSet thisDataSet = new DataSet();

            //连接远程数据库字符串示例：SERVER=192.168.1.1;UID=sa;PWD=******;database=tableName，此处的Integrated Security=True表示使用Windows身份验证
            SqlConnection thisConnection = new SqlConnection(@"Server=(local);Integrated Security=True;Database=StudyADONET");
            thisConnection.Open();

            SqlDataAdapter thisAdapter = new SqlDataAdapter("select * from [StudyADONET].[dbo].[Events]", thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);  //该对象没有被使用，但依旧需要（不明）。更新、添加、查找、删除

            //更新行
            thisAdapter.Fill(thisDataSet, "Events");  //获取数据表
            Console.WriteLine("Title before change: {0}", thisDataSet.Tables["Events"].Rows[0]["Title"]);
            thisDataSet.Tables["Events"].Rows[0]["Title"] = "bb";  //修改数据表
            Console.WriteLine("Title after change: {0}\n", thisDataSet.Tables["Events"].Rows[0]["Title"]);

            thisAdapter.Update(thisDataSet, "Events");


            //查找行
            DataColumn[] keys = new DataColumn[1];
            keys[0] = thisDataSet.Tables["Events"].Columns["ID"];
            thisDataSet.Tables["Events"].PrimaryKey = keys;

            DataRow findRow = thisDataSet.Tables["Events"].Rows.Find("9");  //选择查找、删除哪行
            if (findRow != null)
                Console.WriteLine("This row Title: {0}\n", findRow["Title"]);
            else
                Console.WriteLine("Not find.\n");


            //删除行
            if (findRow != null)
                findRow.Delete();
            else
                Console.WriteLine("Delete failed.");
            thisAdapter.Update(thisDataSet, "Events");
            Console.WriteLine("# rows after change: {0}\n", thisDataSet.Tables["Events"].Rows.Count);

            thisDataSet.Tables["Events"].PrimaryKey = null;  //取消主键列，并允许空值，否则下一步添加无法执行
            thisDataSet.Tables["Events"].Columns["ID"].AllowDBNull = true;



            //添加行
            DataRow thisRow = thisDataSet.Tables["Events"].NewRow();
            thisRow["Title"] = "hello";
            thisRow["Data"] = DateTime.Now;
            thisRow["Location"] = "hello";
            thisDataSet.Tables["Events"].Rows.Add(thisRow);
            Console.WriteLine("# rows after change: {0}\n", thisDataSet.Tables["Events"].Rows.Count);

            thisAdapter.Update(thisDataSet, "Events");



            thisConnection.Close();
            Console.ReadKey();
        }
    }
}
