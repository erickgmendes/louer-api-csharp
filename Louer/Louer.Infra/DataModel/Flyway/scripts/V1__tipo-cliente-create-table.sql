CREATE TABLE tipo_cliente (
	id_tipo_cliente INT(18) AUTO_INCREMENT,
	nome VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_cliente PRIMARY KEY (id_tipo_cliente)
) ENGINE=INNODB;