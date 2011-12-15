using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Disciplinas
    {
        private int idDisciplina;
        private string nomeDisciplina;

        public string NomeDisciplina
        {
            get { return nomeDisciplina; }
            set { nomeDisciplina = value; }
        }

        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }
    }
}
