using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Professores")]
    class Professores
    {
        [Column(Name = "IdProfessor", CanBeNull = false, IsPrimaryKey = true)]
        private Usuarios idProfessor;

        public Usuarios IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }
    }
}
