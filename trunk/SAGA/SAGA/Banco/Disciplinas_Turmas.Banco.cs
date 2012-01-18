using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class Disciplinas_TurmasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Disciplinas_Turmas disciplina_turma = new Disciplinas_Turmas();


        public IEnumerable<string> GetDisciplinasTurma(int idTurma)
        {
            try
            {
                var disciplinas = from disciplina in sagaCtx.Disciplina_Turma
                                  where disciplina.Turma.Turma == idTurma
                                  select disciplina.Turma.NomeTurma;
                return disciplinas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
