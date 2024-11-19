using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleClientesProdudos.Controls;
using ControleClientesProdudos.Models;
using ControleClientesProdudos.Relatorios;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace ControleClientesProdudos.Views
{
    public partial class frmVendasRealizadas : Form
    {
        Vendas c = new Vendas();

        DataTable dt = new DataTable();
        public frmVendasRealizadas()
        {
            InitializeComponent();

        }
        private void CarregaCampos()
        {

        }
   
        private void Localiza()
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();

                string query = "";

                if (rdbData.Checked)
                { 
                    query = "SELECT v.data data, c.nome cliente,   p.nome ||' - '|| p.descricao produto, sum(v.qtditens) qtd, sum(p.preco) total\n";	
                    query += "	FROM vendas v ";
                    query += "	INNER JOIN produtos p ON v.idproduto = p.idproduto \n";
                    query += "	INNER JOIN clientes c ON v.idcliente = c.idcliente \n";
                    query += "WHERE v.data between '" + dtpDataIni.Text + "' AND '" + dtpDataFim.Text + "' \n";
                    query += "GROUP BY\n";
                    query += "	v.data, c.nome, p.nome, p.descricao\n";
                    query += "ORDER BY \n";
                    query += " v.data";
                }
                if (rdbCliente.Checked )
                {
                    query = "SELECT v.data data, c.nome cliente,   p.nome ||' - '||p.descricao produto, sum(v.qtditens) qtd, sum(p.preco) total\n";
                    query += "	FROM vendas v \n";
                    query += "	INNER JOIN produtos p ON v.idproduto = p.idproduto \n";
                    query += "	INNER JOIN clientes c ON v.idcliente = c.idcliente \n";
                    query += "WHERE c.nome LIKE '%" + txtPesquisa.Text + "%'\n";
                    query += "GROUP BY\n";
                    query += "	v.data, c.nome, p.nome, p.descricao\n";
                    query += "ORDER BY \n";
                    query += "  c.nome\n";
                }


                NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

                if (reader.HasRows)
                {
                    NpgsqlDataReader readers = conexao.ExecutaComandoSelect(query);
                    DataTable dt = new DataTable();
                    dt.Load(readers);
                    dgvVendas.DataSource = dt;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString(), "Erro ao pesquisar!");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Localiza();
        }

        private void dgvVendas_Click(object sender, EventArgs e)
        {

            try
            {
                if (dgvVendas.CurrentCell != null && dgvVendas.CurrentCell.Value != null)
                {
                    {
                        c.IdProduto = (int)dgvVendas.CurrentCell.Value;
                        c.SelecionaTipoInt("idProduto", c.IdProduto);
                        CarregaCampos();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

  
        private void frmVendasRealizadas_Load(object sender, EventArgs e)
        {
            Localiza();
        }

        private void rdbData_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Visible = false;
            pnlData.Visible = true;
        }

        private void rdbCliente_CheckedChanged(object sender, EventArgs e)
        {
            txtPesquisa.Visible = true;
            pnlData.Visible = false;
        }

        private void lblDe_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            dt.Columns.Add("Data");
            dt.Columns.Add("NomeCliente");
            dt.Columns.Add("NomeProduto");
            dt.Columns.Add("QtdItens");
            dt.Columns.Add("ValorTotal");

            foreach (DataGridViewRow item in dgvVendas.Rows)
            {
                dt.Rows.Add(
                    item.Cells["data"].Value ,
                    item.Cells["cliente"].Value.ToString(),
                    item.Cells["produto"].Value.ToString(),
                    item.Cells["qtd"].Value.ToString(),
                    string.Format("{0:N}", item.Cells["total"].Value));
            }

            frmRelVendasRealizadas frmPesqCli = new frmRelVendasRealizadas(dt);
            frmPesqCli.ShowDialog(this);
        }
    }
}
