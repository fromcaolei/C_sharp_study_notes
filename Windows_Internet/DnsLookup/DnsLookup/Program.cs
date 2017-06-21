using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace DnsLookup
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: DnsLookup hostname/IP Address");
                Console.ReadLine();
                return;
            }

            IPHostEntry ipHostEntry = Dns.GetHostEntry(args[0]);  //获得主机列表

            Console.WriteLine("Host: {0}", ipHostEntry.HostName);

            if (ipHostEntry.Aliases.Length > 0)  //获取关联的别名列表
            {
                Console.WriteLine("\nAliases");
                foreach (string alias in ipHostEntry.Aliases)
                {
                    Console.WriteLine(alias);
                }
            }

            Console.WriteLine("\nAddress(es):");
            foreach (IPAddress address in ipHostEntry.AddressList)  //获取关联的IP地址列表
            {
                Console.WriteLine("Address: {0}", address.ToString());
            }

            Console.ReadKey();
        }
    }
}
