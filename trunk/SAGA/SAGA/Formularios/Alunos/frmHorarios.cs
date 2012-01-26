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
    public partial class frmHorarios : Form
    {
        public frmHorarios()
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
            frmInicialAlunos frmAluno = new frmInicialAlunos();
            frmAluno.Show();
            this.Close();
        }
    }
}
