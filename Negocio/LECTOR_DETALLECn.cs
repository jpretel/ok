using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using Datos;

namespace Negocio
{
    public class LECTOR_DETALLECn
    {
        public static List<LECTOR_DETALLE> GetLECTOR_DETALLE(string idlector)
        {
            LECTOR_DETALLEDao dao = new LECTOR_DETALLEDao();
            return dao.GetLECTOR_DETALLE(idlector);
        }

        public static void DeleteLector(String id)
        {
            LECTOR_DETALLEDao dao = new LECTOR_DETALLEDao();
            dao.DeleteLector(id);
        }

        public static void InsertLECTOR_DETALLE(LECTOR_DETALLE lector)
        {
            LECTOR_DETALLEDao dao = new LECTOR_DETALLEDao();
            dao.InsertLECTOR_DETALLE(lector);
        }

    }
}
