using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class UsuarioBanco
    {
        private SagaDataContext sagaCtx = new SagaDataContext();
        private Usuarios usuario = new Usuarios();
        private TipoUsuario tipoUsuario = new TipoUsuario();

        public int LogIn(string _usuario, string senha)
        {
            try
            {
                var logIn = from id in sagaCtx.Usuario
                            where _usuario == usuario.NomeUsuario
                             && senha == usuario.Senha
                            select id;

                //Usuarios.usuario = Convert.ToInt32(logIn);
                return Convert.ToInt32(logIn) ;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public static int GetTipoUsuario(int idUsuario)
        {
            try
            {
                var tipo = from t in sagaCtx.TipoUsuario
                           where idUsuario == usuario.IdUsuario && Convert.ToInt32(usuario.IdTipoUsuario) == tipoUsuario.IdTipoUsuario
                           select t;

                return Convert.ToInt32(tipo);
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
