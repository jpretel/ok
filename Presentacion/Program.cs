using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidad;

namespace Presentacion
{
    public static class Program
    {
        public static USUARIO usuario;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
