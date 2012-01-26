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
        private string diaSemana;
        private int numeroHorario;
        private int turno;
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

        [Column(Name = "Turno")]
        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        [Column(Name = "DiaSemana")]
        public string DiaSemana
        {
            get { return diaSemana; }
            set { diaSemana = value; }
        }

        [Column(Name = "NumeroHorario")]
        public int NumeroHorario
        {
            get { return numeroHorario; }
            set { numeroHorario = value; }
        }

        [Column(Name = "IdDisciplina", IsPrimaryKey = true)]
        public int? IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        [Column(Name = "IdTurma", IsPrimaryKey = true)]
        public int? IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }
    }
}
