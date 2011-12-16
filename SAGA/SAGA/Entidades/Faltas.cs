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
        private Alunos idAlunos;
        private Disciplinas idDisciplina;

        internal Alunos IdAlunos
        {
            get { return idAlunos; }
            set { idAlunos = value; }
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
    }
}
