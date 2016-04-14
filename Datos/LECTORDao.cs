using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

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
    }
}
