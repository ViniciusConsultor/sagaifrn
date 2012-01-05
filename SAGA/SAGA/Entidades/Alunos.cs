using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Alunos
    {
        private Usuarios idAluno;
        private Turmas idTurma;

        public Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public Usuarios IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }
    }
}
