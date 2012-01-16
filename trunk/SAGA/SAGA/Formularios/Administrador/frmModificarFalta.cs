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
    public partial class frmModificarFalta : Form
    {
        private FaltasBanco faltasBanco = new FaltasBanco();
        public frmModificarFalta()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

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

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();

            int idAluno = usuarioBanco.GetAluno(txtAluno.Text);

            if (idAluno>0)
	        {
                
	        }
        }
    }
}
