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

namespace SAGA.Formularios.Operacoes_Genericas
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
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
                UsuarioBanco usuariobanco = new UsuarioBanco();

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
    }
}
