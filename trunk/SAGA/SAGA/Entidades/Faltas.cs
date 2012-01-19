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
        private int idAluno;
        [Column(Name = "IdDisciplina", CanBeNull = false)]
        private int idDisciplina;
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

        [Association(Storage = "aluno", ThisKey = "idAluno", OtherKey = "idAluno")]
        public Alunos Aluno
        {
            get { return this.aluno.Entity; }
            set { this.aluno.Entity = value; }
        }

        public int IdAlunos
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

        public int IdDisciplina
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
