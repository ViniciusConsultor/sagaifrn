using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Entidades;
using SAGA.Banco;

namespace SAGA.Formularios.Administrador
{
    public partial class frmCadastrarTurma : Form
    {
        public frmCadastrarTurma()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
        }

        private void lblPaginaInicial_Click(object sender, EventArgs e)
        {
            Formularios.frmAdministrador.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeTurma.Text != "")
            {
                TurmasBanco turmaBanco = new TurmasBanco();
                turmaBanco.InserTurma(txtNomeTurma.Text);
                txtNomeTurma.Text = "";
            }
            else
            {
                MessageBox.Show("Digite o nome da turma");
            }
        }
    }
}
