CREATE TABLE cliente_telefone (
	id_cliente_telefone INT(18) AUTO_INCREMENT,
	id_cliente INT(18) NOT NULL,
	ddd VARCHAR(2) NOT NULL,
	numero VARCHAR(10) NOT NULL,
	tipo TINYINT NOT NULL,
	PRIMARY KEY pk_cliente_telefone (id_cliente_telefone),
	FOREIGN KEY fk_cliente_telefone_cliente (id_cliente) REFERENCES cliente(id_cliente)
) ENGINE=INNODB;