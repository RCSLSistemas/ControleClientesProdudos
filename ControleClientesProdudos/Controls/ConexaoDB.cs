using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration; //-> Com ele podemos acessar a ConnectionString criada no `App.config`
using Npgsql;

namespace ControleClientesProdudos.Controls
{
    public class ConexaoDB
    {
        public NpgsqlConnection ConectaBd()
        {
            string connectionString =
                "Host=localhost;" +
                "Port=5432;" +
                "Database=ControleClientesProdudos;" +
                "User Id=postgres;" +
                "Password=123456;";            
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();

            return connection;
        }

        public NpgsqlDataReader ExecutaComandoSelect(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, ConectaBd());

            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int ExecutaComandoInsert(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, ConectaBd());

            int rowsAffected = cmd.ExecuteNonQuery();

            return rowsAffected;
        }

        public int ExecutaComandoUpdate(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, ConectaBd());
 
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }

        public int ExecutaComandoDelete(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, ConectaBd());

            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }

    }
}