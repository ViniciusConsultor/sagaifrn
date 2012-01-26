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
        private double valorNota;
        private int bimestreNota;
        private int? idAluno;
        private int? idDisciplina;
        private EntityRef<Alunos> aluno;
        private EntityRef<Disciplinas> disciplina;

        [Association(Storage = "disciplina", ThisKey = "IdDisciplina", OtherKey = "IdDisciplina")]
        public Disciplinas Disciplina
        {
            get { return this.disciplina.Entity; }
            set { this.disciplina.Entity = value; }
        }

        [Association(Storage = "aluno", ThisKey = "IdAluno", OtherKey = "IdAluno")]
        public Alunos Aluno
        {
            get { return this.aluno.Entity; }
            set { this.aluno.Entity = value; }
        }

        [Column(Name = "IdDisciplina")]
        public int? IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        [Column(Name = "IdAluno")]
        public int? IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        [Column(Name = "BimestreNota")]
        public int BimestreNota
        {
            get { return bimestreNota; }
            set { bimestreNota = value; }
        }

        [Column(Name = "ValorNota", IsPrimaryKey = true)]
        public double ValorNota
        {
            get { return valorNota; }
            set { valorNota = value; }
        }
    }
}
