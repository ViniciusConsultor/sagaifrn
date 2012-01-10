using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Entidades;

namespace SAGA.Formularios.Professores
{
    public partial class frmJustificarFalta : Form
    {
        public frmJustificarFalta()
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
            Formularios.frmProfessor.Show();
            this.Close();
        }
    }
}
