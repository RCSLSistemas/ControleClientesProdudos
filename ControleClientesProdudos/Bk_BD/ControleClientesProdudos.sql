PGDMP      "            
    |            ControleClientesProdudos    17.0    17.0                 0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false                       1262    16439    ControleClientesProdudos    DATABASE     �   CREATE DATABASE "ControleClientesProdudos" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
 *   DROP DATABASE "ControleClientesProdudos";
                     postgres    false            �            1259    16440    clientes    TABLE     �   CREATE TABLE public.clientes (
    idcliente integer NOT NULL,
    nome character varying,
    endereco character varying,
    telefone character varying,
    email character varying
);
    DROP TABLE public.clientes;
       public         heap r       postgres    false            �            1259    16463    clientes_idcliente_seq    SEQUENCE     �   ALTER TABLE public.clientes ALTER COLUMN idcliente ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.clientes_idcliente_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000
    CACHE 1
);
            public               postgres    false    217            �            1259    16445    produtos    TABLE     �   CREATE TABLE public.produtos (
    idproduto integer NOT NULL,
    nome character varying,
    descricao character varying,
    preco double precision,
    estoque integer
);
    DROP TABLE public.produtos;
       public         heap r       postgres    false                       0    0    COLUMN produtos.idproduto    COMMENT     E   COMMENT ON COLUMN public.produtos.idproduto IS 'Código do produto';
          public               postgres    false    218            �            1259    16464    produtos_idProduto_seq    SEQUENCE     �   ALTER TABLE public.produtos ALTER COLUMN idproduto ADD GENERATED ALWAYS AS IDENTITY (
    SEQUENCE NAME public."produtos_idProduto_seq"
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 1000
    CACHE 1
    CYCLE
);
            public               postgres    false    218            �            1259    16450    vendas    TABLE     �   CREATE TABLE public.vendas (
    idvenda integer NOT NULL,
    qtditens integer,
    data date,
    idcliente integer NOT NULL,
    idproduto integer NOT NULL
);
    DROP TABLE public.vendas;
       public         heap r       postgres    false            �            1259    16477    vendas_idvenda_seq    SEQUENCE     �   ALTER TABLE public.vendas ALTER COLUMN idvenda ADD GENERATED BY DEFAULT AS IDENTITY (
    SEQUENCE NAME public.vendas_idvenda_seq
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    MAXVALUE 10000
    CACHE 1
    CYCLE
);
            public               postgres    false    219            �          0    16440    clientes 
   TABLE DATA           N   COPY public.clientes (idcliente, nome, endereco, telefone, email) FROM stdin;
    public               postgres    false    217   �       �          0    16445    produtos 
   TABLE DATA           N   COPY public.produtos (idproduto, nome, descricao, preco, estoque) FROM stdin;
    public               postgres    false    218   ?       �          0    16450    vendas 
   TABLE DATA           O   COPY public.vendas (idvenda, qtditens, data, idcliente, idproduto) FROM stdin;
    public               postgres    false    219   �                  0    0    clientes_idcliente_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.clientes_idcliente_seq', 45, true);
          public               postgres    false    220                       0    0    produtos_idProduto_seq    SEQUENCE SET     F   SELECT pg_catalog.setval('public."produtos_idProduto_seq"', 6, true);
          public               postgres    false    221                       0    0    vendas_idvenda_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.vendas_idvenda_seq', 27, true);
          public               postgres    false    222            b           2606    16454    clientes clientes_pk 
   CONSTRAINT     Y   ALTER TABLE ONLY public.clientes
    ADD CONSTRAINT clientes_pk PRIMARY KEY (idcliente);
 >   ALTER TABLE ONLY public.clientes DROP CONSTRAINT clientes_pk;
       public                 postgres    false    217            d           2606    16456    produtos clientes_pk_1 
   CONSTRAINT     [   ALTER TABLE ONLY public.produtos
    ADD CONSTRAINT clientes_pk_1 PRIMARY KEY (idproduto);
 @   ALTER TABLE ONLY public.produtos DROP CONSTRAINT clientes_pk_1;
       public                 postgres    false    218            f           2606    16458    vendas vendas_pk 
   CONSTRAINT     S   ALTER TABLE ONLY public.vendas
    ADD CONSTRAINT vendas_pk PRIMARY KEY (idvenda);
 :   ALTER TABLE ONLY public.vendas DROP CONSTRAINT vendas_pk;
       public                 postgres    false    219            �   `  x�eѽN�0��y�[���8N��� �J�]Y��)FI9)��x 6F�b�I�Ń���?�ق��)1CآF��BUlwB�r4�`#�!����ۆLw���ڨL�ܝ�+�j� ��P&��(�cH@�q8��͏���mT�S�b���[g�M�mt�(}���&�Ad[k�ˎ���w|&�S*���mѤTn7*웏s��(� p�Ҳ�eg��FR���lKW�*�|5�Ԇy�U8t�$�4N���T���.�
Mn���A;˃2J�~k�e�p6�g��T}-�����0�Fi+��I�t5Wb���Ω��X������T�fu{�՗ģ�y���c      �   �   x�%�1�0 g�~@��@"1VHݐ:td�J(T#�,|���1,:���C�����4/}y
X�\��{yx�c�#OK.#Ct�F�u0�pg``U�@�ʗ�,�ꘌb�FU�k��(��3�M�-�v��L�L���v�u��T#��H.      �   e   x�m���0�s�;i�]�.|¥Q��Xa7��DN܌��9���_sh�9�m�&k������F(J����v���WS�~۸AY������	�T0�     