using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class HorariosBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Horarios horario = new Horarios();

        public IEnumerable<Horarios> GetHorario(int idTurma)
        {
            try
            {
                var horarios = from _horario in sagaCtx.Horario
                               where idTurma == Convert.ToInt32(horario.IdTurma)
                               select _horario;

                return horarios;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
