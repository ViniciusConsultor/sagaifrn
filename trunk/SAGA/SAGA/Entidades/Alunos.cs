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
        [Column(IsPrimaryKey=true, Name="IdAluno")]
        private int idAluno;
        [Column(Name = "IdTurma", CanBeNull = false, IsPrimaryKey=true)]
        private int idTurma;
        private EntityRef<Usuarios> usuario;
        private EntityRef<Turmas> turma;

        [Association(Storage = "usuario", ThisKey = "IdAluno", OtherKey = "IdUsuario")]
        public Usuarios Usuario
        {
            get { return this.usuario.Entity; }
            set { this.usuario.Entity = value; }
        }

        [Association(Storage = "turma", ThisKey = "idTurma", OtherKey = "turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }
    }
}
