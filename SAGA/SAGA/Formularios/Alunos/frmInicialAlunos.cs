using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Entidades;

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
            Formularios.frmBoletim.Show();
            this.Close();
        }

        private void lblHorarios_Click(object sender, EventArgs e)
        {
            Formularios.frmHorarios.Show();
            this.Close();
        }

        private void lblDuvidas_Click(object sender, EventArgs e)
        {
            Formularios.frmDuvAlunos.Show();
            this.Close();
        }

        private void lblAvisos_Click(object sender, EventArgs e)
        {
            Formularios.frmAvisosAlunos.Show();
            this.Close();
        }

        private void lblModificarSenha_Click(object sender, EventArgs e)
        {
            Formularios.frmAlterar.Show();
            this.Close();
        }
    }
}
