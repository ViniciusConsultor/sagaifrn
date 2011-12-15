using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Turmas
    {
        private int turma;
        private string nomeTurma;

        public string NomeTurma
        {
            get { return nomeTurma; }
            set { nomeTurma = value; }
        }

        public int Turma
        {
            get { return turma; }
            set { turma = value; }
        }
    }
}
