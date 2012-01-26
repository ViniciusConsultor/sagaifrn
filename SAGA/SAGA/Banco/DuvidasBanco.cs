using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class DuvidasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Duvidas duvida = new Duvidas();

        public IEnumerable<Duvidas> GetDuvidas(int idUsuario)
        {
            try
            {
                var duvidas = from _duvida in sagaCtx.Duvida
                              where idUsuario == Convert.ToInt32(duvida.IdAluno) || idUsuario == Convert.ToInt32(duvida.IdProfessor)
                              select _duvida;
                return duvidas;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Duvidas GetDuvidaPorPergunta(string pergunta, int idAluno)
        {
            try
            {
                var _duvida = sagaCtx.Duvida.Single(duv => duv.Aluno.IdAluno == idAluno && duv.Pergunta == pergunta);
                return _duvida;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void InsertDuvida(int idAluno, string pergunta, string assunto, int idProfessor)
        {
            duvida.Aluno.Usuario.IdUsuario = idAluno;
            duvida.Pergunta = pergunta;
            duvida.Assunto = assunto;
            duvida.Professor.Usuario.IdUsuario = idProfessor;

            sagaCtx.Duvida.InsertOnSubmit(duvida);
            sagaCtx.SubmitChanges();
        }
    }
}
