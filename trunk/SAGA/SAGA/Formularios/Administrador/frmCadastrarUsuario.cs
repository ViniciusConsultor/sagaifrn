using System;
using System.Collections.Generic;
using System.ComponentModel;
using SAGA.Entidades;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Banco;

namespace SAGA.Formularios.Administrador
{
    public partial class frmCadastrarUsuario : Form
    {

        private UsuarioBanco usuarioBanco = new UsuarioBanco();

        public frmCadastrarUsuario()
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

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbbTipo.Text)
            {
                case "Aluno":
                {
                    cbbTurmaAluno.Visible = true;
                    cblTurmasProfessores.Visible = false;
                    break;
                }
                case "Professor":
                {
                    cblTurmasProfessores.Visible = true;
                    cbbTurmaAluno.Visible = false;
                    break;
                }
                default:
                {
                    cbbTurmaAluno.Visible = cblTurmasProfessores.Visible = false;
                    break;
                }
            }
        }

        private void frmCadastrarUsuario_Load(object sender, EventArgs e)
        {
            TurmasBanco turmasBanco = new TurmasBanco();
            IEnumerable<Turmas> turmas = turmasBanco.GetTurmas();

            foreach (var turma in turmas)
            {
                cblTurmasProfessores.Items.Add(turma);
                cbbTurmaAluno.Items.Add(turma);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TipoUsuario tipo = new TipoUsuario();
            AlunosBanco alunoBanco = new AlunosBanco();
            TurmasBanco turmaBanco = new TurmasBanco();
            if (cbbTipo.Text != "" && txtNome.Text != "" && txtSenha.Text != "" && txtSenha.Text == txtSenha2.Text)
            {
                if (cbbTipo.Text == "Aluno")
                {
                    if (cbbTurmaAluno.Text != "")
                    {                        
                        alunoBanco.InsertAluno(1, txtNome.Text, txtSenha.Text, turmaBanco.GetTurmasPorNome(cbbTurmaAluno.Text));
                    }
                    else
                    {
                        MessageBox.Show("Selecione uma turma para o aluno");
                    }
                }
                else
                {
                    if (cbbTipo.Text == "Professor")
                    {
                        //FALTA CRIAR O MÉTODO
                    }
                    else
                    {
                        switch (cbbTipo.Text)
                        {
                            case "Administrador":
                            {
                                tipo.IdTipoUsuario = 4;
                                break;
                            }
                            case "Diretor":
                            {
                                tipo.IdTipoUsuario = 3;
                                break;
                            }
                        }
                        usuarioBanco.InsertUsuario(tipo, txtNome.Text, txtSenha.Text);
                    }
                }
                if (cbbTipo.Text == "Administrador" || cbbTipo.Text == "Diretor")
                {
                    
                    
                }
            }
            else
            {
                string mensagem = "";
                if (cbbTipo.Text == "")
                {
                    mensagem += "Você precisa selecionar o tipo do usuário";
                }
                if (txtNome.Text == "")
                {
                    mensagem += "\nVocê precisa digitar o nome do usuário";
                }
                if (txtSenha.Text == "")
                {
                    mensagem += "\nVocê precisa digitar a senha do usuário";
                }
                if (txtSenha2.Text == "")
                {
                    mensagem += "\nRedigite a senha para garantir que a mesma esteja certa";
                }
                else
                {
                    if (txtSenha2.Text != txtSenha.Text)
                    {
                        mensagem += "\nAs senhas não coincidem";
                    }
                }
                MessageBox.Show(mensagem);
            }
        }
    }
}
