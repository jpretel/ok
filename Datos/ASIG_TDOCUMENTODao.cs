using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;

namespace Datos
{
    public class ASIG_DOCUMENTODao
    {
        Conexion cn = new Conexion();
        public List<ASIG_TDOCUMENTO> GetTDocumentosFormulario(String formulario)
        {            
                List<ASIG_TDOCUMENTO> u;
                u = Conexion.db.ASIG_TDOCUMENTO.Where(c => c.FORMULARIO == formulario).ToList();
                return u;            
        }
    }
}
