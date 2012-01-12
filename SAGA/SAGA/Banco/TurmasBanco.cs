using System;
using System.Collections.Generic;
using System.Linq;
using SAGA.Entidades;
using System.Text;

namespace SAGA.Banco
{
    class TurmasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Turmas turma = new Turmas();
        private Alunos aluno = new Alunos();

        public int GetTurmaAluno(int idAluno)
        {
            try
            {
                var _turma = from t in sagaCtx.Turma
                             where idAluno == Usuarios.usuario && turma.Turma == Convert.ToInt32(aluno.IdTurma)
                             select t;

                return Convert.ToInt32(_turma);
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public IEnumerable<Turmas> GetTurmasProfessor(int idProfessor)
        {
            try
            {
                var turmas = from _turma in sagaCtx.Turma
                             where idProfessor == Convert.ToInt32(turma.Turma)
                             select _turma;

                return turmas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
