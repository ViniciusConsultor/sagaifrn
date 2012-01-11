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
    }
}
