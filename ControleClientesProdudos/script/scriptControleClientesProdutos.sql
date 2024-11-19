

CREATE TABLE "Public".clientes (
    idcliente integer NOT NULL,
    nome character varying,
    endereco character varying,
    telefone character varying,
    email character varying
);

ALTER TABLE "Public".clientes OWNER TO postgres;

CREATE TABLE "Public".produtos (
    "idProduto" integer NOT NULL,
    nome character varying,
    descricao character varying,
    preco double precision,
    estoque integer
);

ALTER TABLE "Public".produtos OWNER TO postgres;

CREATE TABLE "Public".vendas (
    idvenda integer NOT NULL,
    quantidadedeitens integer,
    data date,
    idcliente integer NOT NULL,
    idproduto integer NOT NULL
);

ALTER TABLE "Public".vendas OWNER TO postgres;


ALTER TABLE ONLY clientes
    ADD CONSTRAINT clientes_pk PRIMARY KEY (idcliente);

ALTER TABLE ONLY  produtos
    ADD CONSTRAINT clientes_pk_1 PRIMARY KEY ("idProduto");

ALTER TABLE ONLY vendas
    ADD CONSTRAINT vendas_pk PRIMARY KEY (idvenda);
 
ALTER TABLE ONLY vendas
    ADD CONSTRAINT vendas_unique UNIQUE (idcliente);

ALTER TABLE ONLY vendas
    ADD CONSTRAINT vendas_unique_1 UNIQUE (idproduto);