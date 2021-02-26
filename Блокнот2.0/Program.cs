﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Блокнот2._0
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            String[] arguments = Environment.GetCommandLineArgs();
            if (arguments.Length >= 2)
            {
                Application.Run(new Notepad(arguments[1]));
            }
            else
            {
                Application.Run(new Notepad());
            }
        }
    }
}
