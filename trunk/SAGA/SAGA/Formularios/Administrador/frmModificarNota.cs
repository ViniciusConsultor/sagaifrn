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
    public partial class frmModificarNota : Form
    {
        public frmModificarNota()
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

        private UsuarioBanco usuarioBanco = new UsuarioBanco();
        NotasBanco notaBanco = new NotasBanco();

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            int idAluno = usuarioBanco.GetIdUsuario(txtUsuario.Text);

            TurmasBanco turmaBanco = new TurmasBanco();
            int idTurma = turmaBanco.GetTurmaAluno(idAluno);
            Disciplinas_TurmasBanco disciplina_turmaBanco = new Disciplinas_TurmasBanco();

            IEnumerable<string> disciplinas = disciplina_turmaBanco.GetDisciplinasTurma(idTurma);

            foreach (var disciplina in disciplinas)
            {
                cbbDisciplina.Items.Add(disciplina);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            IEnumerable<Notas> notas = notaBanco.GetNotas(usuarioBanco.GetIdUsuario(txtUsuario.Text));

            foreach (var nota in notas)
            {
                switch (nota.BimestreNota)
                {
                    case 1:
                    {
                        txt1Bimestre.Text = Convert.ToString(nota.ValorNota);
                        break;
                    }
                    case 2:
                    {
                        txt1Bimestre.Text = Convert.ToString(nota.ValorNota);
                        break;
                    }
                    case 3:
                    {
                        txt1Bimestre.Text = Convert.ToString(nota.ValorNota);
                        break;
                    }
                    case 4:
                    {
                        txt1Bimestre.Text = Convert.ToString(nota.ValorNota);
                        break;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var valoresNotas = new double[4];
            valoresNotas[0] = Convert.ToDouble(txt1Bimestre.Text);
            valoresNotas[1] = Convert.ToDouble(txt2Bimestre.Text);
            valoresNotas[2] = Convert.ToDouble(txt3Bimestre.Text);
            valoresNotas[3] = Convert.ToDouble(txt4Bimestre.Text);

            int idAluno = usuarioBanco.GetIdUsuario(txtUsuario.Text);

            notaBanco.ModificarNotas(idAluno, valoresNotas);
        }
    }
}
