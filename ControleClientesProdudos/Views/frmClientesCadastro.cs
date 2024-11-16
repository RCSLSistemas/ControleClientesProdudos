﻿using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ControleClientesProdudos.Views
{
    public partial class frmClientesCadastro : Form
    {
        Clientes c = new Clientes();
        public frmClientesCadastro()
        {
            InitializeComponent();

        }
        private void CarregaCampos()
        {
            txtNome.Text = c.Nome;
            txtEndereco.Text = c.Endereco;
            mskTelefone.Text = c.Telefone;
            txtEmail.Text = c.Email;
        }
        private void LimpaCampos()
        {
            groupBox2.Enabled = true;
            txtNome.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            mskTelefone.Text = string.Empty;
            mskTelefone.Mask = "(99) 9 9999-9999";
            txtEmail.Text = string.Empty;
            txtNome.Focus();

        }

        private void Localiza()
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();

                string query = "select * from clientes";

                if (rdbTelefone.Checked && txtPesquisa.Text != string.Empty)
                    query = "select * from clientes WHERE telefone LIKE '%" + txtPesquisa.Text + "%'";

                if (rdbNome.Checked && txtPesquisa.Text != string.Empty)
                    query = "select * from clientes WHERE nome LIKE '%" + txtPesquisa.Text + "%'";

                NpgsqlDataReader reader = conexao.ExecutaComandoSelect(query);

                if (reader.HasRows)
                {
                    NpgsqlDataReader readers = conexao.ExecutaComandoSelect(query);
                    DataTable dt = new DataTable();
                    dt.Load(readers);
                    dgvClientes.DataSource = dt;
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

            if (mskTelefone.Text == "(  )       -")
            {
                MessageBox.Show("Informe o telefone!");
                mskTelefone.Focus();
                return;
            }

            c.Nome = txtNome.Text;
            c.Endereco = txtEndereco.Text;
            c.Telefone = mskTelefone.Text;
            c.Email = txtEmail.Text;
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

            if (mskTelefone.Text == "(  )       -")
            {
                MessageBox.Show("Informe o telefone!");
                mskTelefone.Focus();
                return;
            }

            c.Nome = txtNome.Text;
            c.Endereco = txtEndereco.Text;
            c.Telefone = mskTelefone.Text;
            c.Email = txtEmail.Text;

            c.Altera();
            c.SelecionaTipoInt("idCliente", c.IdCliente);
            CarregaCampos();
            rdbNome.Checked = true;
            txtPesquisa.Text = txtNome.Text;
            Localiza();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            c.Deletar();
            c.SelecionaTipoInt("idCliente", c.IdCliente);
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

        private void dgvClientes_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox2.Enabled = true;

                if (dgvClientes.CurrentCell != null && dgvClientes.CurrentCell.Value != null)
                {
                    {
                        c.IdCliente = (int)dgvClientes.CurrentCell.Value;
                        c.SelecionaTipoInt("idCliente", c.IdCliente);
                        CarregaCampos();
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}