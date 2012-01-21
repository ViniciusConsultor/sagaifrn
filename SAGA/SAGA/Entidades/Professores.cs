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
        private EntityRef<Usuarios> usuario;

        [Association(Storage = "usuario", ThisKey = "IdProfessor", OtherKey = "IdUsuario")]
        public Usuarios Usuario
        {
            get { return this.usuario.Entity; }
            set { this.usuario.Entity = value; }
        }

        [Column(Name = "IdProfessor", IsPrimaryKey = true)]
        public int? IdProfessor{get; set;}
    }
}
