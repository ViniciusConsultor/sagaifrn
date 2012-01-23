using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Disciplinas")]
    class Disciplinas
    {
        private int idDisciplina;
        private string nomeDisciplina;

        [Column(Name = "NomeDisciplina")]
        public string NomeDisciplina
        {
            get { return nomeDisciplina; }
            set { nomeDisciplina = value; }
        }

        [Column(Name = "IdDisciplina", IsPrimaryKey = true)]
        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }
    }
}
