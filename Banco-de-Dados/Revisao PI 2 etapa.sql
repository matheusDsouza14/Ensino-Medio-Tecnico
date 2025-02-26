-- Junção de tabelas: OUTER JOIN e CROSS JOIN
SELECT * FROM tabela1 LEFT JOIN tabela2 ON tabela1.id = tabela2.id; -- Left JOIN (retorna todas as linhas da tabela da esquerda e as correspondentes da tabela da direita)
SELECT * FROM tabela1 RIGHT JOIN tabela2 ON tabela1.id = tabela2.id; -- Right JOIN (retorna todas as linhas da tabela da direita e as correspondentes da tabela da esquerda)
SELECT * FROM tabela1 CROSS JOIN tabela2; -- CROSS JOIN (retorna o produto cartesiano de duas tabelas)
-- União de tabelas: UNION e UNION ALL
SELECT coluna FROM tabela1 UNION SELECT coluna FROM tabela2; -- UNION (combina os resultados de duas consultas, removendo duplicatas)
SELECT coluna FROM tabela1 UNION ALL SELECT coluna FROM tabela2; -- UNION ALL (combina os resultados de duas consultas, mantendo todas as linhas, inclusive as duplicatas)
-- DCL - Linguagem de Controle de Dados
GRANT SELECT, INSERT, UPDATE, DELETE ON tabela TO usuario; -- Concede permissões para um usuário em uma tabela
REVOKE SELECT, INSERT, UPDATE, DELETE ON tabela FROM usuario; -- Revoga permissões de um usuário em uma tabela
-- Administração de usuários: criação, acesso e exclusão
CREATE USER 'usuario'@'localhost' IDENTIFIED BY 'senha'; -- Cria um novo usuário
GRANT ALL PRIVILEGES ON *.* TO 'usuario'@'localhost'; -- Concede todas as permissões para um usuário
DROP USER 'usuario'@'localhost'; -- Exclui um usuário
-- Permissões: concessão, revogação e consulta
GRANT SELECT, INSERT, UPDATE, DELETE ON tabela TO usuario; -- Concede permissões para um usuário em uma tabela
REVOKE SELECT, INSERT, UPDATE, DELETE ON tabela FROM usuario; -- Revoga permissões de um usuário em uma tabela
SHOW GRANTS FOR usuario; -- Consulta as permissões de um usuário