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
        private UsuarioBanco usuarioBanco = new UsuarioBanco();

        private void txtAluno_TextChanged(object sender, EventArgs e)
        {
            TurmasBanco turmaBanco = new TurmasBanco();
            Disciplinas_TurmasBanco dtBanco = new Disciplinas_TurmasBanco();

            int idAluno = usuarioBanco.GetAluno(txtAluno.Text);
            if (idAluno > 0)
            {
                int turmaAluno = turmaBanco.GetTurmaAluno(idAluno);
                if (turmaAluno > 0)
                {
                    IEnumerable<string> disciplinas = dtBanco.GetDisciplinasTurma(turmaAluno);
                    if (disciplinas != null)
                    {
                        cbbDisciplina.Items.Add(disciplinas);                        
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro durante a conexão com o banco");
                    }
                }
                else
                {
                    MessageBox.Show("Houve um erro durante a conexão com o banco");
                }
            }
            else
            {
                MessageBox.Show("Houve um erro durante a conexão com o banco");
            }
        }

        private void cbbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisciplinasBanco disciplinaBanco = new DisciplinasBanco();

            int idDisciplina = Convert.ToInt32(disciplinaBanco.GetIdDisciplina(cbbDisciplina.Text));
            int idAluno = usuarioBanco.GetAluno(txtAluno.Text);

            IEnumerable<Faltas> faltas = faltasBanco.GetFaltas(idAluno, idDisciplina);

            List<object> dados = new List<object>();

            faltas.ToList().ForEach(
                falta =>
                {
                    dados.Add(new
                    {
                        Quantidade = falta.Quatindade,
                        Data = falta.DataFalta,
                    });
                });

            foreach (var _falta in dados)
            {
                DataGridViewRow linha = new DataGridViewRow();
                TextBox txt = new TextBox();

                //txt.Text = _falta.Data;                
                //linha
            }
        }
    }
}
