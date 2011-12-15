using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Usuarios
    {
        private int idUsuario;
        private string senha, nomeUsuario;
        private TipoUsuario idTipoUsuario;

        internal TipoUsuario IdTipoUsuario
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
