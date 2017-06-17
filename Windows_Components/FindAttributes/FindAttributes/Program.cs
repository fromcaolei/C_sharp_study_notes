using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;  //调用程序集中属性方法的命名空间
using System.Diagnostics;  //Conditional属性标记需要的命名空间

namespace FindAttributes
{
    class Program
    {
        static void Main(string[] args)  //此项目已经在属性、调试页中添加了命令行选项
        {
            if (args.Length == 0)
                Usage();  //一个帮助输入的方法
            else if ((args.Length == 1) && (args[0] == "/?"))
                Usage();
            else
            {
                string assemblyName = null;

                foreach (string arg in args)  //重新构造命令行参数，把带有空格的命令行参数组合到一个字符串中
                {
                    if (assemblyName == null)
                        assemblyName = arg;
                    else
                        assemblyName = string.Format("{0}{1}", assemblyName, arg);
                }

                try
                {
                    Assembly a = Assembly.LoadFrom(assemblyName);  //加载程序集

                    object[] attributes = a.GetCustomAttributes(true);  //检索程序集中定义的所有属性

                    if (attributes.Length > 0)
                    {
                        int i = 0;
                        Console.WriteLine("Assembly attributes for '{0}'...", assemblyName);
                        foreach (object o in attributes)
                            Console.WriteLine("{0}、{1}", ++i, o.ToString());
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Assembly {0} contains no Attributes.", assemblyName);
                        Console.ReadKey();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception thrown loading assembly {0}...", assemblyName);
                    Console.WriteLine();
                    Console.WriteLine(ex.ToString());
                    Console.ReadKey();
                }
            }
        }

        [Conditional("DEBUG")]  //当属性、生成页的“定义DEBUG常量”未勾选时，就不会调用被标记的方法。
        [Obsolete("过时的属性")]  //编译时发出警告，[Obsolete("过时的属性"), true]编译时报错
        //[Serializable]  //标记的类、方法、属性允许被串行化，使用[NonSerialized]可以在不需要串行化的成员上添加
        static void Usage()
        {
            Console.WriteLine("Usage:");
            Console.WriteLine("  FindAttributes <Assembly>");
            Console.ReadKey();
        }
    }
}
