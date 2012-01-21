using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class Professores_TurmasBanco
    {
        private Professores_Turmas professor_turma =new Professores_Turmas();
        private SagaDataContext sagaCtx = new SagaDataContext();

        public IEnumerable<Professores_Turmas> GetProfessoresTurma(int idTurma)
        {
            try
            {
                var professores = from professor in sagaCtx.Professor_Turma
                                  where professor.Turma.Turma == idTurma
                                  select professor;
                return professores;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public IEnumerable<Professores_Turmas> GetTurmasProfessor(int idProfessor)
        {
            try
            {
                var turmas = from turma in sagaCtx.Professor_Turma
                             where turma.Professor.Usuario.IdUsuario == idProfessor
                             select turma;
                return turmas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
