using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Professores_Turmas")]
    class Professores_Turmas
    {
        private int? idTurma;
        private int? idProfessor;
        private EntityRef<Turmas> turma;
        private EntityRef<Professores> professor;

        [Association(Storage = "professor", ThisKey = "IdProfessor", OtherKey = "IdProfessor")]
        public Professores Professor
        {
            get { return this.professor.Entity; }
            set { this.professor.Entity = value; }
        }

        [Association(Storage = "turma", ThisKey = "IdTurma", OtherKey = "Turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }

        [Column(Name = "idProfessor", IsPrimaryKey = true)]
        public int? IdProfessor
        {
            get { return idProfessor; }
            set { idProfessor = value; }
        }

        [Column(Name = "IdTurma", IsPrimaryKey = true)]
        public int? IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

    }
}
