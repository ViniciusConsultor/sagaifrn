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
        [Column(Name = "IdUsuario", CanBeNull = false, IsPrimaryKey = true)]
        private int idUsuario;
        [Column(Name = "Senha", CanBeNull = false)]
        private string senha;
        [Column(Name = "NomeUsuario", CanBeNull = false)]
        private string nomeUsuario;
        [Column(Name = "IdTipoUsuario", CanBeNull = false)]
        private TipoUsuario idTipoUsuario;
        [Column(Name = "Usuario", CanBeNull = false)]
        public static int usuario;

        public TipoUsuario IdTipoUsuario
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
