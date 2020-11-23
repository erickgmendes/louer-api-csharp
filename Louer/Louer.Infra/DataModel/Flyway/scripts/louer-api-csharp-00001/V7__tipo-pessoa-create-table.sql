CREATE TABLE tipo_pessoa (
	id_tipo_pessoa INT(18) AUTO_INCREMENT,
	descricao VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_pessoa PRIMARY KEY (id_tipo_pessoa),
	CONSTRAINT uk_tipo_pessoa_descricao UNIQUE KEY (descricao)
) ENGINE=INNODB;