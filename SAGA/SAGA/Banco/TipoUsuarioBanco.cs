using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;
using System.Data;
using System.Data.SqlClient;

namespace SAGA.Banco
{
    class TipoUsuarioBanco
    {
        private SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = SAGA; Integrated Security = SSPI;");
        private SqlDataAdapter adaptador;
        private DataSet ds = new DataSet();

        //public int DescobrirTipoUsuario(int idUsuario)
        //{
        //    string strComando = "select t.IdTipoUsuario from TipoUsuario t, Usuarios u where u.@IdTipoUsuario = t.IdTipoUsuario";
        //    SqlCommand comando = new SqlCommand(strComando, conexao);
        //    adaptador.SelectCommand = comando;
        //    //adaptador.SelectCommand.Parameters.Add("@TipoUsuario", SqlDbType.Int, 1, idUsuario);

        //}
    }
}
