CREATE TABLE cliente_referencia (
	id_cliente_referencia INT(18) AUTO_INCREMENT,
	id_cliente INT(18) NOT NULL,
	nome VARCHAR(255) NOT NULL,
	telefone VARCHAR(50) NOT NULL,
	afinidade VARCHAR(50) NOT NULL,
	PRIMARY KEY pk_cliente_referencia (id_cliente_referencia),
	FOREIGN KEY fk_cliente_referencia_cliente (id_cliente) REFERENCES cliente(id_cliente)
) ENGINE=INNODB;