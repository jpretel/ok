﻿using System;
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

        public static LECTOR GetLector(String id)
        {
            LECTORDao u = new LECTORDao();
            return u.GetLector(id);
        }

        public static void InsertLECTOR(LECTOR lector)
        {
            LECTORDao u = new LECTORDao();
            u.InsertLECTOR(lector);
        }

        public static void DeleteLector(String id)
        {
            LECTORDao u = new LECTORDao();
            u.DeleteLector(id);
        }

        public static void UpdateLECTOR(LECTOR lector)
        {
            LECTORDao u = new LECTORDao();
            u.UpdateLECTOR(lector);
        }

        public static int maxNumero(String serie)
        {
            LECTORDao u = new LECTORDao();
            return u.maxNumero(serie);
        }

        public static void CrearDocumentoNisira(string id)
        {
            LECTORDao dao = new LECTORDao();
            dao.CrearDocumentoNisira(id);
        }

        public static void BorrarDocumentoNisira(string id)
        {
            LECTORDao dao = new LECTORDao();
            dao.BorrarDocumentoNisira(id);
        }
    }
}
