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

        List<ASIG_TDOCUMENTO> tDocumentos;
        List<TDOCUMENTO_SERIE> tSeries;

        //Catalogos
        List<PRODUCTO> productos;

        String estado = "VISTA";
        DataTable dt = new DataTable();

        public LectorDoc(String id)
        {
            
            if (id == null)
            {
                estado = "NUEVO";
            } else
            {
                llenarDesdeBD(id);
                if (cabecera == null)
                {
                    estado = "NUEVO";
                }
            }
            
            InitializeComponent();

            dt.Columns.Add(new DataColumn("Item"));
            dt.Columns.Add(new DataColumn("IdProducto"));
            dt.Columns.Add(new DataColumn("Descripcion"));
            dt.Columns.Add(new DataColumn("Idmedida"));
            dt.Columns.Add(new DataColumn("Cantidad"));
            
            grdDet.DataSource = dt;

            productos = PRODUCTOcn.GetPRODUCTOS();

            tDocumentos = ASIG_TDOCUMENTOcn.GetAsig_TDocumento("LECTOR");

            if (tDocumentos.Count == 0)
            {
                MessageBox.Show("No tiene definido documentos");
            } else { 

                if (estado.Equals("NUEVO"))
                {
                    nuevo();
                    llenarVista();
                    edicion(true);
                } else
                {
                    llenarVista();
                    edicion(false);
                }
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

            dt.Clear();

            
            foreach (LECTOR_DETALLE d in detalle) {
                String producto, idmedida;
                producto = "";
                idmedida = "";

                foreach (PRODUCTO p in productos) {
                    if (p.IDPRODUCTO.Trim().Equals(d.IDPRODUCTO.Trim()))
                    {
                        producto = p.DESCRIPCION;
                        idmedida = p.IDMEDIDA;
                    }
                }
                dt.Rows.Add(d.ITEM, d.IDPRODUCTO, producto, idmedida, d.CANTIDAD);
            }

            grdDet.DataSource = dt;
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

            if (estado.Equals("NUEVO"))
            {
                LECTORCn.InsertLECTOR(cabecera);
            } else
            {
                LECTORCn.UpdateLECTOR(cabecera);
            }
            

            String id = cabecera.ID;
            LECTOR_DETALLECn.DeleteLector(id);
            foreach (LECTOR_DETALLE dd in detalle)
            {
                LECTOR_DETALLECn.InsertLECTOR_DETALLE(dd);
            }

            llenarDesdeBD(id);
            llenarVista();

            estado = "VISTA";
            edicion(false);
        }

        private void llenarDesdeBD(String id)
        {
            cabecera = LECTORCn.GetLector(id);
            detalle = LECTOR_DETALLECn.GetLECTOR_DETALLE(id);
        }

        private void edicion(Boolean bandera)
        {
            if (estado.Equals("NUEVO")) { 
                txtDocumento.ReadOnly = true;
                txtSerie.ReadOnly = true;
                txtNumero.ReadOnly = false;
            } else
            {
                txtDocumento.ReadOnly = true;
                txtSerie.ReadOnly = true;
                txtNumero.ReadOnly = true;
            }

            txtFecha.Enabled = bandera;
            btnInsertar.Enabled = bandera;

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

        private void nuevo()
        {
            cabecera = new LECTOR();
            cabecera.ID = Program.GenerateID();
            cabecera.IDTDOCUMENTO = tDocumentos[0].IDTDOCUMENTO;

            setSeries(cabecera.IDTDOCUMENTO);

            cabecera.SERIE = tSeries[0].SERIE;

            cabecera.FECHA = DateTime.Now;

            detalle = new List<LECTOR_DETALLE>();
        }

        private void setSeries (String iddocumento)
        {
            tSeries = TDOCUMENTO_SERIECn.GetSeries(iddocumento);

            if (tSeries.Count == 0)
            {
                TDOCUMENTO_SERIE u = new TDOCUMENTO_SERIE();
                u.IDTDOCUMENTO = iddocumento;
                u.SERIE = "0001";
                TDOCUMENTO_SERIECn.CrearTDOCUMENTO_SERIE(u);
                tSeries.Add(u);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
            llenarVista();
            estado = "NUEVO";
            edicion(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Boolean bandera = true;

            while(bandera) { 
                using (var form = new LectorNuevaLinea())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        PRODUCTO pro = form.producto;
                        //string val = form.ReturnValue1;            //values preserved after close
                        //string dateString = form.ReturnValue2;
                        ////Do something here with these values

                        ////for example
                        //this.txtSomething.Text = val;
                        LECTOR_DETALLE det = null;

                        for (int i = 0; i < detalle.Count; i++)
                        {
                            if (detalle[i].IDPRODUCTO.Trim().Equals(pro.IDPRODUCTO.Trim()))
                            {
                                det = detalle[i];
                            }
                        }

                        if (det != null)
                        {
                            det.CANTIDAD += 1;
                        } else
                        {
                            det = new LECTOR_DETALLE();
                            det.ID = cabecera.ID;
                            det.ITEM = detalle.Count + 1;
                            det.IDPRODUCTO = pro.IDPRODUCTO;
                            det.CANTIDAD = 1;

                            detalle.Add(det);
                        }
                    } else
                    {
                        bandera = false;
                    }
                    llenarVista();
                }
            }
        }
    }
}
