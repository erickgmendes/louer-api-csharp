CREATE TABLE tipo_email (
	id_tipo_email INT(18) AUTO_INCREMENT,
	nome VARCHAR(255) NOT NULL,
	CONSTRAINT pk_tipo_email PRIMARY KEY (id_tipo_email)
) ENGINE=INNODB;