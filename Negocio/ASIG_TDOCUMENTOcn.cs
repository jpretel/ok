using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidad;
using Datos;

namespace Negocio
{
    public class ASIG_TDOCUMENTOcn
    {
        public static List<ASIG_TDOCUMENTO> GetAsig_TDocumento(String formulario)
        {
            ASIG_DOCUMENTODao dao = new ASIG_DOCUMENTODao();

            return dao.GetTDocumentosFormulario(formulario);
        }
    }
}
