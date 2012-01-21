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
        private EntityRef<Avisos> aviso;
        private EntityRef<Turmas> turma;
        [Column(Name = "IdTurma", IsPrimaryKey = true)]
        public int? IdTurma{get; set;}
        [Column(Name = "IdAviso", IsPrimaryKey = true)]
        public int? IdAviso{get; set;}

        [Association(Storage = "aviso", ThisKey = "IdAviso", OtherKey = "IdAviso")]
        public Avisos Aviso
        {
            get { return this.aviso.Entity; }
            set { this.aviso.Entity = value; }
        }

        [Association(Storage = "turma", ThisKey = "IdTurma", OtherKey = "Turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }
    }
}
