﻿using System;
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

        public Usuarios LogIn(string _usuario, string senha)
        {
            try
            {
                usuario = sagaCtx.Usuario.Single(user => user.NomeUsuario.Equals(_usuario) && user.Senha.Equals(senha));
                          
                //var logIn = from id in sagaCtx.Usuario
                //            where _usuario == usuario.NomeUsuario
                //             && senha == usuario.Senha
                //            select id;

                //Usuarios.usuario = Convert.ToInt32(logIn);
                //return Convert.ToInt32(logIn);
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int GetTipoUsuario(int idUsuario)
        {
            try
            {
                usuario = sagaCtx.Usuario.Single(userType => userType.IdUsuario == idUsuario);
                return Convert.ToInt32(usuario.IdTipoUsuario);
                //var tipo = from t in sagaCtx.TipoUsuario
                //           where idUsuario == usuario.IdUsuario && Convert.ToInt32(usuario.IdTipoUsuario) == tipoUsuario.IdTipoUsuario
                //           select t;

                //return Convert.ToInt32(tipo);
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public void InsertUsuario(TipoUsuario tipo, string nome, string senha)
        {
            usuario.IdTipoUsuario = Convert.ToInt32(tipo);
            usuario.NomeUsuario = nome;
            usuario.Senha = senha;

            sagaCtx.Usuario.InsertOnSubmit(usuario);
            sagaCtx.SubmitChanges();
        }
        public int GetIdUsuario(string nomeUsuario)
        {
            try
            {
                usuario = sagaCtx.Usuario.Single(aluno => Convert.ToString(aluno.NomeUsuario) == nomeUsuario);
                return usuario.IdUsuario;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public Usuarios GetUsuario(int idUsuario)
        {
            try
            {
                var usuario = sagaCtx.Usuario.Single(user => user.IdUsuario == idUsuario);
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void ModificarSenha(int idUsuario, string senhaAntiga, string novaSenha)
        {
            usuario = GetUsuario(idUsuario);
            if (senhaAntiga == usuario.Senha)
            {
                usuario.Senha = novaSenha;

                sagaCtx.SubmitChanges();
            }
        }
    }
}
