﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleEditorTest
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string filename = null;
            if (args.Length != 0)
                filename = args[0];

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimpleEditorForm(filename));
        }
    }
}
