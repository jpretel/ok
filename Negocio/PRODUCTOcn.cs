using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using Datos;

namespace Negocio
{
    public class PRODUCTOcn
    {
        public static PRODUCTO GetPRODUCTO(String idproducto)
        {
            PRODUCTODao dao = new PRODUCTODao();

            return dao.GetPRODUCTO(idproducto);
        }

        public static List<PRODUCTO> GetPRODUCTOS()
        {
            PRODUCTODao u = new PRODUCTODao();
            return u.GetPRODUCTOS();
        }
    }
}
