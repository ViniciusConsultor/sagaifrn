using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class AlunosBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Alunos aluno = new Alunos();

        public IEnumerable<Alunos> GetAlunos(int idTurma)
        {
            try
            {
                var alunos = from _aluno in sagaCtx.Aluno
                             where idTurma == Convert.ToInt32(aluno.IdTurma)
                             select _aluno;
                return alunos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
