using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Notas
    {
        private double valorNota;
        private int bimestreNota;
        private Alunos idAluno;
        private Disciplinas idDisciplina;

        internal Disciplinas IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        internal Alunos IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public int BimestreNota
        {
            get { return bimestreNota; }
            set { bimestreNota = value; }
        }

        public double ValorNota
        {
            get { return valorNota; }
            set { valorNota = value; }
        }
    }
}
