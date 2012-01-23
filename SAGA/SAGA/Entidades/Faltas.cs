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
        private DateTime dataFalta;
        private int? idAluno;
        private int? idDisciplina;
        private string justificativa;
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

        [Column(Name = "IdAluno")]
        public int? IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public Faltas()
        {
            dataFalta = DateTime.Today.Date;
        }

        [Column(Name = "DataFalta", IsPrimaryKey = true)]
        public DateTime DataFalta
        {
            get { return dataFalta; }
            set { dataFalta = value; }
        }

        [Column(Name = "Justificativa")]
        public string Justificativa
        {
            get { return justificativa; }
            set { justificativa = value; }
        }

        [Column(Name = "IdDisciplina")]
        public int? IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        [Column(Name = "Quantidade")]
        public int Quatindade
        {
            get { return quatindade; }
            set { quatindade = value; }
        }
    }
}
