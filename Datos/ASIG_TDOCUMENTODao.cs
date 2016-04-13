using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class ASIG_DOCUMENTODao
    {

        public List<ASIG_TDOCUMENTO> GetTDocumentosFormulario(String formulario)
        {
            using (OKSYSTEMEntities db = new OKSYSTEMEntities())
            {
                List<ASIG_TDOCUMENTO> u;
                u = db.ASIG_TDOCUMENTO.Where(c => c.FORMULARIO == formulario).ToList();

                return u;
            }
        }
    }
}
