using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    class Conexion
    {
        public static OKSYSTEMEntities db;
        public Conexion() {
            db = OKSYSTEMEntities.Create("data source=VTUPEZ;initial catalog=OKSYSTEM;persist security info=True;user id=sa;password=amadeus2010;MultipleActiveResultSets=True;App=EntityFramework");
        }

    }
}
