using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class AvisosBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Avisos avisos = new Avisos();
        private Avisos_Turmas avisos_turmas = new Avisos_Turmas();

        public List<Avisos> GetAvisos(int idTurma)
        {
            List<Avisos> _avisos = new List<Avisos>();
            List<object> dados = new List<object>();
            try
            {
                var aviso = from av in sagaCtx.Aviso
                            where idTurma == Convert.ToInt32(avisos_turmas.IdTurma) && Convert.ToInt32(avisos_turmas.IdAviso) == avisos.IdAviso
                            select av;

                _avisos.ToList().ForEach(
                    _aviso =>
                    {
                        dados.Add(new
                        {
                            Assunto = _aviso.Assunto,
                            TextoAviso = _aviso.TextoAviso,
                        });
                    });

                return _avisos;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
