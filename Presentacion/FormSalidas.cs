using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidad;
using Datos;
using Negocio;

namespace Presentacion
{
    public partial class FormSalidas : Form
    {
        
        public FormSalidas()
        {
            InitializeComponent();
        }

        private void FormSalidas_Load(object sender, EventArgs e)
        {
            /*Retornar tipo de documento y series*/

            List<ASIG_TDOCUMENTO> lista = ASIG_TDOCUMENTOcn.GetAsig_TDocumento(this.Name);

            if (lista == null)
            {
                MessageBox.Show("No tiene documentos asociados");
            } else
            {
                
            }
        }
    }
}
