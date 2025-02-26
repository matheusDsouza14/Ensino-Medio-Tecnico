/*1 - Criar uma procedure que remove Pizzas de um pedido ( tabela itens ) :
	*  Receba como parâmetro uma quantidade de pizza, id de uma pizza e pedido;
	* Remova a quantidade desejada conforme parâmetros;
	SE quantidade for menor ou igual a zero, remova registro, */
delimiter //
create procedure RemovePizzas(
  in pizza_id int,
  in quantidade int,
  in pedido_id int
)
begin
  update itens
  set quantidade = quantidade - quantidade
  where idpizzas = pizza_id and idpedidos = pedido_id;  
  if quantidade <= 0 then
    delete from itens
    where idpizzas = pizza_id and idpedidos = pedido_id;
  end if;
end //
delimiter ;   
/*2 - Criar Procedure que add uma pizza a um pedido, só que estamos em falta de 
Gorgonzola / Romana / Bacon, quando essas pizzas forem pedidas, 
trocar por outras ( CRIAR DUAS PROCEDURES usando IF e outra CASE )*/
delimiter //
create procedure AddPizzaToOrder(
  in pizza_id int,
  in quantidade int,
  in pedido_id int
)
begin
  declare pizza_nome varchar(45);
  select sabor into pizza_nome from pizzas where idpizzas = pizza_id;
  case pizza_nome
    when 'Gorgonzola' then
      insert into itens (idpedidos, idpizzas, quantidade, tipo)
      values (pedido_id, 14, quantidade, 1);
    when 'Romana' then
      insert into itens (idpedidos, idpizzas, quantidade, tipo)
      value (pedido_id, 13, quantidade, 1);
    when 'Bacon' then
      insert into itens (idpedidos, idpizzas, quantidade, tipo)
      values (pedido_id, 12, quantidade, 1);
    else
      insert into itens (idpedidos, idpizzas, quantidade, tipo)
      values (pedido_id, pizza_id, quantidade, 1);
  end case;
end //
delimiter ;
/*3 - Criar procedure que atualiza preço da pizza, receber como parâmetro o id da pizza e o 
valor adicionado ( valor é um inteiro ), retorna na mesma variável o novo preço da pizza! */
delimiter //
create procedure UpdatePizzaPrice(
  in pizza_id INT,
  in valor_adicional INT,
  out novo_preco float
)
begin
  declare pizza_preco float;
  select preco into pizza_preco from pizzas where idpizzas = pizza_id;
  set novo_preco = pizza_preco + valor_adicional;
  update pizzas
  set preco = novo_preco
  where idpizzas = pizza_id;
end //
delimiter ;
/*4 - Criar uma procedure que fecharPedido(pedido) ( totalizando o valor_total do pedido, somando todos os pedidos descritos em itens )*/
delimiter //
create procedure CloseOrder(
  in pedido_id int
)
begin
  declare total_pedido float;
  select sum(p.preco * i.quantidade) into total_pedido
  from itens i
  join pizzas p on i.idpizzas = p.idpizzas
  where i.idpedidos = pedido_id;
  update pedidos
  set valor_total = total_pedido
  where idpedidos = pedido_id;
end //
delimiter ;