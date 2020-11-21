CREATE TABLE cliente (
	id_cliente INT(18) AUTO_INCREMENT,
	data_cadastro DATETIME  NOT NULL,
	tipo_cliente TINYINT NOT NULL,
	tipo_pessoa TINYINT NOT NULL,
	nome VARCHAR(255) NOT NULL,
	razao_social VARCHAR(255),
	cpf_cnpj VARCHAR(18) NOT NULL,
	inscricao VARCHAR(25),
	endereco VARCHAR(255) NOT NULL,
	numero VARCHAR(30) NOT NULL,
	bairro VARCHAR(255) NOT NULL,
	cidade VARCHAR(255) NOT NULL,
	complemento VARCHAR(255),
	cep VARCHAR(9) NOT NULL,
	uf VARCHAR(2) NOT NULL,
	observacoes TEXT,
	CONSTRAINT pk_cliente PRIMARY KEY (id_cliente)
) ENGINE=INNODB;