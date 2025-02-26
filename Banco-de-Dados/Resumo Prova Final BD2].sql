use empresa_database;
-- View
create view datanascimentoF as -- Cria a view
select id,nome,day(data_nascimento) as dia,month(data_nascimento) as mês,year(data_nascimento) as ano,cargo from funcionarios -- Seleciona as colunas da tabela funcionario que serão mostradas na view
where month(data_nascimento) = month(curdate()) -- Seleciona apenas aquele que nasceram no mes atual
order by year(data_nascimento); -- Ordena por ano de nascimento
select * from datanascimentoF; -- Mostra a View
-- Procedures
DELIMITER $$
create procedure maior18(in myid int, out idade int) -- cria a procedure
begin -- comeca a procedure
	declare ano_nasc int;     -- declara a variavel
    select year(data_nascimento) into ano_nasc from funcionarios -- seleciona o ano de nascimento do funcionario e adiciona o na variavel
    where id = myid; -- Condiciona a selecionar a idade relacionado ao id (parametro de entrada)
    set idade = year(now()) - ano_nasc; -- Seta a idade como ano(atual) - ano(nascimento)
end$$ -- termina a procedure 
DELIMITER ;
call maior18(4,@idade); -- Chama a  procedure definindo o parametro de entrada(id) e chamando o parametro de saida(idade)
select @idade; -- seleciona o parametro de saida
-- Triggers
