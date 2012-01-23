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
        private int turma;
        private string nomeTurma;

        [Column(Name = "NomeTurma")]
        public string NomeTurma
        {
            get { return nomeTurma; }
            set { nomeTurma = value; }
        }

        [Column(Name = "IdTurma", IsPrimaryKey = true,IsDbGenerated=true)]
        public int Turma
        {
            get { return turma; }
            set { turma = value; }
        }
    }
}
