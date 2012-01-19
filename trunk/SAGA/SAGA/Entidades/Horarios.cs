using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace SAGA.Entidades
{
    [Table(Name = "Horarios")]
    class Horarios
    {
        [Column(Name = "DiaSemana", CanBeNull = false)]
        private string diaSemana;
        [Column(Name = "NumeroHorario", CanBeNull = false)]
        private int numeroHorario;
        [Column(Name = "Turno", CanBeNull = false)]
        private int turno;
        [Column(Name = "IdDisciplina", CanBeNull = false, IsPrimaryKey=true)]
        private int idDisciplina;
        [Column(Name = "IdTurma", CanBeNull = false, IsPrimaryKey=true)]
        private int idTurma;
        private EntityRef<Disciplinas> disciplina;
        private EntityRef<Turmas> turma;

        [Association(Storage = "turma", ThisKey = "idTurma", OtherKey = "turma")]
        public Turmas Turma
        {
            get { return this.turma.Entity; }
            set { this.turma.Entity = value; }
        }
            
        [Association(Storage = "disciplina", ThisKey = "idDisciplina", OtherKey = "idDisciplina")]
        public Disciplinas Disciplina
        {
            get { return this.disciplina.Entity; }
            set { this.disciplina.Entity = value; }
        }

        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        public int NumeroHorario
        {
            get { return numeroHorario; }
            set { numeroHorario = value; }
        }

        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }
    }
}
