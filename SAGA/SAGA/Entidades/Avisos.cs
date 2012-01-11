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
        [Column(IsPrimaryKey=true, Name="IdAviso", CanBeNull=false)]
        private int idAviso;
        [Column(Name = "DataPublicacao")]
        private DateTime dataPublicacao;
        [Column(Name = "DataExpiro")]
        private DateTime dataExpiro;
        [Column(Name = "IdProfessor", CanBeNull=false)]
        private Professores idProfessor;
        [Column(Name = "TextAviso", CanBeNull = false)]
        private string textoAviso;
        [Column(Name = "Assunto")]
        private string assunto;

        public string TextoAviso
        {
            get { return textoAviso; }
            set { textoAviso = value; }
        }

        public Professores IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        public DateTime DataExpiro
        {
            get { return dataExpiro; }
            set { dataExpiro = value; }
        }

        public DateTime DataPublicacao
        {
            get { return dataPublicacao; }
            set { dataPublicacao = value; }
        }

        public int IdAviso
        {
            get { return idAviso; }
            set { idAviso = value; }
        }

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
