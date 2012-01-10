using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Entidades;

namespace SAGA.Formularios.Administrador
{
    public partial class frmInicialAdministrador : Form
    {
        public frmInicialAdministrador()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
            Formularios.frmLogIn.Show();
        }

        private void lblAddUsuario_Click(object sender, EventArgs e)
        {
            Formularios.frmCadUsuario.Show();
            this.Close();
        }

        private void lblModificarUsuario_Click(object sender, EventArgs e)
        {
            Formularios.frmModUsuario.Show();
            this.Close();
        }

        private void lblModificarNota_Click(object sender, EventArgs e)
        {
            Formularios.frmModNota.Show();
            this.Close();
        }

        private void lblEditarFalta_Click(object sender, EventArgs e)
        {
            Formularios.frmModFalta.Show();
            this.Close();
        }

        private void lblAvisos_Click(object sender, EventArgs e)
        {
            Formularios.frmAvisos.Show();
            this.Close();
        }

        private void lblModificarSenha_Click(object sender, EventArgs e)
        {
            Formularios.frmAlterar.Show();
            this.Close();
        }

        private void lblCadastrarHorario_Click(object sender, EventArgs e)
        {
            Formularios.frmCadHorario.Show();
            this.Close();
        }

        private void lblModificarHorario_Click(object sender, EventArgs e)
        {
            Formularios.frmModHorario.Show();
            this.Close();
        }

        private void lblCadastrarTurma_Click(object sender, EventArgs e)
        {
            Formularios.frmCadTurma.Show();
            this.Close();
        }
    }
}
