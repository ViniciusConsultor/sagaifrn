create database SAGA

use SAGA

create table TipoUsuario(
IdTipoUsuario int not null,
constraint PK_IdTipoUsuario primary key (IdTipoUsuario),
);

create table Usuarios(
IdUsuario int not null,
Senha varchar(16) not null,
NomeUsuario varchar(30) not null,
IdTipoUsuario int not null,
constraint PK_IdUsuario primary key (IdUsuario),
constraint FK_IdTipoUsuario foreign key (IdTipoUsuario) references TipoUsuario
);

create table Professores(
IdProfessor int,
constraint PK_IdProfessor primary key (IdProfessor),
constraint FK_IdProfessor foreign key (IdProfessor) references Usuarios,
);

create table Alunos(
IdAluno int,
constraint PK_IdAluno primary key (IdAluno),
constraint FK_IdAluno foreign key (IdAluno) references Usuarios,
);

create table Avisos(
IdAviso int not null identity,
DataPublicacao date not null,
DataExpiro date not null,
TextoAviso varchar(1024) not null,
IdProfessor int,
constraint PK_IdAviso primary key (IdAviso),
constraint FK_Avisos_IdProfessor foreign key (IdProfessor) references Professores,
);

create table Turmas(
IdTurma int not null identity,
NomeTurma varchar(20) not null,
constraint PK_IdTurma primary key (IdTurma),
);

create table Disciplinas(
IdDisciplina int not null identity,
NomeDisciplina varchar(20) not null,
constraint PK_IdDisciplina primary key (IdDisciplina),
);

create table Notas(
ValorNota double not null,
BimestreNota int not null,
IdAluno int not null,
IdDisciplina int not null,
constraint PK_ValorNota primary key (ValorNota),
constraint FK_Notas_IdAluno foreign key (IdAluno) references Alunos,
constraint FK_Notas_IdDisciplina foreign key (IdDisciplina) references Disciplinas,
);

create table Faltas(
DataFalta date not null,
IdAluno int not null,
IdDisciplina int not null,
constraint PK_DataFalta primary key (DataFalta),
constraint FK_Faltas_IdAluno foreign key (IdAluno) references Alunos,
constraint FK_Faltas_IdDisciplina foreign key (IdDisciplina) references Disciplinas,
);

create table Professores_Turmas(
IdProfessor int not null,
IdTurma int not null,
constraint PK_IdProfessor_IdTurma primary key (IdProfessor, IdTurma),
constraint FK_Professores_Turmas_IdTurma foreign key (IdTurma) references Turmas,
constraint FK_Professores_Turmas_IdProfessor foreign key (IdProfessor) references Professores,
);

create table Disciplinas_Turmas(
IdTurma int not null,
IdDisciplina int not null,
constraint PK_IdDisciplina_IdTurma primary key (IdDisciplina, IdTurma),
constraint FK_Disciplinas_Turmas_IdTurma foreign key (IdTurma) references Turmas,
constraint FK_Disciplinas_Turmas_IdDisciplina foreign key (IdDisciplina) references Disciplinas,
);

create table Avisos_Turmas(
IdTurma int not null,
IdAviso int not null,
constraint PK_IdAviso_IdTurma primary key (IdAviso, IdTurma),
constraint FK_Avisos_Turmas_IdTurma foreign key (IdTurma) references Turmas,
constraint FK_Avisos_Turmas_IdDisciplina foreign key (IdAviso) references Avisos,
);