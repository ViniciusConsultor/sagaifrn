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
using SAGA.Formularios.Administrador;
using SAGA.Formularios.Alunos;
using SAGA.Formularios.Professores;

namespace SAGA.Formularios.Operacoes_Genericas
{
    public partial class frmAlterarSenha : Form
    {
        UsuarioBanco usuariobanco;
        public frmAlterarSenha()
        {
            InitializeComponent();
            usuariobanco = new UsuarioBanco();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
            Formularios.frmLogIn.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtSenhaAntiga.Text != "" && txtNovaSenha.Text == txtNovaSenha2.Text)
            {

                usuariobanco.ModificarSenha(Usuarios.usuario, txtSenhaAntiga.Text, txtNovaSenha.Text);
            }
            else
            {
                string mensagem = "";
                if (txtNovaSenha.Text != txtNovaSenha2.Text)
                {
                    mensagem += "Digite o mesmo valor para os dois campos.";
                }
                if (txtSenhaAntiga.Text == "")
                {
                    mensagem += "Digite sua senha antiga";
                }
                MessageBox.Show(mensagem);
            }
        }

        private void lblPaginaInicial_Click(object sender, EventArgs e)
        {
            int tipoUsuario = usuariobanco.GetTipoUsuario(Usuarios.usuario);

            switch (tipoUsuario)
            {
                case 1:
                {
                    frmInicialAlunos frmAlunos = new frmInicialAlunos();
                    frmAlunos.Show();
                    this.Close();
                    break;
                }
                case 2:
                {
                    frmInicialProfessores frmProfessores = new frmInicialProfessores();
                    frmProfessores.Show();
                    this.Close();
                    break;
                }
                case 4:
                {
                    frmInicialAdministrador frmAdministrador = new frmInicialAdministrador();
                    frmAdministrador.Show();
                    this.Close();
                    break;
                }
                case 3:
                {
                    frmAvisos frmAvisos = new frmAvisos();
                    frmAvisos.Show();
                    this.Close();
                    break;
                }
            }
        }
    }
}
