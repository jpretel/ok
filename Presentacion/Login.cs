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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<USUARIO> usuarios = new List<USUARIO>();
            
            usuarios = UsuarioCn.GetUsuarios();

            foreach (USUARIO u in usuarios)
            {
                MessageBox.Show(u.IDUSUARIO);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            USUARIO u = new USUARIO();

            u.IDUSUARIO = "hola";
            u.CLAVE = "hola";
            u.NOMBRES = "holaaa";
            u.ESTADO = 1;

            UsuarioCn.CrearUsuario(u);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var idusuario = txtIdUsuario.Text;

            USUARIO u = UsuarioCn.GetIDusuario(idusuario);
            MessageBox.Show(u.NOMBRES);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Inicio i = new Inicio();
            i.Visible = true;
            this.Visible = false;
        }

        private String encriptar(String cadena)
        {
            return cadena;
        }

        private String desencriptar(String cadena)
        {
            return cadena;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var idusuario = txtIdUsuario.Text;
            var clave = txtClave.Text;

            USUARIO u = UsuarioCn.GetIDusuario(idusuario);
            
            if (u != null)
            {
                if (clave == desencriptar(u.CLAVE))
                {
                    Program.usuario = u;

                    Inicio i = new Inicio();
                    i.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Usuario o clave incorrecta");
                }
            } else
            {
                MessageBox.Show("Usuario o clave incorrecta");
            }
        }
    }
}
