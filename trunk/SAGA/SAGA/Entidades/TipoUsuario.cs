using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "TipoUsuario")]
    class TipoUsuario
    {
        
        private int idTipoUsuario;
        public static int tipoUsuario;

        [Column(Name = "IdTipoUsuario", IsPrimaryKey = true)]
        public int IdTipoUsuario
        {
            get { return idTipoUsuario; }
            set { idTipoUsuario = value; }
        }
    }
}
