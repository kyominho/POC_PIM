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

CREATE TABLE Insumo (
	codInsumo INT IDENTITY,
	nomeInsumo VARCHAR (60) NOT NULL,
	dataValidadeInsumo DATE  NOT NULL,
	precoInsumo MONEY NOT NULL,
	CONSTRAINT PkcodInsumo PRIMARY KEY (codInsumo)
	)

CREATE TABLE EstoqueProduto
(
	codEstoqueProduto INT IDENTITY,
	quantidadeEstoqueProduto INT NOT NULL,
	codProdutoEP INT NOT NULL,
	CONSTRAINT PkcodEstoqueProduto PRIMARY KEY (codEstoqueProduto),
	CONSTRAINT FkcodProdutoEP FOREIGN KEY (codProdutoEP) REFERENCES Produto (codProduto)
)

CREATE TABLE EstoqueInsumo 
(
	codEstoqueInsumo INT IDENTITY,
	quantidadeEstoqueInsumo INT NOT NULL,
	codInsumoEI INT NOT NULL,
	CONSTRAINT PkcodEstoqueInsumo PRIMARY KEY (codEstoqueInsumo),
	CONSTRAINT FkcodInsumoEI FOREIGN KEY (codInsumoEI) REFERENCES Insumo (codInsumo)
)

CREATE TABLE Compra 
(
	codCompra INT IDENTITY,
	dataHorarioCompra DATETIME NOT NULL,
	formaPagamentoCompra VARCHAR (60) NOT NULL,
    codFornecedorC INT NOT NULL,
	codUsuarioC INT NOT NULL,
	CONSTRAINT PkcodCompra PRIMARY KEY (codCompra),
	CONSTRAINT FkcodFornecedorC FOREIGN KEY (codFornecedorC) REFERENCES Fornecedor (codFornecedor),
	CONSTRAINT FkcodUsuarioC FOREIGN KEY (codUsuarioC) REFERENCES Usuario (codUsuario)

)

CREATE TABLE ItensCompra 
(
	codItensCompra INT IDENTITY,
	quantidadeItensCompra INT NOT NULL,
	valorTotalItensCompra MONEY NOT NULL,
	codCompraIC INT NOT NULL,
	codInsumoIC INT NOT NULL,
	CONSTRAINT PkcodItensCompra PRIMARY KEY (codItensCompra),
	CONSTRAINT FkcodCompraIC FOREIGN KEY (codCompraIC) REFERENCES Compra (codCompra),
	CONSTRAINT  FkcodInsumoIC FOREIGN KEY (codInsumoIC) REFERENCES Insumo (codInsumo)

)

CREATE TABLE Venda 
(
	codVenda INT IDENTITY,
	dataHorarioVenda DATETIME NOT NULL,
	formaPagamentoVenda VARCHAR (60) NOT NULL,
	codUsuarioV INT NOT NULL,
	codClienteV INT NOT NULL,
	CONSTRAINT PkcodVenda PRIMARY KEY (codVenda),
	CONSTRAINT FkcodUsuarioV FOREIGN KEY (codUsuarioV) REFERENCES Usuario (codUsuario),
	CONSTRAINT FkcodClienteV FOREIGN KEY (codClienteV) REFERENCES Cliente (codCliente)

)

CREATE TABLE ItensVenda 
(
	codItensVenda INT IDENTITY,
	quantidadeItensVenda INT NOT NULL,
	valorTotalItensVenda MONEY NOT NULL,
	codProdutoIV INT NOT NULL,
	codVendaIV INT NOT NULL,
	CONSTRAINT PkcodItensVenda PRIMARY KEY (codItensVenda),
	CONSTRAINT FkcodProdutoIV FOREIGN KEY (codProdutoIV) REFERENCES Produto (codProduto),
	CONSTRAINT FkcodVendaIV FOREIGN KEY (codVendaIV) REFERENCES Venda (codVenda)

)

  CREATE TABLE Colheita 
(
	codColheita INT IDENTITY,
	dataHorarioColheita DATETIME NOT NULL,
	quantidadeColheita INT NOT NULL,
	codProdutoC INT NOT NULL,
	CONSTRAINT PkcodColheita PRIMARY KEY (codColheita),
	CONSTRAINT FkcodProdutoC FOREIGN KEY (codProdutoC) REFERENCES Produto (codProduto)

)

CREATE TABLE Plantacao 
(
	codPlantacao INT IDENTITY,
	dataHorarioPlantacao DATETIME NOT NULL,
	quantidadePlantacao INT NOT NULL,
	codInsumoP INT NOT NULL,
	CONSTRAINT PkcodPlantacao PRIMARY KEY (codPlantacao),
	CONSTRAINT FkcodInsumoP FOREIGN KEY (codInsumoP) REFERENCES Insumo (codInsumo)


)

CREATE TABLE Entrega 
(
	codEntrega INT IDENTITY,
	quantidadeEntrega INT NOT NULL,
	codVendaE INT NOT NULL,
	codClienteE INT NOT NULL,
	CONSTRAINT PkcodEntrega PRIMARY KEY (codEntrega),
	CONSTRAINT FkcodVendaE FOREIGN KEY (codVendaE) REFERENCES Venda (codVenda),
	CONSTRAINT FkcodClienteE FOREIGN KEY (codClienteE) REFERENCES Cliente (codCliente)

)









SELECT * FROM Produto

SELECT codInsumo AS 'Código', nomeInsumo AS 'Nome', dataValidadeInsumo AS 'Data de Validade', precoInsumo AS 'Preço' FROM Insumo

SELECT * FROM Cliente

SELECT * FROM ClienteFisico

--TESTANDO DQL (CONSULTAS COM INNER JOIN)
SELECT nomeCliente AS 'Nome', cpfCliente AS 'CPF', emailCliente AS 'Email 'FROM Cliente JOIN ClienteFisico ON Cliente.codCliente = ClienteFisico.codClienteF

SELECT nomeInsumo AS 'Nome', dataValidadeInsumo AS 'Data de Validade', precoInsumo AS 'Preço', quantidadeEstoqueInsumo AS 'Estoque' FROM Insumo JOIN EstoqueInsumo ON Insumo.codInsumo = EstoqueInsumo.codInsumoEI 

SELECT nomeProduto AS 'Nome', dataValidadeProduto AS 'Data de Validade', precoProduto AS 'Preço', quantidadeEstoqueProduto AS 'Estoque' FROM Produto JOIN EstoqueProduto ON Produto.codProduto = EstoqueProduto.codProdutoEP 