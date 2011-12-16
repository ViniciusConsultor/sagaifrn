﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAGA.Entidades
{
    class Avisos
    {
        private int idAviso;
        private DateTime dataPublicacao, dataExpiro;
        private Professores idProfessor;
        private string textoAviso;

        public string TextoAviso
        {
            get { return textoAviso; }
            set { textoAviso = value; }
        }

        internal Professores IdProfessor
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

        public Avisos()
        {
            dataPublicacao = DateTime.Today.Date;
        }
    }
}