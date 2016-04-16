using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class LectorNuevaLinea : Form
    {

        public PRODUCTO producto { set; get; }
        public LectorNuevaLinea()
        {
            StartPosition = FormStartPosition.CenterParent;
            InitializeComponent();
            producto = null;
            
        }

        private void LectorNuevaLinea_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (producto == null)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else { 
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void txtCodigo_KeyPressed(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                String codigo;
                codigo = txtCodigo.Text.Trim();

                producto = PRODUCTOcn.GetPRODUCTO(codigo);

                if (producto == null)
                {
                    MessageBox.Show("El código ingresado no existe");
                    txtCodigo.Text = "";
                    txtCodigo.Focus();
                } else
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
