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

        public IEnumerable<Avisos> GetAvisos(int idTurma)
        {
            try
            {
                var aviso = from av in sagaCtx.Aviso
                            where idTurma == Convert.ToInt32(avisos_turmas.IdTurma) && Convert.ToInt32(avisos_turmas.IdAviso) == avisos.IdAviso
                            && av.DataExpiro != DateTime.Today
                            select av;

                //_avisos.ToList().ForEach(
                    //_aviso =>
                    //{
                    //    dados.Add(new
                    //    {
                    //        Assunto = _aviso.Assunto,
                    //        TextoAviso = _aviso.TextoAviso,
                    //    });
                    //});

                return aviso;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public void InsertAviso(DateTime dataInicial, DateTime dataFinal, string textoAviso, string assunto)
        {
            avisos.DataPublicacao = dataInicial;
            avisos.DataExpiro = dataFinal;
            avisos.TextoAviso = textoAviso;
            avisos.Assunto = assunto;

            sagaCtx.Aviso.InsertOnSubmit(avisos);
        }
        public void InsertAvisoProfessor(DateTime dataInicial, DateTime dataFinal, string textoAviso, string assunto, List<int> idTurmas)
        {
            idTurmas = new List<int>();

            foreach (var idTurma in idTurmas)
            {
                avisos.DataPublicacao = dataInicial;
                avisos.DataExpiro = dataFinal;
                avisos.TextoAviso = textoAviso;
                avisos.Assunto = assunto;
                avisos.Professor.IdProfessor = Usuarios.usuario;
                
                sagaCtx.Aviso.InsertOnSubmit(avisos);
            }
        }
    }
}
