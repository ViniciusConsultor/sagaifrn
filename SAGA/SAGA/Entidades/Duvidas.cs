using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Duvidas
    {
        private int idDuvida;
        private Alunos idAluno;
        private Professores idProfessor;
        private string duvida, resposta, assunto;

        public int IdDuvida
        {
            get { return idDuvida; }
            set { idDuvida = value; }
        }

        public Alunos IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public Professores IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        private string Duvida
        {
            get { return duvida; }
            set { duvida = value; }
        }

        private string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }

        public Duvidas()
        {
            assunto = "Sem Assunto";
        }
    }
}
