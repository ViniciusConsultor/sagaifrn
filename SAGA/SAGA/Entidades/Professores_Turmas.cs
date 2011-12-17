using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Professores_Turmas
    {
        private Turmas idTurma;
        private Professores idProfessor;

        internal Professores IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        internal Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

    }
}
