﻿using System;
using System.Windows.Forms;

namespace TestSYS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //DbSetup.SetUpDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new frmWelcome());
            //Application.Run(new frmMenu()); 
            Application.Run(new frmQAdd());
        }
    }
}
