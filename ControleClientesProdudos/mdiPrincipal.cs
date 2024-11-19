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

 
        private void mnClientesCad_Click(object sender, EventArgs e)
        {
            frmClientesCadastro frmPesqCli = new frmClientesCadastro();
            frmPesqCli.ShowDialog(this);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProdutosCadastro frmPesqCli = new frmProdutosCadastro();
            frmPesqCli.ShowDialog(this);
        }

        private void mnVendas_Click(object sender, EventArgs e)
        {
            frmVendasCadastro frmPesqCli = new frmVendasCadastro();
            frmPesqCli.ShowDialog(this);
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            frmRelVendasRealizadas frmPesqCli = new frmRelVendasRealizadas(dt);
            frmPesqCli.ShowDialog(this);
        }
    }
}
