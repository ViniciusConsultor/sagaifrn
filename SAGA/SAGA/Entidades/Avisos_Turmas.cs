using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAGA.Entidades;

namespace WindowsFormsApplication1
{
    class Avisos_Turmas
    {
        private Avisos idAviso;
        private Turmas idTurma;

        internal Turmas IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        internal Avisos IdAviso
        {
            get { return idAviso; }
            set { idAviso = value; }
        }
    }
}
