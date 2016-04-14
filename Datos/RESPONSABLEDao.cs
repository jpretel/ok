using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class RESPONSABLEDao
    {
        public List<RESPONSABLE> GetResponsables()
        {
            using (OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                return db.RESPONSABLE.ToList();
            }
        }
    }
}
