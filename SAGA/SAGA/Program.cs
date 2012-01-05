using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SAGA.Formularios;
using SAGA.Formularios.Operacoes_Genericas;
using SAGA.Formularios.Administrador;
using SAGA.Formularios.Alunos;
using SAGA.Formularios.Professores;

namespace SAGA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogIn());
        }
    }
}
