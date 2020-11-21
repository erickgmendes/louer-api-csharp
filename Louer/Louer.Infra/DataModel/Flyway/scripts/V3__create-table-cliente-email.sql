CREATE TABLE cliente_email (
	id_cliente_email INT(18) AUTO_INCREMENT,
	id_cliente INT(18) NOT NULL,
	endereco VARCHAR(255) NOT NULL,
	tipo TINYINT NOT NULL,
	PRIMARY KEY (id_cliente_email),
	FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)
) ENGINE=INNODB;