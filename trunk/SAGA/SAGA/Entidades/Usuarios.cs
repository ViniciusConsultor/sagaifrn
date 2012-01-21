using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Usuarios")]
    class Usuarios
    {
        [Column(Name = "IdUsuario", IsPrimaryKey = true)]
        private int idUsuario;
        [Column(Name = "Senha")]
        private string senha;
        [Column(Name = "NomeUsuario")]
        private string nomeUsuario;
        [Column(Name = "IdTipoUsuario")]
        private int? idTipoUsuario;
        [Column(Name = "Usuario")]
        public static int usuario;
        private EntityRef<TipoUsuario> tipoUsuario;

        [Association(Storage = "tipoUsuario", ThisKey = "IdTipoUsuario", OtherKey = "IdTipoUsuario")]
        public TipoUsuario TipoUsuario
        {
            get { return this.tipoUsuario.Entity; }
            set { this.tipoUsuario.Entity = value; }
        }

        public int? IdTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }


        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
    }
}
