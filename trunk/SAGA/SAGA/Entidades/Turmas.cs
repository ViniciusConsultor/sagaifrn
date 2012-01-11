using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Turmas")]
    class Turmas
    {
        [Column(Name = "IdTurma", CanBeNull = false, IsPrimaryKey = true)]
        private int turma;
        [Column(Name = "NomeTurma", CanBeNull = false)]
        private string nomeTurma;

        public string NomeTurma
        {
            get { return nomeTurma; }
            set { nomeTurma = value; }
        }

        public int Turma
        {
            get { return turma; }
            set { turma = value; }
        }
    }
}
