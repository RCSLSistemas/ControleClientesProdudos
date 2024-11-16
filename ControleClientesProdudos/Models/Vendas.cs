using ControleClientesProdudos.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientesProdudos.Models
{
    public class Vendas
    {
        ConexaoDB conexao = new ConexaoDB();
        private int idVenda;
        private int qtdItens;
        private DateTime data;
        private int idCliente;
        private int idProduto;

        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int QtdItens { get => qtdItens; set => qtdItens = value; }
        public DateTime Data { get => data; set => data = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }

        /// <summary>
        /// Rotina para Inserir dados
        /// </summary>
        public void Insere()
        {
            int i = conexao.ExecutaComandoInsert("INSERT INTO  vendas(qtdItens, data, idCliente, idProduto) " +
            "VALUES ( '" + QtdItens +
            "', '" + Data +
            "', '" + IdCliente +
            "', '" + IdProduto +
            "');");
        }
        /// <summary>
        /// Rotina para Alterar Registro
        /// </summary>
        public void Altera()
        {
            int i = conexao.ExecutaComandoInsert("Update vendas set " +
            "qtdItens = '" + QtdItens + "', " +
            "data = '" + Data + "', " +
            "idCliente = '" + IdCliente + "'," +
            "idProduto ='" + IdProduto + "'" +
            " WHERE idVenda = " + idVenda + "");
        }
        /// <summary>
        /// Rotina para Selecionar dados da tabela por Texto 
        /// </summary>
        /// <param name="campo"> campo de pesquisa</param>
        /// <param name="condicao">valor de pesquisa</param>
        public void SelecionaTipoTexto(string campo = "", string condicao = "", bool like = false)
        {
            string query = "SELECT * FROM vendas";
            if (condicao != "") query = "SELECT * FROM vendas WHERE " + campo + " = '" + condicao + "' ORDER BY idVenda, qtdItens";
            if (like) query = "SELECT * FROM vendas WHERE " + campo + " like '%" + condicao + "%' ORDER BY idVenda, qtdItens";

            NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

            while (reader.Read())
            {
                idVenda = (int)reader["idVenda"];
                QtdItens = (int)reader["qtdItens"];
                data =  Convert.ToDateTime( reader["data"].ToString());
                idCliente = (int)reader["idCliente"] ;
                idProduto = (int)reader["idProduto"];
            }
        }
        /// <summary>
        /// Rotina para Selecionar dados da tabela por numero inteiro 
        /// </summary>
        /// <param name="campo"> campo de pesquisa</param>
        /// <param name="condicao">valor de pesquisa</param>
        public void SelecionaTipoInt(string campo = "", int condicao = 0)
        {
            string query = "SELECT * FROM vendas";
            if (condicao != 0) query = "SELECT * FROM vendas WHERE " + campo + " = " + condicao + "";

            NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

            while (reader.Read())
            {
                idVenda = (int)reader["idVenda"];
                QtdItens = (int)reader["qtdItens"];
                data = Convert.ToDateTime(reader["data"].ToString());
                idCliente = (int)reader["idCliente"];
                idProduto = (int)reader["idProduto"];
            }
        }

        /// <summary>
        /// Rotina para Deletar Registro
        /// </summary>
        public void Deletar()
        {
            int i = conexao.ExecutaComandoDelete("DELETE FROM vendas WHERE idVenda = " + idVenda + ";");
        }
    }
}

