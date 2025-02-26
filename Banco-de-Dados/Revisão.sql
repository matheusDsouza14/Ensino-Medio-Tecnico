create database revisao_prova;
use revisao_prova;
-- Criar tabelas
create table aluno(
	id_aluno int primary key auto_increment not null ,
    nome varchar(80) not null,
    data_nasc date not null,
	fk_professor int not null,
    fk_sala int not null,
    foreign key (fk_professor) references professor(id_professor), -- Estrutura foreign key (Tabela_Origem) references tabela_Destino(campo da tabela destino)
    foreign key (fk_sala) references sala(id_sala)
);
create table professor(
	id_professor int primary key auto_increment not null,
    nome varchar(80) not null,
    fk_sala int not null,
    foreign key (fk_sala) references sala(id_sala)
);
create table sala(
	id_sala int primary key auto_increment not null,
    andar varchar(9) not null,
    fk_professor int not null,
    foreign key (fk_professor) references professor(id_professor)
);
-- Instruções SQL
alter table professor add column cpf varchar(11); 
-- Drop apaga tabela toda
-- Insert
insert into professor (id_professor,nome,cpf) values (default,"João","99999993300");
insert into professor (id_professor,nome,cpf) values (default,"Maria","99999999800");
insert into professor (id_professor,nome,cpf) values (default,"Fernanda","99998999900");
insert into aluno (id_aluno,nome,data_nasc) values (default,"Carlos","2005-07-08");
insert into aluno (id_aluno,nome,data_nasc) values (default,"Tiago","2004-09-30");
insert into sala (id_sala,andar) values (default,"1");
insert into sala (id_sala,andar) values (default,"1");
insert into sala (id_sala,andar) values (default,"1");
insert into sala (id_sala,andar) values (default,"1");
insert into sala (id_sala,andar) values (default,"2");
insert into sala (id_sala,andar) values (default,"2");
insert into sala (id_sala,andar) values (default,"2");
insert into sala (id_sala,andar) values (default,"2");
-- Update
update sala set id_sala = 10 where id_sala = 1;
-- Delete
delete  from sala where id_sala = 10;
/*select * from sala;  -- estrutura basica do select
select id_sala as numero_sala from sala; -- Coloquei um apelido para id_sala como "numero_sala"*/
select distinct nome from aluno; -- Mostra só o nome dos alunos, não repetidos
select * from sala limit 5 offset 1;  -- limita a quantidade de linhas que vão aparecer, ofset pula linhas
select * from sala where id_sala between 2 and 8; -- Selecionará apenas as linhas em que id_sala for entre 2 e 8 /Like usado para comparação de strings
select * from aluno order by data_nasc; -- Ordena os itens de aluno pela data
select data_nasc from aluno having (id_aluno) > 1; -- Having é utilizada para filtrar valores que já passaram por uma agregação.
-- Inner Join , junta tabelas com colunas com valores semelhantes
select al.nome, al.fk_sala, sl.fk_professor
from aluno as al 
inner join sala as sl
on al.fk_sala = sl.id_sala;




