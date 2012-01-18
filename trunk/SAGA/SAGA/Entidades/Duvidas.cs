using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Duvidas")]
    class Duvidas
    {
        [Column(IsPrimaryKey = true, Name = "IdDuvida", CanBeNull = false)]
        private int idDuvida;
        [Column(Name = "IdAluno", CanBeNull = false)]
        private Alunos idAluno;
        [Column(Name = "IdProfessor", CanBeNull = false)]
        private Professores idProfessor;
        [Column(Name = "Pergunta", CanBeNull = false)]
        private string duvida;
        [Column(Name = "Resposta", CanBeNull = false)]
        private string resposta;
        [Column(Name = "Assunto", CanBeNull = false)]
        private string assunto;
        private EntityRef<Alunos> aluno;
        private EntityRef<Professores> professor;

        [Association(Storage = "professor", ThisKey = "IdProfessor", OtherKey = "IdProfessor")]
        public Professores Professor
        {
            get { return this.professor.Entity; }
            set { this.professor.Entity = value; }
        }

        [Association(Storage = "aluno", ThisKey = "IdAluno", OtherKey = "IdAluno")]
        public Alunos Aluno
        {
            get { return this.aluno.Entity; }
            set { this.aluno.Entity = value; }
        }

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
