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
        [Column(IsPrimaryKey = true, Name = "IdDuvida")]
        private int idDuvida;
        [Column(Name = "IdAluno")]
        private int? idAluno;
        [Column(Name = "IdProfessor")]
        private int? idProfessor;
        [Column(Name = "Pergunta")]
        private string pergunta;
        [Column(Name = "Resposta")]
        private string resposta;
        [Column(Name = "Assunto")]
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

        public int? IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }

        public int? IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        public string Pergunta
        {
            get { return pergunta; }
            set { pergunta = value; }
        }

        public string Resposta
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
