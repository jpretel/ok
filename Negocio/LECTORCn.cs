using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Entidad;
using Datos;

namespace Negocio
{
    public class LECTORCn
    {
        public static List<LECTOR> GetLista(DateTime desde, DateTime hasta)
        {
            LECTORDao u = new LECTORDao();
            return u.GetLista(desde, hasta);
        }
    }
}
