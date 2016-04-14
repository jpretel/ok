using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class RESPONSABLEDao
    {
        Conexion cn = new Conexion();
        public List<RESPONSABLE> GetResponsables()
        {
                return Conexion.db.RESPONSABLE.ToList();
        }
    }
}
