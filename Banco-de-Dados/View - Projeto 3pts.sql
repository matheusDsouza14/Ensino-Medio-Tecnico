use clubedapizza;
-- 1 - Mostre o nome, cpf e tipo do sócio ordenador por nome
create view nome_socio as 
select nomesocio,idtiposocio,cpf from socios order by nomesocio;
select * from nome_socio;
-- 2 - Mostre o nome do sócio e a quantidade total de pedidos
create view nome_quantidade as
select	s.nomesocio , p.quantidade from socios as s
left join pizzas as p
on s.idsocios = p.idpizzas;
select * from nome_quantidade;
-- 3 - Mostre o nome do sócio e a quantidade total de pizzas que ele pediu
create view nome_pizza as 
select s.nomesocio,p.quantidade from socios as s
left join pizzas as p
on s.idsocios = p.idpizzas;
select * from nome_pizza
order by nomesocio;
-- 4 - Mostre o nome do atendente e a soma total de pedidos atendidoss para cada atendente
create view nome_soma as
select a.nomeatendente, COUNT(p.idatendentes) as total_pedidos
from atendentes as a
left JOIN pedidos as p
on a.idatendentes = p.idatendentes
group by a.idatendentes;
select * from nome_soma;
-- 5 - Mostre os sabores de pizza atendidos para cada atendente
create view sabor_atendidos as
select a.idatendentes, a.nomeatendente, p.idpizzas, p.sabor
from atendentes as a
left join pizzas as p
on a.idatendentes = p.idatendentes;
select * from sabor_atendidos;
-- 6 - Mostre o total de pedidos atendidos por atendente
create view total_pedidos_atendente as
select a.nomeatendente, count(p.idpedidos) as total_pedidos
from atendentes as a
left join pedidos as p
on a.idatendentes = p.idatendentes
group by a.nomeatendente;
select * from total_pedidos_atendente;
-- 7 - Mostre o nome do cliente, data do pedido, valor total

-- 8 - Mostre os sabores de pizza contidos por cada pedido

-- 9 - Mostre o total de pedidos por saber de pizza 

-- 10 - Faça um ranking com as 5 pizzas mais vendidas em pedidos, ordenados pela mais pedida
