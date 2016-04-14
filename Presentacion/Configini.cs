using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Datos;
namespace Presentacion
{
    public partial class Configini : Form
    {        
        public Configini()
        {
            InitializeComponent();
        }

        private void Configini_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string origen = this.txtOrigen.Text;
            string usuario = this.txtUsuario.Text;
            string clave = this.txtClave.Text;
            string basedatos = "OKSYSTEM";
            Conexion cn = new Conexion();
         
            //Validaciones
            if (origen.Equals("")){
                MessageBox.Show("Por favor Ingrese el origen de Datos");
                this.txtOrigen.Focus();                
            }else{            
                if (usuario.Equals("")) {
                    MessageBox.Show("Por favor Ingrese el usuario");
                    this.txtUsuario.Focus();                    
                }else {                
                    if (clave.Equals("")){
                        MessageBox.Show("Por favor Ingrese la clave");
                        this.txtClave.Focus();
                    }else {
                        cn.EscribirArchivo(origen, usuario, clave, basedatos);
                        Login lg = new Login();
                        lg.Show();
                    }
                }
            }            
        }
    }
}
