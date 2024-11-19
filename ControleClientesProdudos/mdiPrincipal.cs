using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleClientesProdudos.Views;
using ControleClientesProdudos.Relatorios;

namespace ControleClientesProdudos.View
{
    public partial class mdiPrincipal : Form
    {
        public mdiPrincipal()
        {
            InitializeComponent();
        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void mnVendas_Click(object sender, EventArgs e)
        {
            frmVendasCadastro frmVendas = new frmVendasCadastro();
            frmVendas.ShowDialog(this);
        }

        private void mnProdutos_Click(object sender, EventArgs e)
        {
            frmProdutosCadastro frmPesqProd = new frmProdutosCadastro();
            frmPesqProd.ShowDialog(this);
        }

        private void mnClientes_Click(object sender, EventArgs e)
        {
            frmClientesCadastro frmPesqCli = new frmClientesCadastro();
            frmPesqCli.ShowDialog(this);
        }
    }
}
