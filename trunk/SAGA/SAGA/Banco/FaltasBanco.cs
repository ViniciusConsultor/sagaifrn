﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class FaltasBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Faltas falta = new Faltas();

        public IEnumerable<Faltas> GetFaltas(int idAluno)
        {
            try
            {
                var faltas = from _falta in sagaCtx.Falta
                             where idAluno == Convert.ToInt32(falta.IdAlunos)
                             select _falta;

                return faltas;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}