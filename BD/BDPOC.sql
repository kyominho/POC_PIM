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
