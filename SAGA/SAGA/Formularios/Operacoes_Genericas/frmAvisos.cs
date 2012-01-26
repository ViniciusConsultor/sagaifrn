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
    public partial class frmAvisos : Form
    {
        public frmAvisos()
        {
            InitializeComponent();
            usuarioBanco = new UsuarioBanco();
        }

        private UsuarioBanco usuarioBanco;

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
        }

        private void frmAvisos_Load(object sender, EventArgs e)
        {
            Professores_TurmasBanco professor_tumaBanco = new Professores_TurmasBanco();
            Usuarios usuario = new Usuarios();

            if (usuario.TipoUsuario.IdTipoUsuario == 2)
            {
                IEnumerable<Professores_Turmas> turmas = professor_tumaBanco.GetTurmasProfessor(Usuarios.usuario);

                foreach (var turma in turmas)
                {
                    ckblTurmas.Items.Add(turma.Turma.NomeTurma);
                }
            }

            int tipoUsuario = usuarioBanco.GetTipoUsuario(Usuarios.usuario);

            switch (tipoUsuario)
            {
                case 3:
                {
                    lblModificarSenha.Visible = true;
                    lblPaginaInicial.Visible = false;
                    break;
                }
            }
        }

        private void lblPaginaInicial_Click(object sender, EventArgs e)
        {
            int tipoUsuario = usuarioBanco.GetTipoUsuario(Usuarios.usuario);

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
            }
        }

        private void lblModificarSenha_Click(object sender, EventArgs e)
        {
                frmAlterarSenha frmAlterar = new frmAlterarSenha();
                frmAlterar.Show();
                this.Close();
        }
    }
}
