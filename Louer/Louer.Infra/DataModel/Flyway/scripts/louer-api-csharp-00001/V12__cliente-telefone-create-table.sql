CREATE TABLE cliente_telefone (
	id_cliente_telefone NUMBER NOT NULL,
	id_cliente NUMBER NOT NULL,
	ddd VARCHAR2(2) NOT NULL,
	numero VARCHAR2(10) NOT NULL,
	tipo_telefone NUMBER NOT NULL
);

ALTER TABLE cliente_telefone ADD CONSTRAINT pk_cliente_telefone PRIMARY KEY (id_cliente_telefone);

ALTER TABLE cliente_telefone ADD CONSTRAINT fk_cliente_telefone_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)