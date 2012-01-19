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
        private int idAviso;
        [Column(Name = "IdTurma", CanBeNull = false, IsPrimaryKey=true)]
        private int idTurma;
        private EntityRef<Avisos> aviso;
        private EntityRef<Turmas> turma;
        
        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public int IdAviso
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

        [Association(Storage = "turma", ThisKey = "idTurma", OtherKey = "turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }
    }
}
