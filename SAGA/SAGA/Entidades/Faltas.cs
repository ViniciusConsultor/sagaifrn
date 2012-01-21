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
        [Column(Name="DataFalta", IsPrimaryKey=true)]
        private DateTime dataFalta;
        [Column(Name = "IdAluno")]
        private int? idAluno;
        [Column(Name = "IdDisciplina")]
        private int? idDisciplina;
        [Column(Name = "Justificativa")]
        private string justificativa;
        [Column(Name = "Quantidade")]
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

        public int? IdAlunos
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

        public int? IdDisciplina
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
