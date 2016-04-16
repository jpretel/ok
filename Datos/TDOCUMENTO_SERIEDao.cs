using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class TDOCUMENTO_SERIEDao
    {
        Conexion cn = new Conexion();
        public List<TDOCUMENTO_SERIE> GetSeries(String iddocumento)
        {
            return Conexion.db.TDOCUMENTO_SERIE.Where(c => c.IDTDOCUMENTO.Equals(iddocumento)).ToList();
        }

        public void CrearTDOCUMENTO_SERIE(TDOCUMENTO_SERIE entidad)
        {
            Conexion.db.TDOCUMENTO_SERIE.Add(entidad);
            Conexion.db.SaveChanges();
        }
    }
}
