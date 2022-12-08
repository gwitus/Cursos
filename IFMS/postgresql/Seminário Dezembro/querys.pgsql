-- 01 - Nome e CPF de todos os clientes;

SELECT pessoa.nome, pessoa.cpf 
FROM pessoa JOIN cliente ON pessoa.id = cliente.pessoa_id
ORDER BY pessoa.cpf

-- 02 - Idade em anos das pessoas;

SELECT pessoa.nome, EXTRACT (YEAR FROM age(pessoa.data)) as idade
FROM pessoa
ORDER BY idade

-- 03 - Funcionários com telefones com prefixo 11;

SELECT pessoa.nome, telefone.telefone_principal, telefone.telefone_secundario 
FROM pessoa join telefone on pessoa.id = telefone.pessoa_id
JOIN funcionario on pessoa.id = funcionario.funcionario_id
WHERE LEFT(telefone_principal, 4) = '(11)' 
    OR LEFT(telefone_secundario, 4) = '(11)'

-- 04 -  Quantidade de pessoas com mesmo sobrenome;

SELECT DISTINCT pessoa.nome, count(pessoa.nome) as repetições_nome
FROM pessoa
GROUP BY pessoa.nome
ORDER BY repetições_nome asc

-- 05 - Clientes com mais de 50 anos;

SELECT pessoa.nome, EXTRACT (YEAR FROM age(pessoa.data)) as idade
FROM pessoa
WHERE EXTRACT (YEAR FROM age(pessoa.data)) > 50
ORDER BY idade

-- 06 - Quantidade de veículos com a cor vermelha;

SELECT DISTINCT veiculo.cor, count(*) 
FROM veiculo
WHERE veiculo.cor = 'vermelho'
GROUP BY veiculo.cor

-- 07 - Quantidade por ano de venda dos veículos do modelo “civic”;

SELECT DISTINCT veiculo.modelo, count (*)
FROM veiculo JOIN vendas on veiculo.id = vendas.veiculo
WHERE veiculo.modelo = 'corolla'
    AND EXTRACT(YEAR FROM (vendas.data_compra)) = 2022
GROUP BY veiculo.modelo

-- 08 - Os cincos vendedores que mais realizaram vendas no ano de 2020;

SELECT DISTINCT pessoa.nome, count(vendas.vendedor) as Vendas
FROM pessoa join funcionario on funcionario.funcionario_id = pessoa.id
    JOIN vendas on vendas.vendedor = funcionario.funcionario_id
GROUP BY pessoa.nome
ORDER BY vendas desc

-- 09 - Os cincos modelos mais vendidos no ano de 2021;

SELECT DISTINCT veiculo.modelo, count (*)
FROM veiculo JOIN vendas on veiculo.id = vendas.veiculo
    GROUP BY veiculo.modelo
    ORDER BY veiculo.modelo desc
LIMIT 5

-- 10 - Profissão dos clientes que adquiriram veículos no ano de 2022.

SELECT DISTINCT cliente.profissao
    FROM cliente join vendas on vendas.comprador = cliente.pessoa_id
    WHERE EXTRACT(YEAR FROM vendas.data_compra) = 2022
GROUP BY cliente.profissao