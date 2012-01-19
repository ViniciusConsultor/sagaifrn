using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class HorariosBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Horarios horario = new Horarios();

        public IEnumerable<Horarios> GetHorario(int idTurma)
        {
            try
            {
                var horarios = from _horario in sagaCtx.Horario
                               where idTurma == Convert.ToInt32(horario.IdTurma)
                               select _horario;

                return horarios;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void InsertHorario(string[,] horarios, Turmas idTurma, int turno)
        {
            horarios = new string[5,5];
            DisciplinasBanco disciplinasBanco = new DisciplinasBanco();
            for (int linha = 0; linha < 5; linha++)
            {
                for (int coluna = 0; coluna < 5; coluna++)
                {
                    
                    horario.IdDisciplina = Convert.ToInt32(disciplinasBanco.GetIdDisciplina(horarios[linha,coluna]));

                    switch (coluna)
                    {
                        case 0:
                        {
                            horario.DiaSemana = "Segunda";
                            break;
                        }
                        case 1:
                        {
                            horario.DiaSemana = "Terça";
                            break;
                        }
                        case 2:
                        {
                            horario.DiaSemana = "Quarta";
                            break;
                        }
                        case 3:
                        {
                            horario.DiaSemana = "Quinta";
                            break;
                        }
                        case 4:
                        {
                            horario.DiaSemana = "Sexta";
                            break;
                        }
                    }
                    switch (linha)
                    {
                        case 0:
                        {
                            horario.NumeroHorario = 1;
                            break;
                        }case 1:
                        {
                            horario.NumeroHorario = 2;
                            break;
                        }
                        case 2:
                        {
                            horario.NumeroHorario = 3;
                            break;
                        }
                        case 3:
                        {
                            horario.NumeroHorario = 4;
                            break;
                        }
                        case 4:
                        {
                            horario.NumeroHorario = 5;
                            break;
                        }
                    }


                    horario.IdTurma = Convert.ToInt32(idTurma);
                    horario.Turno = turno;

                    sagaCtx.Horario.InsertOnSubmit(horario);
                }
            }
        }
        public void ModifyHorario(string[,] horarios, Turmas idTurma, int turno)
        {

        }
    }
}
