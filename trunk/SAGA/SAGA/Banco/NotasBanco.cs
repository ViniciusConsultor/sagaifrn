using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class NotasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Notas nota = new Notas();

        public IEnumerable<Notas> GetNotas(int idAluno)
        {
            try
            {
                var _notas = from _nota in sagaCtx.Nota
                             where idAluno == Convert.ToInt32(nota.IdAluno)
                             select _nota;
                return _notas;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void ModificarNotas(int idAluno, double[] valorNota)
        {
            Disciplinas_TurmasBanco disciplina_turmaBanco = new Disciplinas_TurmasBanco();
            TurmasBanco turmaBanco = new TurmasBanco();

            int idTurma = turmaBanco.GetTurmaAluno(idAluno);

            valorNota = new double[4];
            for (int i = 0; i < valorNota.Length; i++)
            {
                nota.BimestreNota = i + 1;
                nota.ValorNota = valorNota[i];
                nota.Aluno.IdAluno = idAluno;
                nota.Disciplina.IdDisciplina = Convert.ToInt32(disciplina_turmaBanco.GetDisciplinasTurma(idTurma));

                sagaCtx.SubmitChanges();
            }
        }
    }
}
