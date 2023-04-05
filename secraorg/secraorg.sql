create database secraorg CHARACTER SET utf8 COLLATE utf8_general_ci;

use secraorg;





create table aluno (
rm varchar(12)primary key not null,
ra varchar(18) not null,
nome varchar (50) not null,
cidade_nascimento varchar(80) not null,
nacionalidade varchar(100) not null,
estado char (2) not null,
data_nascimento varchar (12),
sexo char(1) not null,
rg varchar (11),
cpf varchar (20),
nome_mae varchar (80) not null,
nome_pai varchar (80),
logradouro varchar (80) not null,
num_logradouro varchar (8) not null,
complemento varchar (20),
bairro varchar (80) not null,
telefone varchar (14),
observacao varchar (200),
escola_anterior varchar (100),
serie_ant varchar (2),
grau_anterior varchar (2),
cidade_anterior varchar (100),
estado_anterior char (2),
serie_pretendida varchar (2) not null,
grau_pretendido varchar (2) not null,
estudou_aqui char(3) not null,
ano char (4) not null,
turnoT char (1) not null,
graug varchar (2) not null,
serieS varchar (2) not null,
turmat char (1) not null,
numeroN varchar (2)
);

describe aluno;
INSERT INTO aluno(rm,RA,NOME,CIDADE_NASCIMENTO,NACIONALIDADE,ESTADO,DATA_NASCIMENTO,SEXO,RG,CPF,NOME_MAE,NOME_PAI,LOGRADOURO,NUM_LOGRADOURO,COMPLEMENTO,BAIRRO,TELEFONE,OBSERVACAO,ESCOLA_ANTERIOR,SERIE_ANT,GRAU_ANTERIOR,CIDADE_ANTERIOR,ESTADO_ANTERIOR,SERIE_PRETENDIDA,GRAU_PRETENDIDO,ESTUDOU_AQUI,ANO,TURNOT,GRAUG,SERIES,TURMAT,NUMERON) 
VALUES('99999999','123.213.123-1','ASDASDAS','ADASDSAD','ASDSADAS','AL','12/32/1312','M','ASDASDAS','402,908,968-27','ASDSAD','','ADASDSA','1232','ADSAD','ADASDS','(12)3123-2131','x','ASDSADAS','6º','1º','ASDSADAS','AP','6º','1º','NÃO','2012','M','1º','6º','A','12');

select * from aluno;


create table usuario (
nome varchar (90) not null,
cpf char (11)primary key not null, 
codigo varchar (3) not null
);


select *from usuario;



create table professor (
codigo_professor int auto_increment primary key not null,
nome varchar(50) not null,
cpf char (11) not null,
materia1 varchar (30) not null,
materia2 varchar (30),
materia3 varchar (30),
categoria varchar (30) not null
);

create table turma (
numero_sala varchar (3) primary key not null,
ano char (4) not null,
turmaT char (1) not null,
turnot char (1) not null,
graug char (2) not null,
serieS char (2) not null
);

select * from turma;




