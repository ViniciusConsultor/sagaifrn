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
        private EntityRef<Usuarios> usuario;

        [Association(Storage = "usuario", ThisKey = "IdProfessor", OtherKey = "IdUsuario")]
        public Usuarios Usuario
        {
            get { return this.usuario.Entity; }
            set { this.usuario.Entity = value; }
        }

        public Usuarios IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }
    }
}
