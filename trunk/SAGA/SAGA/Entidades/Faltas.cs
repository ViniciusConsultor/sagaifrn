using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace WindowsFormsApplication1
{
    class Faltas
    {
        private DateTime dataFalta;
        private Alunos idAluno;
        private Disciplinas idDisciplina;
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
