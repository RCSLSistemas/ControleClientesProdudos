PGDMP      %    	        
    |            ControleClientesProdudos    17.0    17.0 
    �           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                           false            �           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                           false            �           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                           false            �           1262    16439    ControleClientesProdudos    DATABASE     �   CREATE DATABASE "ControleClientesProdudos" WITH TEMPLATE = template0 ENCODING = 'UTF8' LOCALE_PROVIDER = libc LOCALE = 'Portuguese_Brazil.1252';
 *   DROP DATABASE "ControleClientesProdudos";
                     postgres    false            �            1259    16440    clientes    TABLE     �   CREATE TABLE public.clientes (
    idcliente integer NOT NULL,
    nome character varying,
    endereco character varying,
    telefone character varying,
    email character varying
);
    DROP TABLE public.clientes;
       public         heap r       postgres    false            �            1259    16445    produtos    TABLE     �   CREATE TABLE public.produtos (
    "idProduto" integer NOT NULL,
    nome character varying,
    descricao character varying,
    preco double precision,
    estoque integer
);
    DROP TABLE public.produtos;
       public         heap r       postgres    false            �            1259    16450    vendas    TABLE     �   CREATE TABLE public.vendas (
    idvenda integer NOT NULL,
    quantidadedeitens integer,
    data date,
    idcliente integer NOT NULL,
    idproduto integer NOT NULL
);
    DROP TABLE public.vendas;
       public         heap r       postgres    false            �          0    16440    clientes 
   TABLE DATA           N   COPY public.clientes (idcliente, nome, endereco, telefone, email) FROM stdin;
    public               postgres    false    217   E
       �          0    16445    produtos 
   TABLE DATA           P   COPY public.produtos ("idProduto", nome, descricao, preco, estoque) FROM stdin;
    public               postgres    false    218   b
       �          0    16450    vendas 
   TABLE DATA           X   COPY public.vendas (idvenda, quantidadedeitens, data, idcliente, idproduto) FROM stdin;
    public               postgres    false    219   
       �      x������ � �      �      x������ � �      �      x������ � �     