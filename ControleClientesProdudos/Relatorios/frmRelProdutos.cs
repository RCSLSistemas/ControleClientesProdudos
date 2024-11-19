﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleClientesProdudos.Relatorios
{
    public partial class frmRelProdutos : Form
    {
        DataTable dt = new DataTable();

        public frmRelProdutos(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frmRelProdutos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }
    }
}
