CREATE TABLE pessoa (
	idpessoa INT NOT NULL PRIMARY KEY,
	nome VARCHAR(100),
	documento VARCHAR(20),
	celular VARCHAR(20)
);

CREATE TABLE produto (
	idproduto INT NOT NULL PRIMARY KEY,
	nome VARCHAR(100),
	coderp VARCHAR(10),
	preco NUMERIC(10,2)
);

CREATE TABLE compra (
	idcompra INT NOT NULL PRIMARY KEY,
	idproduto INT,
	idpessoa INT,
	datacompra DATE,
	CONSTRAINT fk_pessoa_compra FOREIGN KEY (idpessoa) REFERENCES pessoa(idpessoa),
	CONSTRAINT fk_produto_compra FOREIGN KEY (idproduto) REFERENCES produto(idproduto)
);