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

namespace SAGA.Formularios.Alunos
{
    public partial class frmInicialAlunos : Form
    {
        public frmInicialAlunos()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
            Formularios.frmLogIn.Visible = true;
        }

        private void lblBoletim_Click(object sender, EventArgs e)
        {
            if (Formularios.frmBoletim == null)
            {
                frmBoletim frmBoletim = new frmBoletim();
                frmBoletim.Show();
                this.Close();
            }
            else
            {
                Formularios.frmBoletim.Show();
                this.Close();
            }
        }

        private void lblHorarios_Click(object sender, EventArgs e)
        {
            if (Formularios.frmHorarios == null)
            {
                frmHorarios frmHorarios = new frmHorarios();
                frmHorarios.Show();
                this.Close();
            }
            else
            {
                Formularios.frmHorarios.Show();
                this.Close();
            }
        }

        private void lblDuvidas_Click(object sender, EventArgs e)
        {
            if (Formularios.frmDuvAlunos == null)
            {
                frmDuvidasAlunos frmDuvAlunos = new frmDuvidasAlunos();
                frmDuvAlunos.Show();
                this.Close();
            }
            else
            {
                Formularios.frmDuvAlunos.Show();
                this.Close();
            }
        }

        private void lblAvisos_Click(object sender, EventArgs e)
        {
            if (Formularios.frmAvisosAlunos == null)
            {
                frmAvisosAlunos frmAvisosAlunos = new frmAvisosAlunos();
                frmAvisosAlunos.Show();
                this.Close();
            }
            else
            {
                Formularios.frmAvisosAlunos.Show();
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
    }
}
