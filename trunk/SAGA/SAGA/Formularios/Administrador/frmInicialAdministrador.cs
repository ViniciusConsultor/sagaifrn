using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Entidades;
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
            Formularios.frmLogIn.Visible = true;
        }

        private void lblAddUsuario_Click(object sender, EventArgs e)
        {
            if (Formularios.frmCadUsuario == null)
            {
                frmCadastrarUsuario frmCadUsuario = new frmCadastrarUsuario();
                frmCadUsuario.Show();
                this.Close();
            }
            else
            {
                Formularios.frmCadUsuario.Show();
                this.Close();
            }
        }

        private void lblModificarUsuario_Click(object sender, EventArgs e)
        {
            if (Formularios.frmModUsuario == null)
            {
                frmModificarUsuario frmModUsuario = new frmModificarUsuario();
                frmModUsuario.Show();
                this.Close();
            }
            else
            {
                Formularios.frmModUsuario.Show();
                this.Close();
            }
        }

        private void lblModificarNota_Click(object sender, EventArgs e)
        {
            if (Formularios.frmModNota == null)
            {
                frmModificarNota frmModNota = new frmModificarNota();
                frmModNota.Show();
                this.Close();
            }
            else
            {
                Formularios.frmModNota.Show();
                this.Close();
            }
        }

        private void lblEditarFalta_Click(object sender, EventArgs e)
        {
            if (Formularios.frmModFalta == null)
            {
                frmModificarFalta frmModFalta = new frmModificarFalta();
                frmModFalta.Show();
                this.Close();
            }
            else
            {
                Formularios.frmModFalta.Show();
                this.Close();
            }
        }

        private void lblAvisos_Click(object sender, EventArgs e)
        {
            if (Formularios.frmAvisos == null)
            {
                frmAvisos frmAvisos = new frmAvisos();
                frmAvisos.Show();
                this.Close();
            }
            else
            {
                Formularios.frmAvisos.Show();
                this.Close();
            }
        }

        private void lblModificarSenha_Click(object sender, EventArgs e)
        {
            if (Formularios.frmAlterar == null)
            {
                frmAlterarSenha frmAlterar = new frmAlterarSenha();
                frmAlterar.Show();
                this.Close();
            }
            else
            {
                Formularios.frmAlterar.Show();
                this.Close();
            }
        }

        private void lblCadastrarHorario_Click(object sender, EventArgs e)
        {
            if (Formularios.frmCadHorario == null)
            {
                frmCadastrarHorario frmCadHorario = new frmCadastrarHorario();
                frmCadHorario.Show();
                this.Close();
            }
            else
            {
                Formularios.frmCadHorario.Show();
                this.Close();
            }
        }

        private void lblModificarHorario_Click(object sender, EventArgs e)
        {
            if (Formularios.frmModHorario == null)
            {
                frmModificarHorario frmModHorario = new frmModificarHorario();
                frmModHorario.Show();
                this.Close();
            }
            else
            {
                Formularios.frmModHorario.Show();
                this.Close();
            }
        }

        private void lblCadastrarTurma_Click(object sender, EventArgs e)
        {
            if (Formularios.frmCadTurma == null)
            {
                frmCadastrarTurma frmCadTurma = new frmCadastrarTurma();
                frmCadTurma.Show();
                this.Close();
            }
            else
            {
                Formularios.frmCadTurma.Show();
                this.Close();
            }
        }
    }
}
