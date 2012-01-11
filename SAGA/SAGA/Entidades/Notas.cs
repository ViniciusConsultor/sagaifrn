using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Notas")]
    class Notas
    {
        [Column(Name="ValorNota", CanBeNull=false, IsPrimaryKey=true)]
        private double valorNota;
        [Column(Name = "BimestreNota", CanBeNull = false)]
        private int bimestreNota;
        [Column(Name = "IdAluno", CanBeNull = false)]
        private Alunos idAluno;
        [Column(Name = "IdDisciplina", CanBeNull = false)]
        private Disciplinas idDisciplina;

        public Disciplinas IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        public Alunos IdAluno
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
