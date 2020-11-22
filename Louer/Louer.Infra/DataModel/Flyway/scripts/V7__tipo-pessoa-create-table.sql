CREATE TABLE tipo_pessoa (
	id_tipo_pessoa INT(18) AUTO_INCREMENT,
	nome VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_pessoa PRIMARY KEY (id_tipo_pessoa)
) ENGINE=INNODB;