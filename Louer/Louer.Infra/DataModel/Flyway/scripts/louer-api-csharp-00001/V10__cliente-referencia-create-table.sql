CREATE TABLE cliente_referencia (
	id_cliente_referencia NUMBER NOT NULL,
	id_cliente NUMBER NOT NULL,
	nome VARCHAR2(255) NOT NULL,
	telefone VARCHAR2(50) NOT NULL,
	afinidade VARCHAR2(50) NOT NULL
);

ALTER TABLE cliente_referencia ADD CONSTRAINT pk_cliente_referencia PRIMARY KEY(id_cliente_referencia);

ALTER TABLE cliente_referencia ADD CONSTRAINT fk_cliente_referencia_cliente FOREIGN KEY  (id_cliente) REFERENCES cliente(id_cliente);