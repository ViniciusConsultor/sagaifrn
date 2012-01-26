using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Entidades;
using SAGA.Formularios.Administrador;
using SAGA.Formularios.Operacoes_Genericas;

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
            frmLogIn.logIn.Visible = true;
        }

        private void lblAddUsuario_Click(object sender, EventArgs e)
        {
                frmCadastrarUsuario frmCadUsuario = new frmCadastrarUsuario();
                frmCadUsuario.Show();
                this.Close();
        }

        private void lblModificarUsuario_Click(object sender, EventArgs e)
        {
                frmModificarUsuario frmModUsuario = new frmModificarUsuario();
                frmModUsuario.Show();
                this.Close();
        }

        private void lblModificarNota_Click(object sender, EventArgs e)
        {
                frmModificarNota frmModNota = new frmModificarNota();
                frmModNota.Show();
                this.Close();
        }

        private void lblEditarFalta_Click(object sender, EventArgs e)
        {
                frmModificarFalta frmModFalta = new frmModificarFalta();
                frmModFalta.Show();
                this.Close();
        }

        private void lblAvisos_Click(object sender, EventArgs e)
        {
                frmAvisos frmAvisos = new frmAvisos();
                frmAvisos.Show();
                this.Close();
            
        }

        private void lblModificarSenha_Click(object sender, EventArgs e)
        {
            frmAlterarSenha frmAlterar = new frmAlterarSenha();


            frmAlterar.Show();
            this.Close();
        }

        private void lblCadastrarHorario_Click(object sender, EventArgs e)
        {
                frmCadastrarHorario frmCadHorario = new frmCadastrarHorario();
                frmCadHorario.Show();
                this.Close();
        }

        private void lblModificarHorario_Click(object sender, EventArgs e)
        {
                frmModificarHorario frmModHorario = new frmModificarHorario();
                frmModHorario.Show();
                this.Close();
        }

        private void lblCadastrarTurma_Click(object sender, EventArgs e)
        {
                frmCadastrarTurma frmCadTurma = new frmCadastrarTurma();
                frmCadTurma.Show();
                this.Close();
        }
    }
}
