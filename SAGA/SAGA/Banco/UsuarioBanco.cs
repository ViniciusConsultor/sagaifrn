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
        private SqlConnection conexao = new SqlConnection("Data Source = localhost; Initial Catalog = SAGA; Integrated Security = SSPI;");
        private SqlDataAdapter adaptador;
        private DataSet ds = new DataSet();

        public void LogIn(string usuario, string senha)
        {
            string strComando = "select u.IdUsuario from Usuarios u where @Senha = u.Senha and @NomeUsuario = u.NomeUsuario";
            SqlCommand comando = new SqlCommand(strComando, conexao);
            adaptador.SelectCommand = comando;
            adaptador.SelectCommand.Parameters.Add("@Senha", SqlDbType.VarChar, 16, senha);
            adaptador.SelectCommand.Parameters.Add("@NomeUsuario", SqlDbType.VarChar, 30, usuario);

            try
            {
                adaptador.Fill(ds, "Usuario");
                if (ds != null)
                {
                    DataRow linha = ds.Tables["Usuario"].NewRow();
                    Usuarios.usuario = Convert.ToInt32(linha["IdUsuario"]);
                    MessageBox.Show(Usuarios.usuario.ToString());
                }
                else
                {
                    MessageBox.Show("O nome de usuário ou senha estão incorretos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
