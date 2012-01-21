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
    public partial class frmDuvidasAlunos : Form
    {
        public frmDuvidasAlunos()
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

        private DuvidasBanco duvidaBanco = new DuvidasBanco();

        private void frmDuvidasAlunos_Load(object sender, EventArgs e)
        {
            IEnumerable<Duvidas> duvidas = duvidaBanco.GetDuvidas(Usuarios.usuario);

            foreach (var _duvida in duvidas)
            {
                lsvDuvida.Items.Add(_duvida.Pergunta);
            }

            TurmasBanco turmaBanco = new TurmasBanco();
            int idTurma = turmaBanco.GetTurmaAluno(Usuarios.usuario);

            Professores_TurmasBanco professores_turmaBanco = new Professores_TurmasBanco();
            IEnumerable<Professores_Turmas> professores = professores_turmaBanco.GetProfessoresTurma(idTurma);

            foreach (var professor in professores)
            {
                cbbProfessores.Items.Add(professor.Professor.Usuario.NomeUsuario);
            }
        }

        private void lsvDuvida_SelectedIndexChanged(object sender, EventArgs e)
        {
            //duvida = duvidaBanco.GetDuvidaPorAssunto(lsvDuvida.SelectedIndices.ToString, Usuarios.usuario);
            //importar o texto do item selecionado para poder pegar todos os valores da duvida e passar o texto da resposta para o aluno
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            int idProfessor = usuarioBanco.GetIdUsuario(cbbProfessores.Text);

            duvidaBanco.InsertDuvida(Usuarios.usuario, txtPergunta.Text, txtAssunto.Text, idProfessor);
        }
    }
}
