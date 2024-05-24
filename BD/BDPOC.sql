CREATE DATABASE Fazenda
USE Fazenda


CREATE TABLE Cliente
(
codCliente INT IDENTITY,
nomeCliente VARCHAR (50) NOT NULL,
emailCliente VARCHAR (100) NOT NULL,
ufCliente CHAR (2) NOT NULL,
cidadeCliente VARCHAR (50) NOT NULL,
telefoneCliente CHAR (11) NOT NULL,
cepCliente CHAR (8) NOT NULL,
logradouroCliente VARCHAR (50) NOT NULL,
numeroEnderecoCliente INT NOT NULL,
CONSTRAINT PkcodCliente PRIMARY KEY (codCliente)
)

CREATE TABLE ClienteJuridico
(
codClienteJuridico INT IDENTITY,
cnpjCliente CHAR (14) NOT NULL,
razaoSocialCliente VARCHAR (60) NOT NULL,
codClienteJ INT NOT NULL,
CONSTRAINT PkcodClienteJuridico PRIMARY KEY (codClienteJuridico),
CONSTRAINT FkcodClienteJ FOREIGN KEY (codClienteJ) REFERENCES Cliente (codCliente)
)

CREATE TABLE ClienteFisico 
(
codClienteFisico INT IDENTITY,
cpfCliente CHAR (11) NOT NULL,
codClienteF INT NOT NULL,
CONSTRAINT PkcodClienteFisico PRIMARY KEY (codClienteFisico),
CONSTRAINT FkcodClienteF FOREIGN KEY (codClienteF) REFERENCES Cliente (codCliente)
)

CREATE TABLE Usuario
(
codUsuario INT IDENTITY,
nomeUsuario VARCHAR (50) NOT NULL,
nivelAcesso INT NOT NULL,
login VARCHAR (50) NOT NULL,
senha VARCHAR (20) NOT NULL,
CONSTRAINT PkcodUsuario PRIMARY KEY (codUsuario)

)

CREATE TABLE Produto
(
codProduto INT IDENTITY,
nomeProduto VARCHAR (50) NOT NULL,
precoProduto MONEY NOT NULL,
dataValidadeProduto DATE NOT NULL,
CONSTRAINT PkCodProduto PRIMARY KEY (codProduto)

)

CREATE TABLE Fornecedor 
(
codFornecedor INT IDENTITY,
nomeFornecedor VARCHAR (50) NOT NULL,
emailFornecedor VARCHAR (80) NOT NULL,
ufFornecedor CHAR (2) NOT NULL,
cidadeFornecedor VARCHAR (50) NOT NULL,
logradouroFornecedor VARCHAR (50) NOT NULL,
numeroEnderecoFornecedor INT NOT NULL,
cnpjFornecedor CHAR (14) NOT NULL,
razaoSocialFornecedor VARCHAR (60),

CONSTRAINT PkcodFornecedor PRIMARY KEY (codFornecedor)

)


SELECT * FROM Cliente

SELECT * FROM ClienteFisico

--TESTANDO DQL (CONSULTAS COM INNER JOIN)
SELECT nomeCliente AS 'Nome', cpfCliente AS 'CPF', emailCliente AS 'Email 'FROM Cliente JOIN ClienteFisico ON Cliente.codCliente = ClienteFisico.codClienteF

SELECT * FROM Fornecedor