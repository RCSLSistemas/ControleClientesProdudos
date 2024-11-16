using ControleClientesProdudos.Controls;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientesProdudos.Models
{
    public class Clientes
    {
        ConexaoDB conexao = new ConexaoDB();
        private int idCliente;
        private string nome;
        private string endereco;
        private string telefone;
        private string email;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }

        /// <summary>
        /// Rotina para Inserir dados
        /// </summary>
        public void Insere()
        {
            int i = conexao.ExecutaComandoInsert("INSERT INTO  clientes(nome, endereco, telefone, email) " +
            "VALUES ( '" + Nome +
            "', '" + Endereco +
            "', '" + Telefone +
            "', '" + Email +
            "');");
        }
        /// <summary>
        /// Rotina para Alterar Registro
        /// </summary>
        public void Altera()
        {
            int i = conexao.ExecutaComandoInsert("Update clientes set " +
            "nome = '" + Nome + "', " +
            "endereco = '" + Endereco + "', " +
            "telefone = '" + Telefone + "'," +
            "email ='" + Email + "'" +
            " WHERE idCliente = " + idCliente + "");
        }
        /// <summary>
        /// Rotina para Selecionar dados da tabela por Texto 
        /// </summary>
        /// <param name="campo"> campo de pesquisa</param>
        /// <param name="condicao">valor de pesquisa</param>
        public void SelecionaTipoTexto(string campo ="",string condicao = "", bool like = false )
        {
            string query = "SELECT * FROM clientes";
            if (condicao != "") query = "SELECT * FROM clientes WHERE " + campo + " = '" +  condicao + "' ORDER BY idCliente, nome";
            if (like) query = "SELECT * FROM clientes WHERE " + campo + " like '%" + condicao + "%' ORDER BY idCliente, nome";

            NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

            while (reader.Read())
            {
                idCliente =  (int)reader["idCliente"];
                Nome = reader["nome"].ToString().Trim();
                endereco = reader["endereco"].ToString().Trim();
                telefone = reader["telefone"].ToString().Trim();
                email = reader["email"].ToString().Trim();
            }  
        }
        /// <summary>
        /// Rotina para Selecionar dados da tabela por numero inteiro 
        /// </summary>
        /// <param name="campo"> campo de pesquisa</param>
        /// <param name="condicao">valor de pesquisa</param>
        public void SelecionaTipoInt(string campo = "", int condicao = 0)
        {
            string query = "SELECT * FROM clientes";
            if (condicao != 0) query = "SELECT * FROM clientes WHERE " + campo + " = " + condicao + "";

            NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

            while (reader.Read())
            {
                idCliente = (int)reader["idCliente"];
                Nome = reader["nome"].ToString().Trim();
                endereco = reader["endereco"].ToString().Trim();
                telefone = reader["telefone"].ToString().Trim();
                email = reader["email"].ToString().Trim();
            }
        }

        /// <summary>
        /// Rotina para Deletar Registro
        /// </summary>
        public void Deletar()
        {
            int i = conexao.ExecutaComandoDelete("DELETE FROM clientes WHERE idCliente = " + idCliente + ";");
        }
    }
}
