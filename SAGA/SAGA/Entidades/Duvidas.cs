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
        private int idDuvida;
        private int? idAluno;
        private int? idProfessor;
        private string pergunta;
        private string resposta;
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

        [Column(IsPrimaryKey = true, Name = "IdDuvida")]
        public int IdDuvida
        {
            get { return idDuvida; }
            set { idDuvida = value; }
        }

        [Column(Name = "IdAluno")]
        public int? IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        [Column(Name = "IdProfessor")]
        public int? IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        [Column(Name = "Pergunta")]
        public string Pergunta
        {
            get { return pergunta; }
            set { pergunta = value; }
        }

        [Column(Name = "Resposta")]
        public string Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        [Column(Name = "Assunto")]
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
