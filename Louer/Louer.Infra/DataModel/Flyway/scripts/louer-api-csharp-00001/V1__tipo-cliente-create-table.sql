CREATE TABLE tipo_cliente (
	id_tipo_cliente NUMBER NOT NULL,
	descricao VARCHAR2(255) NOT NULL,
	CONSTRAINT pk_tipo_cliente PRIMARY KEY (id_tipo_cliente),
	CONSTRAINT uk_tipo_cliente_descricao UNIQUE KEY (descricao)
);

ALTER TABLE tipo_cliente ADD CONSTRAINT pk_tipo_cliente PRIMARY KEY (id_tipo_cliente);

ALTER TABLE tipo_cliente ADD CONSTRAINT uk_tipo_cliente_descricao UNIQUE KEY (descricao)