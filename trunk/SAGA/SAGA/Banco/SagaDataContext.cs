using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using SAGA.Entidades;

namespace SAGA.Banco
{
    class SagaDataContext:DataContext
    {
        public Table<Alunos> Aluno;
        public Table<Avisos> Aviso;
        public Table<Avisos_Turmas> Aviso_Turma;
        public Table<Disciplinas> Disciplina;
        public Table<Disciplinas_Turmas> Disciplina_Turma;
        public Table<Duvidas> Duvida;
        public Table<Faltas> Falta;
        public Table<Horarios> Horario;
        public Table<Notas> Nota;
        public Table<Professores> Professor;
        public Table<Professores_Turmas> Professor_Turma;
        public Table<TipoUsuario> TipoUsuario;
        public Table<Turmas> Turma;
        public Table<Usuarios> Usuario;

        public SagaDataContext() : base(getConexao()) { }

        private static string getConexao()
        {
            return "Data Source = localhost; Initial Catalog = NorthWind; Integrated Security=SSPI";
        }
    }
}
