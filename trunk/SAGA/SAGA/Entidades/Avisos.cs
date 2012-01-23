using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq.Mapping;
using System.Data.Linq;

namespace SAGA.Entidades
{
    [Table(Name="Avisos")]
    class Avisos
    {
        private int idAviso;
        private DateTime dataPublicacao;
        private DateTime dataExpiro;
        private int? idProfessor;
        private string textoAviso;
        private string assunto;
        private EntityRef<Professores> professor;

        [Association(Storage = "professor", ThisKey = "IdProfessor", OtherKey = "IdProfessor")]
        public Professores Professor
        {
            get { return this.professor.Entity; }
            set { this.professor.Entity = value; }
        }

        [Column(Name = "TextAviso")]
        public string TextoAviso
        {
            get { return textoAviso; }
            set { textoAviso = value; }
        }

        [Column(Name = "IdProfessor")]
        public int? IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        [Column(Name = "DataExpiro")]
        public DateTime DataExpiro
        {
            get { return dataExpiro; }
            set { dataExpiro = value; }
        }

        [Column(Name = "DataPublicacao")]
        public DateTime DataPublicacao
        {
            get { return dataPublicacao; }
            set { dataPublicacao = value; }
        }

        [Column(IsPrimaryKey = true, Name = "IdAviso")]
        public int IdAviso
        {
            get { return idAviso; }
            set { idAviso = value; }
        }

        [Column(Name = "Assunto")]
        public string Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }

        public Avisos()
        {
            dataPublicacao = DateTime.Today.Date;
            dataExpiro = DateTime.Today.AddDays(7).Date;
            assunto = "Sem Assunto";
        }
    }
}
