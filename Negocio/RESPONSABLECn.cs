using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using Datos;

namespace Negocio
{
    public class ResponsableCn
    {
        public static List<RESPONSABLE> GetResponsables()
        {
            RESPONSABLEDao u = new RESPONSABLEDao();
            return u.GetResponsables();
        }
    }
}
