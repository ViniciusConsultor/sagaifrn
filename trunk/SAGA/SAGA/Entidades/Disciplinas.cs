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
        [Column(Name="IdDisciplina", IsPrimaryKey=true)]
        private int idDisciplina;
        [Column(Name="NomeDisciplina")]
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
