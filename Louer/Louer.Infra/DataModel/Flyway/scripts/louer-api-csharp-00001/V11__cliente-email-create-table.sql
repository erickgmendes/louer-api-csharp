CREATE TABLE cliente_email (
	id_cliente_email NUMBER NOT NULL,
	id_cliente NUMBER NOT NULL,
	endereco VARCHAR2(255) NOT NULL,
	tipo_email NUMBER NOT NULL
);

ALTER TABLE cliente_email ADD CONSTRAINT pk_cliente_email PRIMARY KEY (id_cliente_email);

ALTER TABLE cliente_email ADD CONSTRAINT fk_cliente_email_cliente FOREIGN KEY (id_cliente) REFERENCES cliente(id_cliente)