﻿using RuilenLeenSysteem.BUS;
using RuilenLeenSysteem.DAL;
using RuilenLeenSysteem.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuilenLeenSysteem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //DataAcces haha = new DataAcces();
            //haha.GetAllUsers();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());

        }
    }
}
