CREATE TABLE tipo_cliente (
	id_tipo_cliente INT(18) AUTO_INCREMENT,
	descricao VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_cliente PRIMARY KEY (id_tipo_cliente),
	CONSTRAINT uk_tipo_cliente_descricao UNIQUE KEY (descricao)
) ENGINE=INNODB;