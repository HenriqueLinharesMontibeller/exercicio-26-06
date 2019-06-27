DROP TABLE IF EXISTS cotas_pagar;
DROP TABLE IF EXISTS clientes;
DROP TABLE IF EXISTS contas_receber;

CREATE TABLE contas_pagar(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	valor DECIMAL (5,2),
	tipo VARCHAR (70),
	data_vencimento DATE
);

CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	cpf VARCHAR (14),
	data_nascimento DATE,
	rg VARCHAR (12)
);

CREATE TABLE contas_receber(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	valor DECIMAL (5,2),
	valor_recebido DECIMAL (5,2),
	data_recebimento DATE,
	recebido BIT
);