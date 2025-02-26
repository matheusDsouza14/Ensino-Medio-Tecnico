create database floricultura_2a2_aula01; -- comando para criar um banco
use floricultura_2a2_aula01; -- comando para usar um banco expecifico
create table cliente( -- comando para criar uma tabela com chave primaria
	rg char(13) not null primary key,
    nome varchar(80) not null,
    telefone char(15) not null,
    endereco_comp varchar(120)
);
-- criar tabela produto
create table produto(
	cod_produto int not null primary key auto_increment ,
    nome varchar(80) not null,
    tipo varchar(80) not null,
    preco decimal(9,2) not null,
    qtd_estoque int not null
);
-- criar tabela item_pedido
create table item_pedido( -- comando para criar uma tabela com chave primaria e estrangeira
	cod_itemPedido int not null primary key auto_increment,
    quantidade int not null,
    valor_total decimal(9,2) not null,
    cod_produto_fk int not null,
    foreign key (cod_produto_fk) references produto(cod_produto)
);
-- criar tabela pedido
describe pedido;
create table pedido( -- comando para criar uma table com duas chaves estrangeiras
		cod_pedido int not null primary key auto_increment,
        dt_compra date not null,
        total_pedido decimal(9,2) not null,
        rg_fk char(13) not null,
        cod_itempedido_fk int not null,
        foreign key (rg_fk) references cliente(rg),
        foreign key (cod_itempedido_fk) references item_pedido (cod_itempedido)
);
-- como ler os dados de uma tabela (READ)
select * from cliente;
-- comando para descrever(detalhar) uma tabela
describe cliente;
-- inserir os dados na tabela (CREATE)
insert into cliente(rg,nome,telefone,endereco_comp) values 
('mg19.999.999','Florisnelson Brito','(31)99999-9999','Rua dos Passarinhos,30, Belo Horizonte'),
('mg29.999.999','Florentina Brito','(31)99999-9999','Rua dos Passarinhos,47, Belo Horizonte'),
('mg39.999.999','Roberto Carlos','(31)99999-9999','Rua Brocha,147, Belo Horizonte'),
('mg49.999.999','Floripedis Brito','(31)99999-9999','Rua dos Passarinhos,140, Belo Horizonte');

-- TABELA PRODUTO
describe produto;

select * from produto;

insert into produto(nome,tipo,preco,qtd_estoque) values
('rosa','flor',10.50,25),
('girassol','flor',15.50,28),
('samambaia','planta',8.50,35);

select * from item_pedido;
insert into pedido(dt_compra,total_pedido,rg_fk,cod_itempedido_fk) values
(2022/04/10,150.85,'mg19.999.999','mg19.999.999');