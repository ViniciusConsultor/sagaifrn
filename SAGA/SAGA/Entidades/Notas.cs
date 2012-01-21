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
        [Column(Name="ValorNota", IsPrimaryKey=true)]
        private double valorNota;
        [Column(Name = "BimestreNota")]
        private int bimestreNota;
        [Column(Name = "IdAluno")]
        private int? idAluno;
        [Column(Name = "IdDisciplina")]
        private int? idDisciplina;
        private EntityRef<Alunos> aluno;
        private EntityRef<Disciplinas> disciplina;

        [Association(Storage = "disciplina", ThisKey = "IdDisciplina", OtherKey = "IdDisciplina")]
        public Disciplinas Disciplina
        {
            get { return this.disciplina.Entity; }
            set { this.disciplina.Entity = value; }
        }

        [Association(Storage = "aluno", ThisKey = "idAluno", OtherKey = "idAluno")]
        public Alunos Aluno
        {
            get { return this.aluno.Entity; }
            set { this.aluno.Entity = value; }
        }

        public int? IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        public int? IdAluno
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
