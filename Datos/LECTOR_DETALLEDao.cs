using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using System.Data.Entity;

namespace Datos
{
    public class LECTOR_DETALLEDao
    {
        Conexion cn = new Conexion();
        public List<LECTOR_DETALLE> GetLECTOR_DETALLE(string idlector)
        {           
            List<LECTOR_DETALLE> u;
            u = Conexion.db.LECTOR_DETALLE.Where(c => c.ID == idlector).ToList();

            foreach (LECTOR_DETALLE l in u) { 
                Conexion.db.Entry(l).State = EntityState.Detached;
            }
            return u; 
        }

        public void DeleteLector(String id)
        {
            Conexion.db.LECTOR_DETALLE.RemoveRange(Conexion.db.LECTOR_DETALLE.Where(x => x.ID == id));
        }

        public void InsertLECTOR_DETALLE(LECTOR_DETALLE lector)
        {
            Conexion.db.LECTOR_DETALLE.Add(lector);
            Conexion.db.SaveChanges();
            Conexion.db.Entry(lector).State = EntityState.Detached;
        }
        
    }
}
