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
    public partial class frmProdutosCadastro : Form
    {
        Produtos p = new Produtos();
        DataTable dt = new DataTable();
        public frmProdutosCadastro()
        {
            InitializeComponent();

        }
        private void CarregaCampos()
        {
            txtNome.Text = p.Nome;
            txtDescricao.Text = p.Descricao;
            mskPreco.Text = p.Preco.ToString();
            txtEstoque.Text = p.Estoque.ToString();
        }
        private void LimpaCampos()
        {
            groupBox2.Enabled = true;
            txtNome.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            mskPreco.Text = string.Empty;
            mskPreco.Mask = "";
            txtEstoque.Text = string.Empty;
            txtNome.Focus();
        }

        private void Localiza()
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();

                string query = "select * from Produtos";

                if (rdbDescricao.Checked && txtPesquisa.Text != string.Empty)
                    query = "select * from Produtos WHERE descricao LIKE '%" + txtPesquisa.Text + "%'";

                if (rdbNome.Checked && txtPesquisa.Text != string.Empty)
                    query = "select * from Produtos WHERE nome LIKE '%" + txtPesquisa.Text + "%'";

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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome!");
                txtNome.Focus();
                return;
            }

            if (mskPreco.Text == "(  )       -")
            {
                MessageBox.Show("Informe o telefone!");
                mskPreco.Focus();
                return;
            }

            p.Nome = txtNome.Text;
            p.Descricao = txtDescricao.Text;
            p.Preco = double.Parse(mskPreco.Text.Replace(",", "."), CultureInfo.InvariantCulture);
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Insere();
            p.SelecionaTipoTexto();
            btnIncluir.Enabled = false;
            rdbNome.Checked = true;
            txtPesquisa.Text = txtNome.Text;
            Localiza();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text == string.Empty)
            {
                MessageBox.Show("Informe o Nome!");
                txtNome.Focus();
                return;
            }

            if (mskPreco.Text == "(  )       -")
            {
                MessageBox.Show("Informe a Descrição!");
                mskPreco.Focus();
                return;
            }

            p.Nome = txtNome.Text;
            p.Descricao = txtDescricao.Text;

            p.Preco =  double.Parse(mskPreco.Text.Replace(",","."), CultureInfo.InvariantCulture);

            p.Estoque = Convert.ToInt32(txtEstoque.Text);

            p.Altera();
            p.SelecionaTipoInt("idProduto", p.IdProduto);
            CarregaCampos();
            rdbNome.Checked = true;
            txtPesquisa.Text = txtNome.Text;
            Localiza();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            p.Deletar();
            p.SelecionaTipoInt("idProduto", p.IdProduto);
            Localiza();
        }


        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            Localiza();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            btnIncluir.Enabled = true;
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
                        CarregaCampos();
                    }
                }
            }
            catch (Exception)
            {

            }
        }
 
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            dt.Columns.Add("Nome");
            dt.Columns.Add("Descricao");
            dt.Columns.Add("Preco");
            dt.Columns.Add("Estoque");


            foreach (DataGridViewRow item in dgvProdutos.Rows)
            {
                dt.Rows.Add(item.Cells["nome"].Value.ToString(),
                    item.Cells["descricao"].Value.ToString(),
                    string.Format("{0:N}", item.Cells["preco"].Value.ToString()),
                    item.Cells["estoque"].Value.ToString());

            }

            frmRelProdutos relProduto = new frmRelProdutos(dt);
            relProduto.ShowDialog(this);
        }

        private void frmProdutosCadastro_Load(object sender, EventArgs e)
        {
            Localiza();
        }
    }
}
