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
        private EntityRef<Alunos> aluno;
        private EntityRef<Disciplinas> disciplina;

        [Association(Storage = "disciplina", ThisKey = "IdDisciplina", OtherKey = "IdDisciplina")]
        public Disciplinas Disciplina
        {
            get { return this.disciplina.Entity; }
            set { this.disciplina.Entity = value; }
        }

        [Association(Storage = "aluno", ThisKey = "IdAluno", OtherKey = "IAluno")]
        public Alunos Aluno
        {
            get { return this.aluno.Entity; }
            set { this.aluno.Entity = value; }
        }

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
