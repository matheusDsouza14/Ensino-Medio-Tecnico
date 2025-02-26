create database banco_urna_MatheusDellAretideSouza;
use banco_urna_MatheusDellAretideSouza;
create table partido(
	id int unsigned primary key not null auto_increment,
	nome varchar(80) not null,
	sigla varchar(15)  not null
);
create table candidato(
	id int unsigned primary key not null auto_increment,
	nome varchar(80) not null,
	endereco varchar(120) not null,
	partido_id int not null,
	cargo_id int not null,
    foreign key (partido_id) references partido(id),
	foreign key (cargo_id) references cargo(id)
);
create table cargo(
	id int unsigned primary key not null auto_increment,
    nome varchar(80) not null,
    descricao varchar(120) not null
);
create table eleitor(
	id int unsigned primary key not null auto_increment,
    nome varchar(80) not null,
    endereco varchar(120) not null
);
create table voto(
	id int unsigned primary key not null auto_increment,
    data_voto date not null,
    quantidade int not null,
    eleitor_id int not null,
    cargo_id int not null,
	foreign key (eleitor_id) references eleitor(id),
	foreign key (cargo_id) references cargo(id)
);
insert into partido values 
(default,"Partido1","P1"),
(default,"Partido2","P2"),
(default,"Partido3","P3");
insert into candidato(id,nome,endereco) values 
(default,"ZezimDoPneu","rua 23 de agosto"),
(default,"Flavia","rua 245"),
(default,"DonaNeusa","rua 45");
insert into cargo (id,nome,descricao)values 
(default,"presidente","abc"),
(default,"vereador","abc"),
(default,"senador","abc");
insert into eleitor(id,nome,endereco)values 
(default,"Julia","Rua1"),
(default,"Giovanni","Rua2"),
(default,"João","Rua3");
insert into voto (id,data_voto,quantidade)values 
(default,"2022-09-14",23),
(default,"2022-09-14",55),
(default,"2022-09-14",13);
update partido set nome = "Partido4" where id = 1;
update candidato set nome = "Catia Damaseno" where id = 1;
update cargo set nome = "Vereador" where id = 1;
update eleitor set endereco = "rua4" where id = 1;
update voto set quantidade = 69 where id = 1;
select * from  partido order by nome;
select * from  candidato order by nome;
select * from  cargo order by nome;
select * from  eleitor order by endereco;
select * from  voto order by quantidade;
delete from partido where nome = "Partido4";
delete from candidato where nome = "Catia Damaseno";
delete from cargo where nome = "Vereador";
delete from eleitor where nome = "Julia";
delete from voto where data_voto = "2022-09-14";






