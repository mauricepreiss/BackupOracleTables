﻿using System;
using System.Windows.Forms;
using BackupOracleTables.Forms;

namespace BackupOracleTables
{
    internal static class Program
    {
    
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
