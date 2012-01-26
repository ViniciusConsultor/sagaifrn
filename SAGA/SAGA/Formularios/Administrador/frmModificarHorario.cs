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
    public partial class frmModificarHorario : Form
    {
        public frmModificarHorario()
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

        private HorariosBanco horarioBanco = new HorariosBanco();
        private TurmasBanco turmaBanco = new TurmasBanco();

        private void cbbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTurma = turmaBanco.GetTurmasPorNome(cbbTurma.Text);
            IEnumerable<Horarios> horarios = horarioBanco.GetHorario(idTurma);

            foreach (var horario in horarios)
            {
                switch (horario.DiaSemana)
                {
                    case "Segunda":
                    {
                        switch (horario.NumeroHorario)
                        {
                            case 0:
                            {
                                txt11.Text = horario.Disciplina.NomeDisciplina;
                                break;
                            }
                            case 1:
                            {
                                txt12.Text = horario.Disciplina.NomeDisciplina;
                                break;
                            }
                            case 2:
                            {
                                txt13.Text = horario.Disciplina.NomeDisciplina;
                                break;
                            }
                            case 3:
                            {
                                txt14.Text = horario.Disciplina.NomeDisciplina;
                                break;
                            }
                            case 4:
                            {
                                txt15.Text = horario.Disciplina.NomeDisciplina;
                                break;
                            }
                        }
                        break;
                    }
                    case "Terça":
                    {
                        switch (horario.NumeroHorario)
                        {
                            case 0:
                                {
                                    txt21.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 1:
                                {
                                    txt22.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 2:
                                {
                                    txt23.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 3:
                                {
                                    txt24.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 4:
                                {
                                    txt25.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                        }
                        break;
                    }
                    case "Quarta":
                    {
                        switch (horario.NumeroHorario)
                        {
                            case 0:
                                {
                                    txt31.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 1:
                                {
                                    txt32.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 2:
                                {
                                    txt33.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 3:
                                {
                                    txt34.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 4:
                                {
                                    txt35.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                        }
                        break;
                    }
                    case "Quinta":
                    {
                        switch (horario.NumeroHorario)
                        {
                            case 0:
                                {
                                    txt41.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 1:
                                {
                                    txt42.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 2:
                                {
                                    txt43.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 3:
                                {
                                    txt44.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 4:
                                {
                                    txt45.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                        }
                        break;
                    }
                    case "Sexta":
                    {
                        switch (horario.NumeroHorario)
                        {
                            case 0:
                                {
                                    txt51.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 1:
                                {
                                    txt52.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 2:
                                {
                                    txt53.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 3:
                                {
                                    txt54.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                            case 4:
                                {
                                    txt55.Text = horario.Disciplina.NomeDisciplina;
                                    break;
                                }
                        }
                        break;
                    }
                }
            }
        }

        private void frmModificarHorario_Load(object sender, EventArgs e)
        {
            IEnumerable<Turmas> turmas = turmaBanco.GetTurmas();

            foreach (var turma in turmas)
            {
                cbbTurma.Items.Add(turma.NomeTurma);
            }
        }
    }
}
