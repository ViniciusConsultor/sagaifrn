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
using SAGA.Formularios.Operacoes_Genericas;

namespace SAGA.Formularios.Administrador
{
    public partial class frmCadastrarHorario : Form
    {
        public frmCadastrarHorario()
        {
            InitializeComponent();
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            Usuarios.usuario = -1;
            this.Close();
            frmLogIn.logIn.Visible = true;
        }

        private void lblPaginaInicial_Click(object sender, EventArgs e)
        {
            frmInicialAdministrador frmInicialAdmin = new frmInicialAdministrador();
            frmInicialAdmin.Show();
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            HorariosBanco horarioBanco = new HorariosBanco();
            Turmas turma = new Turmas();
            TurmasBanco turmaBanco = new TurmasBanco();
            if (txt11.Text != "" && txt12.Text != "" && txt13.Text != "" && txt14.Text != "" && txt15.Text != "" && txt21.Text != "" && txt22.Text != "" &&
                txt23.Text != "" && txt24.Text != "" && txt25.Text != "" && txt31.Text != "" && txt32.Text != "" && txt33.Text != "" && txt34.Text != "" &&
                txt35.Text != "" && txt41.Text != "" && txt42.Text != "" && txt43.Text != "" && txt44.Text != "" && txt45.Text != "" && txt51.Text != "" &&
                txt52.Text != "" && txt53.Text != "" &&  txt54.Text != "" && txt55.Text != "" && cbbTurma.Text != "" && cbbTurno.Text != "")
            {
                string[,] horarios = new string[5, 5];
                horarios[0, 0] = txt11.Text;
                horarios[0, 1] = txt12.Text;
                horarios[0, 2] = txt13.Text;
                horarios[0, 3] = txt14.Text;
                horarios[0, 4] = txt15.Text;
                horarios[1, 0] = txt21.Text;
                horarios[1, 1] = txt22.Text;
                horarios[1, 2] = txt23.Text;
                horarios[1, 3] = txt24.Text;
                horarios[1, 4] = txt25.Text;
                horarios[2, 0] = txt31.Text;
                horarios[2, 1] = txt32.Text;
                horarios[2, 2] = txt33.Text;
                horarios[2, 3] = txt34.Text;
                horarios[2, 4] = txt35.Text;
                horarios[3, 0] = txt41.Text;
                horarios[3, 1] = txt42.Text;
                horarios[3, 2] = txt43.Text;
                horarios[3, 3] = txt44.Text;
                horarios[3, 4] = txt45.Text;
                horarios[4, 0] = txt51.Text;
                horarios[4, 1] = txt52.Text;
                horarios[4, 2] = txt53.Text;
                horarios[4, 3] = txt54.Text;
                horarios[4, 4] = txt55.Text;

                turma.Turma = turmaBanco.GetTurmasPorNome(cbbTurma.Text);
                int turno = 0;
                switch (cbbTurno.Text)
                {
                    case "Matutino":
                    {
                        turno = 1;
                        break;
                    }
                    case "Vespertino":
                    {
                        turno = 2;
                        break;
                    }
                    case "Noturno":
                    {
                        turno = 3;
                        break;
                    }
                }

                horarioBanco.InsertHorario(horarios, turma, turno);

                txt11.Text = "";
                txt12.Text = "";
                txt13.Text = "";
                txt14.Text = "";
                txt15.Text = "";
                txt21.Text = "";
                txt22.Text = "";
                txt23.Text = "";
                txt24.Text = "";
                txt25.Text = "";
                txt31.Text = "";
                txt32.Text = "";
                txt33.Text = "";
                txt34.Text = "";
                txt35.Text = "";
                txt41.Text = "";
                txt42.Text = "";
                txt43.Text = "";
                txt44.Text = "";
                txt45.Text = "";
                txt51.Text = "";
                txt52.Text = "";
                txt53.Text = "";
                txt54.Text = "";
                txt55.Text = "";
            }
            else
            {
                MessageBox.Show("Você precisa preencher todos os campos");
            }
        }

        private void frmCadastrarHorario_Load(object sender, EventArgs e)
        {
            TurmasBanco turmaBanco = new TurmasBanco();
            IEnumerable<Turmas> turmas = turmaBanco.GetTurmas();
            foreach (var turma in turmas)
            {
                cbbTurma.Items.Add(turma);
            }
        }
    }
}
