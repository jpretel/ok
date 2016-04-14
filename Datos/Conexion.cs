using System;
using System.IO;

namespace Datos
{
    public class Conexion
    {
        public static OKSYSTEMEntities db;
        public string docpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public string archivo = @"\configini.txt";
        public string strConexion = "";
        public bool FExist { get; set; }

        public Conexion() {
            if (LeerArchivo()) {
                db = OKSYSTEMEntities.Create(strConexion);
            }            
        }

        public void EscribirArchivo(string origen,string usuario,string clave,string basedatos) {
            string[] lineas = { "Origen Datos:"+ origen, "Usuario:"+usuario, "Clave:"+clave,"Base Datos:"+basedatos};           
            System.IO.File.WriteAllLines(docpath + archivo, lineas);                        
            LeerArchivo();
        }

        public bool LeerArchivo(){                                   
            if (File.Exists(docpath + archivo))
            {
                string linea;
                string OrigenDatos = "";
                string basedatos = "";
                string usuario = "";
                string clave = "";
                StreamReader file = new StreamReader(docpath + archivo);
                while ((linea = file.ReadLine()) != null)
                {
                    string dato = linea.Substring(linea.IndexOf(":")+1);
                    if (linea.Contains("Origen Datos")) {
                        OrigenDatos = "data source=" + dato + ";";
                    }else {
                        if (linea.Contains("Base Datos")) {
                            basedatos = "initial catalog=" + dato + ";";
                        }else {
                            if (linea.Contains("Usuario"))
                            {
                                usuario = "user id=" + dato + ";";
                            }else{
                                if (linea.Contains("Clave"))
                                {
                                    clave = "password=" + dato + ";";
                                }
                            }
                        }
                    }
                }
                strConexion = OrigenDatos + basedatos +"persist security info=True;"+ usuario + clave + "MultipleActiveResultSets=True;App=EntityFramework";
                Console.WriteLine(strConexion);
                FExist = true;
            }
            else {                
                FExist = false;
            }
            return FExist;
        }

    }
}
