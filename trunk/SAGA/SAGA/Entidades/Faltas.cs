using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Faltas")]
    class Faltas
    {
        [Column(Name="DataFalta", CanBeNull=false, IsPrimaryKey=true)]
        private DateTime dataFalta;
        [Column(Name = "IdAluno", CanBeNull = false)]
        private Alunos idAluno;
        [Column(Name = "IdDisciplina", CanBeNull = false)]
        private Disciplinas idDisciplina;
        [Column(Name = "Justificativa", CanBeNull = true)]
        private string justificativa;
        [Column(Name = "Quantidade", CanBeNull = true)]
        private int quatindade;
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

        public Alunos IdAlunos
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public Faltas()
        {
            dataFalta = DateTime.Today.Date;
        }

        public DateTime DataFalta
        {
            get { return dataFalta; }
            set { dataFalta = value; }
        }

        public string Justificativa
        {
            get { return justificativa; }
            set { justificativa = value; }
        }

        public Disciplinas IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        public int Quatindade
        {
            get { return quatindade; }
            set { quatindade = value; }
        }
    }
}
