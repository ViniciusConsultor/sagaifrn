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
        [Column(Name = "IdTurma", IsPrimaryKey = true)]
        private int turma;
        [Column(Name = "NomeTurma")]
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
