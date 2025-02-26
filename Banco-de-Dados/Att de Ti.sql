-- comando para criar banco de dados
create database Equipamentos;
-- comando para usar o BD
use Equipamentos;

create table empregado(
cod_empregado integer not null primary key auto_increment,
Nome varchar(80) not null,
cpf varchar(13) not null
);

create table departamento(
cod_departamento integer not null primary key auto_increment,
Numero varchar (3) not null ,
cod_empregado_fk integer not null,
foreign key (cod_empregado_fk) references reserva(cod_departamento) 
);

create table equipamento (
cod_equipamento integer not null primary key auto_increment,
Nome varchar(80) not null,
Tipo varchar(13) not null,
cod_departamento_fk integer not null,
foreign key (cod_departamento_fk) references reserva(cod_equipamento) 
);

create table manutenções(
cod_manutencao integer not null primary key auto_increment,
Nome varchar(80) not null,
Tipo varchar(13) not null
);

create table chefe(
cod_chefe integer not null primary key auto_increment,
Nome varchar(80) not null,
Tipo varchar(13) not null
);
