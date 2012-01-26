using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using SAGA.Entidades;
using System.Windows.Forms;

namespace SAGA.Formularios.Professores
{
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            frmLogIn frmLogIn = new frmLogIn();
            frmLogIn.Show();
            this.Close();
        }

        private void lblPaginaInicial_Click(object sender, EventArgs e)
        {
            frmInicialProfessores frmProfessores = new frmInicialProfessores();
            frmProfessores.Show();
            this.Close();
        }
    }
}
