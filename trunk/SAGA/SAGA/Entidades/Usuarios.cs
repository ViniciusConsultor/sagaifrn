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
        
        private int idUsuario;
        
        private string senha;
        
        private string nomeUsuario;
        
        private int? idTipoUsuario;
        /*[Column(Name = "Usuario")]*/
        public static int usuario;
        private EntityRef<TipoUsuario> tipoUsuario;

        [Association(Storage = "tipoUsuario", ThisKey = "IdTipoUsuario", OtherKey = "IdTipoUsuario")]
        public TipoUsuario TipoUsuario
        {
            get { return this.tipoUsuario.Entity; }
            set { this.tipoUsuario.Entity = value; }
        }
         [Column(Name = "IdTipoUsuario")]
        public int? IdTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }

        [Column(Name = "NomeUsuario")]
        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set { nomeUsuario = value; }
        }
        [Column(Name = "Senha")]
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
       
        [Column(Name = "IdUsuario", IsPrimaryKey = true)]
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
    }
}
