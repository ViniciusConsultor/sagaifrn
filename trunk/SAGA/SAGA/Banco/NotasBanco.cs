﻿using System;
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
    }
}
