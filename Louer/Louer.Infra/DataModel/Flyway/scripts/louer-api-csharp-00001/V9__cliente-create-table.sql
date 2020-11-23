CREATE TABLE cliente (
	id_cliente NUMBER NOT NULL,
	id_tipo_cliente NUMBER NOT NULL,
	id_tipo_pessoa NUMBER NOT NULL,
	data_cadastro DATE  NOT NULL,
	tipo_pessoa NUMBER NOT NULL,
	nome VARCHAR2(255) NOT NULL,
	razao_social VARCHAR2(255),
	cpf_cnpj VARCHAR2(18) NOT NULL,
	inscricao VARCHAR2(25),
	endereco VARCHAR2(255) NOT NULL,
	numero VARCHAR2(30) NOT NULL,
	bairro VARCHAR2(255) NOT NULL,
	cidade VARCHAR2(255) NOT NULL,
	complemento VARCHAR2(255),
	cep VARCHAR2(9) NOT NULL,
	uf VARCHAR2(2) NOT NULL,
	observacoes TEXT
);

ALTER TABLE cliente ADD CONSTRAINT pk_cliente PRIMARY KEY (id_cliente);

ALTER TABLE cliente ADD CONSTRAINT fk_cliente_tipo_cliente FOREIGN KEY (id_tipo_cliente) REFERENCES tipo_cliente(id_tipo_cliente);

ALTER TABLE cliente ADD CONSTRAINT fk_cliente_tipo_pessoa FOREIGN KEY (id_tipo_pessoa) REFERENCES tipo_pessoa(id_tipo_pessoa);