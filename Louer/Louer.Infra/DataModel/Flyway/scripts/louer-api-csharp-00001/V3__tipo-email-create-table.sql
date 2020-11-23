CREATE TABLE tipo_email (
	id_tipo_email NUMBER NOT NULL,
	descricao VARCHAR2(255) NOT NULL
);

ALTER TABLE tipo_email ADD CONSTRAINT pk_tipo_email PRIMARY KEY (id_tipo_email);

ALTER TABLE tipo_email ADD CONSTRAINT uk_tipo_email_descricao UNIQUE KEY (descricao)