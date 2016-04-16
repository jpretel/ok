using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using System.Data.Entity;

namespace Datos
{
    public class PRODUCTODao
    {
        Conexion cn = new Conexion();
        
        public PRODUCTO GetPRODUCTO(String idproducto)
        {            
                PRODUCTO u;
                u = Conexion.db.PRODUCTO.Where(c => c.IDPRODUCTO == idproducto).FirstOrDefault();
                if (u != null) { 
                    Conexion.db.Entry(u).State = EntityState.Detached;
                }
            return u;
            
        }

        public List<PRODUCTO> GetPRODUCTOS()
        {
            return Conexion.db.PRODUCTO.ToList();
        }

    }
}
