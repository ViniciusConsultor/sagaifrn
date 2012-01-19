using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name="Disciplinas_Turmas")]
    class Disciplinas_Turmas
    {
        [Column(Name="IdDisciplina", IsPrimaryKey=true, CanBeNull=false)]
        private int idDisciplina;
        [Column(Name = "IdTurma", IsPrimaryKey = true, CanBeNull = false)]
        private int idTurma;
        private EntityRef<Disciplinas> disciplina;
        private EntityRef<Turmas> turma;

        [Association(Storage = "turma", ThisKey = "idTurma", OtherKey = "turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }

        [Association(Storage = "disciplina", ThisKey = "IdDisciplina", OtherKey = "IdDisciplina")]
        public Disciplinas Disciplina
        {
            get { return this.disciplina.Entity; }
            set { this.disciplina.Entity = value; }
        }

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

    }
}
