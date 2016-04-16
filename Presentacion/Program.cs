using System;
using System.Windows.Forms;
using Entidad;
using System.Threading;
using Datos;

namespace Presentacion
{
    public static class Program
    {
        public static USUARIO usuario;
        public static Inicio inicio;
        public static Conexion cn = new Conexion();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (cn.FExist)
            {
                //new Login().Show();
                Application.Run(new Login());
            }
            else {
                MessageBox.Show("No existe archivo de Configuracion");
                Application.Run(new Configini());
            }

            
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
