using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class ProfessoresBanco
    {
        private Professores professores = new Professores();
        private SagaDataContext sagaCtx = new SagaDataContext();

        public void InserProfessor(int tipoUsuario, string nomeUsuario, string senha, List<int> turmas)
        {
            turmas = new List<int>();

            professores.Usuario.NomeUsuario = nomeUsuario;
            professores.Usuario.Senha = senha;
            professores.Usuario.TipoUsuario.IdTipoUsuario = tipoUsuario;

            sagaCtx.Professor.InsertOnSubmit(professores);

            foreach (var turma in turmas)
            {
                
            }
        }
    }
}
