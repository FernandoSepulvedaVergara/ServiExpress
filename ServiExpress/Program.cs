﻿using Clases.ApiRest;
using System;
using System.Windows.Forms;

namespace ServiExpress
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            formLoginUsuario loginUsuario = new formLoginUsuario();
            loginUsuario.Show();
            Application.Run();
        }
    }
}
