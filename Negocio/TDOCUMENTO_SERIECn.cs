using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidad;
using Datos;

namespace Negocio
{
    public class TDOCUMENTO_SERIECn
    {
        
        public static List<TDOCUMENTO_SERIE> GetSeries(String iddocumento)
        {
            TDOCUMENTO_SERIEDao u = new TDOCUMENTO_SERIEDao();
            return u.GetSeries(iddocumento);
        }

        public static void CrearTDOCUMENTO_SERIE (TDOCUMENTO_SERIE entidad)
        {
            TDOCUMENTO_SERIEDao dao = new TDOCUMENTO_SERIEDao();
            dao.CrearTDOCUMENTO_SERIE(entidad);
        }
    }
}
