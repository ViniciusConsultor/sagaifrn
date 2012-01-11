using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Professores_Turmas")]
    class Professores_Turmas
    {
        [Column(Name = "IdTurma", CanBeNull = false, IsPrimaryKey = true)]
        private Turmas idTurma;
        [Column(Name = "idProfessor", CanBeNull = false, IsPrimaryKey = true)]
        private Professores idProfessor;

        public Professores IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        public Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

    }
}
