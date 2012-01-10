using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class TipoUsuario
    {
        private int idTipoUsuario;
        public static int tipoUsuario;

        public int IdTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }
    }
}
