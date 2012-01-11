using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Avisos_Turmas")]
    class Avisos_Turmas
    {
        [Column(Name="IdAviso", CanBeNull=false, IsPrimaryKey=true)]
        private Avisos idAviso;
        [Column(Name = "IdTurma", CanBeNull = false, IsPrimaryKey=true)]
        private Turmas idTurma;

        public Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public Avisos IdAviso
        {
            get { return idAviso; }
            set { idAviso = value; }
        }
    }
}
