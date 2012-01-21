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
    public partial class frmAvisos : Form
    {
        public frmAvisos()
        {
            InitializeComponent();
        }

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
        }
    }
}
