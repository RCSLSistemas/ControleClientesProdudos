using ControleClientesProdudos.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientesProdudos.Models
{
    public class Produtos
    {
        ConexaoDB conexao = new ConexaoDB();
        private int idProduto;
        private string nome;
        private string descricao;
        private Double preco;
        private int estoque;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public Double Preco { get => preco; set => preco = value; }
        public int Estoque { get => estoque; set => estoque = value; }

        /// <summary>
        /// Rotina para Inserir dados
        /// </summary>
        public void Insere()
        {
            int i = conexao.ExecutaComandoInsert("INSERT INTO  produtos(nome, descricao, preco, estoque) " +
            "VALUES ( '" + Nome +
            "', '" + Descricao +
            "', " + Preco.ToString().Replace(",", ".") +
            ", " + Estoque +
            ");");
        }
        /// <summary>
        /// Rotina para Alterar Registro
        /// </summary>
        public void Altera()
        {
            int i = conexao.ExecutaComandoInsert("Update produtos set " +
            "nome = '" + Nome + "', " +
            "descricao = '" + Descricao + "', " +
            "preco = " + Preco.ToString().Replace(",",".") + " ," +
            "estoque = " + Estoque + "" +
            " WHERE idProduto = " + idProduto + "");
        }
        /// <summary>
        /// Rotina de retirada de quantidade estoque
        /// </summary>
        /// <param name="qtd">quantidade de retirada</param>
        public void AlteraEstoque(int qtd)
        {
            int i = conexao.ExecutaComandoInsert("Update produtos set " +
            "estoque = estoque " +  - qtd + "" +
            " WHERE idProduto = " + idProduto + "");
        }

        /// <summary>
        /// Rotina para Selecionar dados da tabela por Texto 
        /// </summary>
        /// <param name="campo"> campo de pesquisa</param>
        /// <param name="condicao">valor de pesquisa</param>
        public void SelecionaTipoTexto(string campo = "", string condicao = "", bool like = false)
        {
            string query = "SELECT * FROM produtos";
            if (condicao != "") query = "SELECT * FROM produtos WHERE " + campo + " = '" + condicao + "' ORDER BY idProduto, nome";
            if (like) query = "SELECT * FROM produtos WHERE " + campo + " like '%" + condicao + "%' ORDER BY idProduto, nome";

            NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

            while (reader.Read())
            {
                idProduto = (int)reader["idProduto"];
                Nome = reader["nome"].ToString().Trim();
                descricao = reader["descricao"].ToString().Trim();
                preco = (Double)reader["preco"];
                estoque = (int)reader["estoque"];
            }
        }
        /// <summary>
        /// Rotina para Selecionar dados da tabela por numero inteiro 
        /// </summary>
        /// <param name="campo"> campo de pesquisa</param>
        /// <param name="condicao">valor de pesquisa</param>
        public void SelecionaTipoInt(string campo = "", int condicao = 0)
        {
            string query = "SELECT * FROM produtos";
            if (condicao != 0) query = "SELECT * FROM produtos WHERE " + campo + " = " + condicao + "";

            NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

            while (reader.Read())
            {
                idProduto = (int)reader["idProduto"];
                Nome = reader["nome"].ToString().Trim();
                descricao = reader["descricao"].ToString().Trim();
                preco = (Double)reader["preco"];
                estoque = (int)reader["estoque"];
            }
        }

        /// <summary>
        /// Rotina para Deletar Registro
        /// </summary>
        public void Deletar()
        {
            int i = conexao.ExecutaComandoDelete("DELETE FROM produtos WHERE idProduto = " + idProduto + ";");
        }
    }
}
