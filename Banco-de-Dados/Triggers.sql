USE clubedapizza;
-- 1. Crie (ou modifique) uma trigger que atualize o valor total de um pedido para cada item adicionado na tabela ITENS.
DELIMITER //

CREATE TRIGGER update_valor_total
AFTER INSERT ON itens
FOR EACH ROW
BEGIN
    DECLARE total_pedido FLOAT;
    SELECT SUM(preco * quantidade) INTO total_pedido
    FROM pizzas
    WHERE idpizzas = NEW.idpizzas;
    UPDATE pedidos
    SET valor_total = total_pedido
    WHERE idpedidos = NEW.idpedidos;
END //

DELIMITER ;

-- Verificar
INSERT INTO itens (idpedidos, idpizzas, quantidade, tipo) VALUES (2, 9, 2, 1);
SELECT idpedidos, valor_total
FROM pedidos
WHERE idpedidos = 2;
-- 2. Crie uma tabela chamada LOGSAtendentes que guarde data, idpedidos e o valor do pedido, pra registrar os pedidos atendidos por um Atendente.
 CREATE TABLE LOGAtendentes (
    idlogatendentes INT AUTO_INCREMENT PRIMARY KEY,
    data_atendimento TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    idatendentes INT,
    idpedidos INT,
    valor_pedido FLOAT,
    FOREIGN KEY (idatendentes) REFERENCES atendentes(idatendentes),
    FOREIGN KEY (idpedidos) REFERENCES pedidos(idpedidos)
);
-- a. Para o evento INSERT pra o pedido, crie uma trigger e informe que foi realizado uma inclusão de pedido
DELIMITER //

CREATE TRIGGER log_inclusao_pedido
AFTER INSERT ON pedidos
FOR EACH ROW
BEGIN
    INSERT INTO LOGAtendentes (idatendentes, idpedidos, valor_pedido)
    VALUES (NEW.idatendentes, NEW.idpedidos, NEW.valor_total);
   
 
END //

DELIMITER ;

SELECT * FROM LOGAtendentes;

INSERT INTO pedidos (idatendentes, idsocios, datapedido, valor_total) VALUES (1, 1, '2023-11-14', 50);

SELECT * FROM LOGAtendentes;
-- b. Para o evento DELETE pra o pedido, crie uma trigger que registre os dados excluídos e também informe que foi realizado um comando de exclusão
DELIMITER //

CREATE TRIGGER log_exclusao_pedido
AFTER DELETE ON pedidos
FOR EACH ROW
BEGIN
    INSERT INTO LOGAtendentes (idatendentes, idpedidos, valor_pedido)
    VALUES (OLD.idatendentes, OLD.idpedidos, OLD.valor_total);
   
    -- Adicione aqui qualquer outra lógica ou ação que você deseja executar após a exclusão do pedido.
END //

DELIMITER ;

SELECT * FROM LOGAtendentes;
SET foreign_key_checks = 0;

DELETE FROM pedidos WHERE idpedidos = 1;

SET foreign_key_checks = 1;

SELECT * FROM LOGAtendentes;
-- с. Para o evento UPDATE pra o pedido, crie uma trigger que registre os novosdados atualizados, informando também que foi realizada uma alteração de dados de um pedido.
DELIMITER //

CREATE TRIGGER after_update_pedido
AFTER UPDATE
ON pedidos FOR EACH ROW

BEGIN
    DECLARE mensagem VARCHAR(255);

    -- Verifica se o valor_total foi atualizado
    IF NEW.valor_total <> OLD.valor_total THEN
        SET mensagem = CONCAT('Pedido ID ', NEW.idpedidos, ' teve o valor total atualizado para ', NEW.valor_total);
    ELSE
        SET mensagem = CONCAT('Alteração nos dados do Pedido ID ', NEW.idpedidos);
    END IF;

    -- Insere o registro na tabela de logs
    INSERT INTO LOGAtendentes (data, idpedidos, mensagem)
    VALUES (NOW(), NEW.idpedidos, mensagem);

END //

DELIMITER ;

UPDATE pedidos SET valor_total = 120 WHERE idpedidos = 1;

SELECT * FROM LOGAtendentes;
-- 3. Para uma nova tabela LOGSOCIOS com os dados (idsocios,nomesocio, datahora), crie triggers que:
-- a. Para cada novo sócio cadastrado, guardar uma cópia dos seus dados na tabela LOGSOCIOS.
DELIMITER //
CREATE TRIGGER log_socio_insert
AFTER INSERT ON socios
FOR EACH ROW
BEGIN
  INSERT INTO LOGSOCIOS (idsocios, nomesocio, datahora)
  VALUES (NEW.idsocios, NEW.nomesocio, NOW());
END;
//
DELIMITER ;

SELECT * FROM LOGAtendentes;
-- b. Para cada sócio excluído, excluir sua cópia correspondente na tabelaLOGSOCIOS.
DELIMITER //
CREATE TRIGGER log_socio_delete
BEFORE DELETE ON socios
FOR EACH ROW
BEGIN
  DELETE FROM LOGSOCIOS WHERE idsocios = OLD.idsocios;
END;
//
DELIMITER ;

SELECT * FROM LOGSOCIOS;
-- с. Para cada sócio com dados atualizados, inserir um novo registro na tabela LOGSOCIOS com os novos dados atualizados, vindos da tabela Socios.
DELIMITER //
CREATE TRIGGER log_socio_update
AFTER UPDATE ON socios
FOR EACH ROW
BEGIN
  INSERT INTO LOGSOCIOS (idsocios, nomesocio, datahora)
  VALUES (NEW.idsocios, NEW.nomesocio, NOW());
END;
//
DELIMITER ;

SELECT * FROM LOGSOCIOS;

