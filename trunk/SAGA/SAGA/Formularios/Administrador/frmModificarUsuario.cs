﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SAGA.Entidades;
using System.Windows.Forms;
using SAGA.Formularios;

namespace SAGA.Formularios.Administrador
{
    public partial class frmModificarUsuario : Form
    {
        public frmModificarUsuario()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
            Formularios.frmLogIn.Visible = true;
        }

        private void lblPaginaInicial_Click(object sender, EventArgs e)
        {
            frmInicialAdministrador frmInicialAdmin = new frmInicialAdministrador();
            frmInicialAdmin.Show();
            this.Close();
        }
    }
}
