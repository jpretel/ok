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
                return u;            
        }

        public LECTOR GetLector(String id)
        {
            using (OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                LECTOR u;
                u = db.LECTOR.Where(c => c.ID == id).FirstOrDefault();

                return u;
            }
        }

        public void InsertLECTOR(LECTOR lector)
        {
            using (OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                db.LECTOR.Add(lector);

                db.SaveChanges();
            }
        }

        public void UpdateLECTOR(LECTOR lector)
        {
            using (OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                db.LECTOR.Attach(lector);
                db.Entry(lector).State = EntityState.Modified;
                db.SaveChanges();
            }

            
        }
    }
}
