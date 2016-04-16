using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using System.Data.Entity;

namespace Datos
{
    public class LECTORDao
    {
        Conexion cn = new Conexion();
        public List<LECTOR> GetLista(DateTime desde, DateTime hasta)
        {           
            List<LECTOR> u;
            u = Conexion.db.LECTOR.Where(c => c.FECHA >= desde && c.FECHA <= hasta).ToList();

            foreach (LECTOR l in u) { 
                Conexion.db.Entry(l).State = EntityState.Detached;
            }
            return u; 
        }

        public LECTOR GetLector(String id)
        {
            
                LECTOR u;
                u = Conexion.db.LECTOR.Where(c => c.ID == id).FirstOrDefault();
                
                if(u != null) { 
                    Conexion.db.Entry(u).State = EntityState.Detached;
                }
            return u;
            
        }

        public void InsertLECTOR(LECTOR lector)
        {
            Conexion.db.LECTOR.Add(lector);
            Conexion.db.SaveChanges();
            Conexion.db.Entry(lector).State = EntityState.Detached;
        }

        public void UpdateLECTOR(LECTOR lector)
        {
            Conexion.db.LECTOR.Attach(lector);
            Conexion.db.Entry(lector).State = EntityState.Modified;
            Conexion.db.SaveChanges();

            Conexion.db.Entry(lector).State = EntityState.Detached;
        }

        public int maxNumero(String serie)
        {
            var max = Conexion.db.LECTOR.Where(c=> c.SERIE.Equals(serie)).Max(c => c.NUMERO).GetValueOrDefault();

            return max;
        }
    }
}
