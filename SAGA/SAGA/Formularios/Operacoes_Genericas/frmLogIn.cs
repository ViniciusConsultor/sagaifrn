﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SAGA.Banco;
using SAGA.Entidades;
using SAGA.Formularios.Administrador;
using SAGA.Formularios.Alunos;
using SAGA.Formularios.Professores;

namespace SAGA.Formularios.Operacoes_Genericas
{
    public partial class frmLogIn : Form
    {
        public static frmLogIn logIn = new frmLogIn();
        private UsuarioBanco usuarioBanco;
        public frmLogIn()
        {
            InitializeComponent();
            usuarioBanco = new UsuarioBanco();
        }

        

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text != "" && txtUsuario.Text != "")
            {
                Usuarios usuario = new Usuarios();
                usuario = usuarioBanco.LogIn(txtUsuario.Text, txtSenha.Text);
                Usuarios.usuario = usuario.IdUsuario;

                if (Usuarios.usuario > 0)
                {
                    TipoUsuario.tipoUsuario = usuarioBanco.GetTipoUsuario(Usuarios.usuario);

                    switch (TipoUsuario.tipoUsuario)
                    {
                        case 1:
                            {
                                    frmInicialAlunos frmAluno = new frmInicialAlunos();
                                    frmAluno.Show();
                                    this.Visible = false;
                                    break;
                            }
                        case 2:
                            {
                                    frmInicialProfessores frmProfessor = new frmInicialProfessores();
                                    frmProfessor.Show();
                                    this.Visible = false;
                                    break;
                            }
                        case 3:
                            {
                                    frmInicialAdministrador frmAdministrador = new frmInicialAdministrador();
                                    frmAdministrador.Show();
                                    this.Visible = false;
                                    break;
                            }
                        case 4:
                            {
                                    frmAvisos frmAvisos = new frmAvisos();
                                    frmAvisos.Show();
                                    this.Visible = false;
                                    break;
                            }
                        default:
                            MessageBox.Show("Houve um erro durante a conexão com o banco", "Erro");
                            TipoUsuario.tipoUsuario = 0;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Seus nome de Usuário ou Senha estão incorretos");
                    Usuarios.usuario = 0;
                }
            }
            else
            {
                string mensagem = "";
                if (txtSenha.Text == "")
                {
                    mensagem += " - Você precisa digitar sua senha!";
                }
                if (txtUsuario.Text == "")
                {
                    mensagem += " - Você precisa digitar seu nome de usuário!";
                }

                MessageBox.Show(mensagem, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
