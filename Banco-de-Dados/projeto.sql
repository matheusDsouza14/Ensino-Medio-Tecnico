create database projeto ;
use projeto;
create table projeto  (
id_projeto int primary key not null auto_increment , 
nome varchar(80) not null,
descricao varchar(120) ,
data_criacao date not null,
data_alteracao date not null,
foreign key (id_projeto) references participante(id_participante)
);
create table  participante (
id_participante int primary key not null auto_increment,
email varchar(40) not null,
senha varchar(60) not null,
data_criacao date not null,
data_alteracao date not null
);
create table stats (
id_status int primary key not null auto_increment,
data_criacao date not null,
descricao varchar(120),
data_alteracao date not null
);
-- insert
insert into projeto values (default , "Dproject"); 
insert into participante values (default , "empresapika@contato.com.br"); 
insert into stats values (default , "3-14-2020"); 
-- Update
update projeto set nome = "Restaurant_BD" where id_projeto = 1;
update participante set email = "restaurant@food.com.br" where id_participante = 1;
update stats set data_criacao = "3-14-2019" where id_status = 1;
-- Alter table
alter table projeto add nota float;
-- DELETE 
delete from projeto where nome = "Restaurant_BD";
delete from participante where email = "restaurant@food.com.br";
delete from stats where data_criacao = "3-14-2019";
-- Alias
select id_projeto as cod, email as correio_eletrônico , senha as palavra_passe,data_criacao as cria,data_alteracao as alteracao from projeto;
select id_participante as cod, nome as _name , descricao as descripion,data_criacao as cria,data_alteracao as alteracao from participante;
select id_stats  as cod,descricao as descripion,data_criacao as cria,data_alteracao as alteracao from stats;


