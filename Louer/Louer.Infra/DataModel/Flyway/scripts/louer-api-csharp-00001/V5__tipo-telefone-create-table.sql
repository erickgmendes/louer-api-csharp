CREATE TABLE tipo_telefone (
	id_tipo_telefone NUMBER NOT NULL,
	descricao VARCHAR2(255) NOT NULL
);

ALTER TABLE tipo_telefone ADD CONSTRAINT pk_tipo_telefone PRIMARY KEY (id_tipo_telefone);

ALTER TABLE tipo_telefone ADD CONSTRAINT uk_tipo_telefone_descricao UNIQUE KEY (descricao)