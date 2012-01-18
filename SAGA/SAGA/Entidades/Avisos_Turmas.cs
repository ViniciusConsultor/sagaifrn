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
        private EntityRef<Avisos> aviso;
        private EntityRef<Turmas> turma;
        
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

        [Association(Storage = "aviso", ThisKey = "IdAviso", OtherKey = "IdAviso")]
        public Avisos Aviso
        {
            get { return this.aviso.Entity; }
            set { this.aviso.Entity = value; }
        }

        [Association(Storage = "turma", ThisKey = "IdTurma", OtherKey = "IdTurma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }
    }
}
