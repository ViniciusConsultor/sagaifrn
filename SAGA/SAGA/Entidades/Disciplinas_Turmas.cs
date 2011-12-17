using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Disciplinas_Turmas
    {
        private Disciplinas idDisciplina;
        private Turmas idTurma;

        internal Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        internal Disciplinas IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

    }
}
