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

namespace SAGA.Formularios.Professores
{
    public partial class frmInicialProfessores : Form
    {
        public frmInicialProfessores()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
        }

        private void lblChamada_Click(object sender, EventArgs e)
        {
                frmChamada frmChamada = new frmChamada();
                frmChamada.Show();
                this.Close();

        }

        private void lblNotas_Click(object sender, EventArgs e)
        {
                frmNotas frmNotas = new frmNotas();
                frmNotas.Show();
                this.Close();
        }

        private void lblDuvidas_Click(object sender, EventArgs e)
        {
                frmDuvidasProfessores frmDuvidasProfessores = new frmDuvidasProfessores();
                frmDuvidasProfessores.Show();
                this.Close();
        }

        private void lblAvisos_Click(object sender, EventArgs e)
        {
                frmAvisos frmAvisos = new frmAvisos();
                frmAvisos.Show();
                this.Close();
        }

        private void lblJustificarFalta_Click(object sender, EventArgs e)
        {
                frmJustificarFalta frmJustificarFalta = new frmJustificarFalta();
                frmJustificarFalta.Show();
                this.Close();
        }

        private void lblModificarSenha_Click(object sender, EventArgs e)
        {
                frmAlterarSenha frmAlterar = new frmAlterarSenha();
                frmAlterar.Show();
                this.Close();
        }
    }
}
