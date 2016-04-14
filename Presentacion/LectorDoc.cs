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
    public partial class LectorDoc : Form
    {

        LECTOR cabecera;
        List<LECTOR_DETALLE> detalle;

        String estado = "VISTA";
        public LectorDoc(String id)
        {
            
            if (id == null)
            {
                estado = "NUEVO";
            } else
            {
                cabecera = LECTORCn.GetLector(id);
                if (cabecera == null)
                {
                    estado = "NUEVO";
                }
            }
            
            InitializeComponent();

            if (estado.Equals("NUEVO"))
            {
                llenarVista();
                edicion(true);
            } else
            {
                llenarVista();
                edicion(false);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LectorDoc_Load(object sender, EventArgs e)
        {

        }

        private void llenarVista()
        {
            txtDocumento.Text = cabecera.IDTDOCUMENTO;
            txtSerie.Text = cabecera.SERIE;
            txtNumero.Text = cabecera.NUMERO.ToString().PadLeft(4,'0');
            txtFecha.Value = cabecera.FECHA.Value;
        }

        private void llenarEntidades()
        {
            cabecera.IDTDOCUMENTO = txtDocumento.Text;
            cabecera.SERIE = txtSerie.Text;
            cabecera.NUMERO = int.Parse(txtNumero.Text);
            cabecera.FECHA = txtFecha.Value;
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            llenarEntidades();

            LECTORCn.UpdateLECTOR(cabecera);
            estado = "VISTA";
            edicion(false);
        }

        private void edicion(Boolean bandera)
        {
            txtDocumento.ReadOnly = !bandera;
            txtSerie.ReadOnly = !bandera;
            txtNumero.ReadOnly = !bandera;
            txtFecha.Enabled = bandera;

            btnNuevo.Enabled = !bandera;
            btnEditar.Enabled = !bandera;
            btnGrabar.Enabled = bandera;
            btnAnular.Enabled = !bandera;
            btnEliminar.Enabled = !bandera;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            edicion(true);
            estado = "EDITAR";
        }
    }
}
