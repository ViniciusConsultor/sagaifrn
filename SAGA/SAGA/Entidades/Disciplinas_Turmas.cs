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
        private int? idDisciplina;
        private int? idTurma;
        private EntityRef<Disciplinas> disciplina;
        private EntityRef<Turmas> turma;

        [Association(Storage = "turma", ThisKey = "IdTurma", OtherKey = "Turma")]
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

        [Column(Name = "IdTurma", IsPrimaryKey = true)]
        public int? IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        [Column(Name = "IdDisciplina", IsPrimaryKey = true)]
        public int? IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

    }
}
