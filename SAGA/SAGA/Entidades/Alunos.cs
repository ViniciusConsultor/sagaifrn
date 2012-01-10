using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Alunos")]
    class Alunos
    {
        [Column(IsPrimaryKey=true, Name="IdAluno", CanBeNull=false)]
        private Usuarios idAluno;
        [Column(Name = "IdTurma", CanBeNull = false)]
        private Turmas idTurma;

        public Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public Usuarios IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }
    }
}
