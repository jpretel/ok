﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Presentacion
{

    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();

            Login l = new Login();
            l.ShowDialog(this);
            
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            LectorLista form = new LectorLista();
            form.MdiParent = this;
            form.Show();
        }
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            if (Program.usuario != null)
            {
                this.stUsuario.Text = "USUARIO: " + Program.usuario.NOMBRES;
            }
            else
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (Program.usuario.IDUSUARIO.Equals("ADMINISTRADOR")) { 
                UsuarioMnt form = new UsuarioMnt();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
