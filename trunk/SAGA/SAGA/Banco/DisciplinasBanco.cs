using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class DisciplinasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Disciplinas disciplina = new Disciplinas();

        public Disciplinas GetIdDisciplina(string nomeDisciplina){
            try
            {
                disciplina = sagaCtx.Disciplina.Single(dis => dis.NomeDisciplina == nomeDisciplina);
                return disciplina;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
