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
        public static Inicio inicio;
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
        public static string GenerateID()
        {
            lock (locker)
            {
                Thread.Sleep(100);
                return DateTime.Now.ToString("yyyyMMddHHmmssf");
            }
        }


        public static DateTime ChangeTime(this DateTime dateTime, int hours, int minutes, int seconds, int milliseconds)
        {
            return new DateTime(
                dateTime.Year,
                dateTime.Month,
                dateTime.Day,
                hours,
                minutes,
                seconds,
                milliseconds,
                dateTime.Kind);
        }
    }
}
