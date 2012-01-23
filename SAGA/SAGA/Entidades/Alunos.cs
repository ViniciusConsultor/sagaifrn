using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Alunos")]
    class Alunos
    {
        private int idAluno;
        private int? idTurma;
        private EntityRef<Usuarios> usuario;
        private EntityRef<Turmas> turma;

        [Association(Storage = "usuario", ThisKey = "IdAluno", OtherKey = "IdUsuario")]
        public Usuarios Usuario
        {
            get { return this.usuario.Entity; }
            set { this.usuario.Entity = value; }
        }

        [Association(Storage = "turma", ThisKey = "IdTurma", OtherKey = "Turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }

        [Column(Name = "IdTurma")]
        public int? IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        [Column(IsPrimaryKey = true, Name = "IdAluno")]
        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }
    }
}
