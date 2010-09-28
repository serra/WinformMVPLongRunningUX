﻿using System;
using System.Windows.Forms;
using Serra.Micros.MVP.Views;

namespace Serra.Micros.MVP
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ItemListForm());
        }
    }
}