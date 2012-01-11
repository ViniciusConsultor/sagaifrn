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

namespace SAGA.Formularios.Alunos
{
    public partial class frmAvisosAlunos : Form
    {
        public frmAvisosAlunos()
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
            Formularios.frmAluno.Show();
            this.Close();
        }

        private void frmAvisosAlunos_Load(object sender, EventArgs e)
        {
            AvisosBanco avisosBanco = new AvisosBanco();
            List<Avisos> avisos = new List<Avisos>();
            TurmasBanco turma = new TurmasBanco();

            avisos = avisosBanco.GetAvisos(turma.GetTurma(Usuarios.usuario));

            //não sei como escolher o tipo de item da lista "avisos"
        }
    }
}
