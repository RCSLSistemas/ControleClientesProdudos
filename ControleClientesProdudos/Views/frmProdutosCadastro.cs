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
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleClientesProdudos.Views
{
    public partial class frmProdutosCadastro : Form
    {
        Produtos c = new Produtos();
        public frmProdutosCadastro()
        {
            InitializeComponent();

        }
        private void CarregaCampos()
        {
            txtNome.Text = c.Nome;
            txtDescricao.Text = c.Descricao;
            mskPreco.Text = c.Preco.ToString();
            txtEstoque.Text = c.Estoque.ToString();
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

            c.Nome = txtNome.Text;
            c.Descricao = txtDescricao.Text;
            c.Preco = double.Parse(mskPreco.Text.Replace(",", "."), CultureInfo.InvariantCulture);
            c.Estoque = Convert.ToInt32(txtEstoque.Text);
            c.Insere();
            c.SelecionaTipoTexto();
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

            c.Nome = txtNome.Text;
            c.Descricao = txtDescricao.Text;

            c.Preco =  double.Parse(mskPreco.Text.Replace(",","."), CultureInfo.InvariantCulture);

            c.Estoque = Convert.ToInt32(txtEstoque.Text);

            c.Altera();
            c.SelecionaTipoInt("idProduto", c.IdProduto);
            CarregaCampos();
            rdbNome.Checked = true;
            txtPesquisa.Text = txtNome.Text;
            Localiza();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            c.Deletar();
            c.SelecionaTipoInt("idProduto", c.IdProduto);
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
                        c.IdProduto = (int)dgvProdutos.CurrentCell.Value;
                        c.SelecionaTipoInt("idProduto", c.IdProduto);
                        CarregaCampos();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mskPreco1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
