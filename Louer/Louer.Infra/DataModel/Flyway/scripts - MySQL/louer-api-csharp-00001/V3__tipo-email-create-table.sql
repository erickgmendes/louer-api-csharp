CREATE TABLE tipo_email (
	id_tipo_email INT(18) AUTO_INCREMENT,
	descricao VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_email PRIMARY KEY (id_tipo_email),
	CONSTRAINT uk_tipo_email_descricao UNIQUE KEY (descricao)
) ENGINE=INNODB;