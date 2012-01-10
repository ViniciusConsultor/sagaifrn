using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Horarios
    {
        private string diaSemana;
        private int numeroHorario, turno;
        private Disciplinas idDisciplina;
        private Turmas idTurma;

        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        public int NumeroHorario
        {
            get { return numeroHorario; }
            set { numeroHorario = value; }
        }

        internal Disciplinas IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        internal Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }
    }
}
