CREATE DATABASE fiap;

CREATE TABLE aluno (
    id int NOT NULL PRIMARY KEY,
    nome varchar(255),
    usuario varchar(45),
    senha char(60)
);

CREATE TABLE turma (
    id int NOT NULL PRIMARY KEY,
    curso_id int,
    turma varchar(45),
    ano int,    
);

CREATE TABLE aluno_turma(
	aluno_id int,
	turma_id int,
	Constraint fk_aluno_turma_1_idx foreign key (aluno_id) references aluno(id),
	Constraint fk_turma_1_idx foreign key (turma_id) references turma(id),
	Primary Key (aluno_id, turma_id)
);
