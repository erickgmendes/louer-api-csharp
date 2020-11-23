CREATE TABLE tipo_pessoa (
	id_tipo_pessoa NUMBER NOT NULL,
	descricao VARCHAR2(255) NOT NULL
);

ALTER TABLE tipo_pessoa ADD CONSTRAINT pk_tipo_pessoa PRIMARY KEY (id_tipo_pessoa);

ALTER TABLE tipo_pessoa ADD CONSTRAINT uk_tipo_pessoa_descricao UNIQUE KEY (descricao)