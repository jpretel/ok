using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidad;
using System.Threading;

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

        static object locker = new object();
        static string GenerateID()
        {
            lock (locker)
            {
                Thread.Sleep(100);
                return DateTime.Now.ToString("yyyyMMddHHmmssf");
            }
        }
    }
}
