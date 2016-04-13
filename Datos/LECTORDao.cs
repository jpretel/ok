﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    class LECTORDao
    {
        public List<LECTOR> GetIDusuario(DateTime desde, DateTime hasta)
        {
            using (OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                List<LECTOR> u;
                u = db.LECTOR.Where(c => c.FECHA >= desde && c.FECHA <= hasta).ToList();

                return u;
            }
        }
    }
}