using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleClientesProdudos.Controls;
using ControleClientesProdudos.Models;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleClientesProdudos.Views
{
    public partial class frmVendasCadastro : Form
    {
        Vendas v = new Vendas();
        Produtos p = new Produtos();
        Double total = 0;
        int totalQtd = 0;

        public frmVendasCadastro()
        {
            InitializeComponent();

        }
        private void AdicionaValores()
        {
            Double valor;
            int qtd;

            if (txtCliente.Text == string.Empty)
            {
                MessageBox.Show("Informe o cliente!");
                txtCliente.Text = "";
                btnPesquisaCliente.Focus();
                return;
            }

            if (txtQuantidade.Text == string.Empty)
            {
                MessageBox.Show("Informe a quantidade!");
                txtQuantidade.Text = "1";
                txtQuantidade.Focus();
                return;
            }

            if (p.Estoque < Convert.ToInt32(txtQuantidade.Text)  )
            {
                MessageBox.Show("Verifique a quantidade do Estoque!");
                txtQuantidade.Text =  "";
                txtQuantidade.Focus();
                return;
            }

            valor = (Convert.ToInt32(txtQuantidade.Text) * p.Preco);
            qtd = Convert.ToInt32(txtQuantidade.Text);

            totalQtd = totalQtd + qtd;
            mskTotalQtd.Text = totalQtd.ToString();


            total = total + valor;
            mskTotal.Text =  string.Format("{0:N}", total);

            dgvVendas.Rows.Add("", p.Nome, p.Descricao, txtQuantidade.Text, valor, DateTime.Now,v.IdCliente,p.IdProduto);
        }

        private void RemoveValores()
        {
            Double valor;
            int qtd;
            try
            {
                if (dgvVendas.CurrentRow != null)
                {
                    qtd = Convert.ToInt32(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[3].Value);
                    totalQtd = qtd - qtd;

                    valor = Convert.ToDouble(dgvVendas.Rows[dgvVendas.CurrentRow.Index].Cells[4].Value);
                    total = total - valor;
                    
                    dgvVendas.Rows.RemoveAt(dgvVendas.CurrentRow.Index);
                }
                else
                {
                    total = 0;
                    valor = 0;
                    totalQtd = 0;
                    qtd = 0;
                }
                mskTotalQtd.Text = totalQtd.ToString();
                mskTotal.Text = total.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void LimpaCampos()
        {
            //dgvVendas.CancelEdit();
            //dgvVendas.Columns.Clear();
            dgvVendas.DataSource = null;
            mskTotalQtd.Text = string.Empty;
            mskTotalQtd.Text = string.Empty;
            txtCliente.Text = string.Empty;
            btnPesquisaCliente.Focus();

        }

        private void LocalizaVendas()
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();

                string query = "select * from Vendas";

                // if (rdbData.Checked && txtCliente.Text != string.Empty)
                //query = "select * from Vendas WHERE telefone LIKE '%" + txtCliente.Text + "%'";

                // if (rdbCliente.Checked && txtCliente.Text != string.Empty)
                //query = "select * from Vendas WHERE nome LIKE '%" + txtCliente.Text + "%'";

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

        private void LocalizaProdutos()
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();

                string query = "select * from Produtos";

                if (rdbDescricao.Checked && txtPesquisaProduto.Text != string.Empty)
                    query = "select * from Produtos WHERE descricao LIKE '%" + txtPesquisaProduto.Text + "%'";

                if (rdbNomeProduto.Checked && txtPesquisaProduto.Text != string.Empty)
                    query = "select * from Produtos WHERE nome LIKE '%" + txtPesquisaProduto.Text + "%'";

                NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

                if (reader.HasRows)
                {
                    NpgsqlDataReader readers = conexao.ExecutaComandoSelect(query);
                    DataTable dt = new DataTable();
                    dt.Load(readers);
                    dgvProdutos.DataSource = dt;
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

            frmClientesCadastro frmPesqCli = new frmClientesCadastro();

            frmPesqCli.ShowDialog(this);
            v.IdCliente = frmPesqCli.CodCliente;
            v.NomeCliente = frmPesqCli.noCliente;

            txtCliente.Text = v.NomeCliente;
        }

        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {
            LocalizaProdutos();
        }


        private void LocalizaProdutos(object sender, EventArgs e)
        {
            LocalizaProdutos();
        }

        private void frmVendasCadastro_Load(object sender, EventArgs e)
        {
            LocalizaProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            AdicionaValores();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }


        private void dgvProdutos_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;

            try
            {
                if (dgvProdutos.CurrentCell != null && dgvProdutos.CurrentCell.Value != null)
                {
                    {
                        p.IdProduto = (int)dgvProdutos.CurrentCell.Value;
                        p.SelecionaTipoInt("idProduto", p.IdProduto);
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            RemoveValores();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            frmProdutosCadastro frmPesqCli = new frmProdutosCadastro();
            frmPesqCli.ShowDialog(this);
            LocalizaProdutos();
        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvVendas.Rows)
            {
                v.Data = Convert.ToDateTime(row.Cells["data"].Value);
                v.QtdItens = Convert.ToInt32( row.Cells["qtdItens"].Value);
                v.IdCliente = (int)row.Cells["idCliente"].Value;
                v.IdProduto = (int)row.Cells["idProdutos"].Value;
                v.Insere();
                p.AlteraEstoque(v.QtdItens);
                dgvVendas.Rows.RemoveAt(row.Index);
            }
            LimpaCampos();
        }

        private void btnVendasRealizadas_Click(object sender, EventArgs e)
        {
            frmVendasRealizadas frmPesqCli = new frmVendasRealizadas();

            frmPesqCli.ShowDialog(this);
        }
    }
}
