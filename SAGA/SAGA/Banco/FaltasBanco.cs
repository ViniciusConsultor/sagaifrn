﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class FaltasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Faltas falta = new Faltas();

        public IEnumerable<Faltas> GetFaltas(int idAluno, int idDisciplina)
        {
            try
            {
                var faltas = from _falta in sagaCtx.Falta
                             where idAluno == Convert.ToInt32(falta.IdAluno) && idDisciplina == falta.Disciplina.IdDisciplina
                             select _falta;

                return faltas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ModificarFaltas(int idAluno, int idDisciplina, DateTime dataFalta, int quantidade)
        {
            falta.Aluno.IdAluno = idAluno;
            falta.Disciplina.IdDisciplina = idDisciplina;
            falta.DataFalta = dataFalta;
            falta.Quatindade = quantidade;
            sagaCtx.SubmitChanges();
        }
    }
}
