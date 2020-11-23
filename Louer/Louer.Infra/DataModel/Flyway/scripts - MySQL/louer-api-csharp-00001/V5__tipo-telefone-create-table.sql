CREATE TABLE tipo_telefone (
	id_tipo_telefone INT(18) AUTO_INCREMENT,
	descricao VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_telefone PRIMARY KEY (id_tipo_telefone),
	CONSTRAINT uk_tipo_telefone_descricao UNIQUE KEY (descricao)
) ENGINE=INNODB;