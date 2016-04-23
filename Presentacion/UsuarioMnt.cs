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
using System.Globalization;

namespace Presentacion
{
    public partial class UsuarioMnt : Form
    {

        List<USUARIO> detalle;

        String estado = "VISTA";
        DataTable dt = new DataTable();

        public UsuarioMnt()
        {
            
            InitializeComponent();

            detalle = UsuarioCn.GetUsuarios();
            
            dt.Columns.Add(new DataColumn("IdUsuario"));
            dt.Columns.Add(new DataColumn("Nombres"));
            dt.Columns.Add(new DataColumn("Clave"));

            llenarDesdeBD();
            llenarVista();

            grdDet.DataSource = dt;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LectorDoc_Load(object sender, EventArgs e)
        {
            
        }

        private void grdDet_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 2) && e.Value != null)
            {
                grdDet.Rows[e.RowIndex].Tag = e.Value;
                e.Value = new String('\u25CF', e.Value.ToString().Length);
            }
        }

        private void grdDet_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (grdDet.CurrentCell.ColumnIndex == 2)//select target column
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
            else
            {
                TextBox textBox = e.Control as TextBox;
                if (textBox != null)
                {
                    textBox.UseSystemPasswordChar = false;
                }
            }
            var txtBox = e.Control as TextBox;
            ///txtBox.KeyDown -= new KeyEventHandler(underlyingTextBox_KeyDown);
            ///txtBox.KeyDown += new KeyEventHandler(underlyingTextBox_KeyDown);
        }

        private void llenarVista() {
            dt.Clear();
            
            foreach(USUARIO u in detalle)
            {
                dt.Rows.Add(u.IDUSUARIO, u.NOMBRES, u.CLAVE);
            }

            grdDet.DataSource = dt;
        }

        private void llenarEntidades()
        {
            detalle.Clear();

            foreach (DataRow r in dt.Rows)
            {
                String idusuario, nombres, clave;
                idusuario = r[0].ToString();
                nombres = r[1].ToString();
                clave = r[2].ToString();

                USUARIO u = new USUARIO();

                u.IDUSUARIO = idusuario;
                u.CLAVE = clave;
                u.NOMBRES = nombres;

                detalle.Add(u);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            foreach(USUARIO u in detalle)
            {
                UsuarioCn.BorrarUsuario(u.IDUSUARIO);
            }

            llenarEntidades();
            
            foreach(USUARIO u in detalle)
            {
                UsuarioCn.CrearUsuario(u);
            }

            llenarDesdeBD();
            llenarVista();

            estado = "VISTA";
        }

        private void llenarDesdeBD()
        {
            detalle = UsuarioCn.GetUsuarios();
        }
        
    }
}
