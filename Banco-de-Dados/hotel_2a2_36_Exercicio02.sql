create database hotel_2A2_39;
use hotel_2A2_39;
create table Cliente (
	cod_Cliente integer not null primary key auto_increment,
    nome varchar(80) not null,
    CPF varchar(13) not null,
    Tipo_convenio varchar(40)
);
create table Reserva (
	cod_Reserva integer not null primary key auto_increment,
    DataInicio date not null,
    DataFim date not null,
    Quarto int not null,
    Valor double (9,2),
    cliente_cod_fk integer not null,
    foreign key (cliente_cod_fk) references Cliente (cod_Cliente)
);
create table Hospede (
	cod_Hospede integer not null primary key auto_increment,
    nome varchar(80) not null,
    Reserva_cod_fk integer not null,
    foreign key (Reserva_cod_fk) references Reserva (cod_Reserva),
    telefone char(15),
    Email varchar(60)
);
create table Quarto (
	cod_Quarto integer not null primary key auto_increment,
    numero int not null,
    andar int not null,
    classificacao varchar(40) not null,
    Hospede_cod_fk integer not null,
    foreign key (Hospede_cod_fk) references Hospede(cod_Hospede)
);
create table Servicos (
	cod_Servicos integer not null primary key auto_increment,
    itens varchar(50) not null,
    tipo varchar(50) not null,
    observacao varchar(100) not null,
    Quarto_cod_fk integer not null,
    foreign key (Quarto_cod_fk) references Quarto(cod_Quarto),
    servico_copa_fk integer not null,
    foreign key (servico_copa_fk) references Servico_copa (cod_Servico_copa)
);

create table Servico_copa (
	cod_Servico_copa integer not null primary key auto_increment,
    registro varchar(100),
    tipo_servico varchar(40)
);
select * from cliente;
insert into Cliente(cod_Cliente,nome,CPF,Tipo_convenio) values
(null,'Ana Maria Alves',818.477260-12,'standard'),
(null,'Alex Paulo Viana',173.400085-32,'Vip'),
(null,'Marcelo Moreira',511.741468-55,'Premium');
select * from reserva;
insert into Reserva(cod_Reserva,DataInicio,DataFim,Quarto,Valor,cliente_cod_fk) values
(null,2022/08/01,2022/06/03,31,900.1),
(null,2022/05/24,2022/05/18,31,1.200.2),
(null,2022/07/28,2023/07/30,31,900.3);
select * from hospede;
insert into Hospede(cod_Hospede,nome,Reserva_cod_fk,telefone,Email) values
(null,'Rogerio Gilves',1,'91554-1344','rogerilves@gmail.com'),
(null,'Paulo Eduardo',2,'91866-1268','EduPaulo@gmail.com'),
(null,'Mariana Cabral',3,'97584-6204','Diana_Pinto@gmail.com');

 