CREATE TABLE contasPagar(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	valor DECIMAL (5,2),
	tipo VARCHAR (70),
	dataVencimento DATE
);

CREATE TABLE clientes(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	cpf VARCHAR (14),
	dataNascimento DATE,
	rg VARCHAR (12)
);

CREATE TABLE contasReceber(
	id INT PRIMARY KEY IDENTITY (1,1),
	nome VARCHAR (50),
	valor DECIMAL (5,2),
	valorRecebido DECIMAL (5,2),
	dataRecebimento DATE,
	recebido BIT
);