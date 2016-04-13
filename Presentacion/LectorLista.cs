using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Entidad;
using Negocio;

namespace Presentacion
{
    public partial class LectorLista : Form
    {
        List<LECTOR> lista = new List<LECTOR>();

        public LectorLista()
        {
            InitializeComponent();

            grdDatos.AutoGenerateColumns = false;
            grdDatos.ColumnCount = 6;

            //Add Columns
            ///grdDatos.Columns[0].Name = "CustomerId";
            grdDatos.Columns[0].HeaderText = "T Documento";
            grdDatos.Columns[0].DataPropertyName = "Documento";

            ///grdDatos.Columns[1].HeaderText = "Contact Name";
            grdDatos.Columns[1].Name = "Serie";
            grdDatos.Columns[1].DataPropertyName = "Serie";

            ///grdDatos.Columns[2].Name = "Country";
            grdDatos.Columns[2].HeaderText = "Número";
            grdDatos.Columns[2].DataPropertyName = "Numero";

            grdDatos.Columns[3].HeaderText = "Fecha";
            grdDatos.Columns[3].DataPropertyName = "fecha";

            grdDatos.Columns[4].HeaderText = "Cód. Responsable";
            grdDatos.Columns[4].DataPropertyName = "idresponsable";

            grdDatos.Columns[5].HeaderText = "Nom. Responsable";
            grdDatos.Columns[5].DataPropertyName = "responsable";

            llenar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime desde, hasta;
            desde = dpDesde.Value;
            hasta = dpHasta.Value;

            desde = desde.ChangeTime(0, 0, 0, 0);
            hasta = hasta.ChangeTime(23, 59, 59, 997);

            lista = LECTORCn.GetLista(desde, hasta);
            llenar();
        }
        private void llenar()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("Documento"));
            dt.Columns.Add(new DataColumn("Serie"));
            dt.Columns.Add(new DataColumn("Numero"));
            dt.Columns.Add(new DataColumn("Fecha"));
            dt.Columns.Add(new DataColumn("idresponsable"));
            dt.Columns.Add(new DataColumn("responsable"));

            for (int i = 0; i < lista.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr[0] = lista[i].IDTDOCUMENTO;
                dr[1] = lista[i].SERIE;
                dr[2] = lista[i].NUMERO;
                dr[3] = lista[i].FECHA;
                dr[4] = lista[i].IDRESPONSABLE;
                if (lista[i].RESPONSABLE == null)
                {
                    dr[5] = "";
                }
                else {
                    dr[5] = lista[i].RESPONSABLE.NOMBRES;
                }
                dt.Rows.Add(dr);
            }

            
            grdDatos.DataSource = dt;
        }
    }

    
}
