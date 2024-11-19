namespace ControleClientesProdudos.Views
{
    partial class frmVendasRealizadas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.lblAte = new System.Windows.Forms.Label();
            this.dtpDataIni = new System.Windows.Forms.DateTimePicker();
            this.lblDe = new System.Windows.Forms.Label();
            this.dtpDataFim = new System.Windows.Forms.DateTimePicker();
            this.btnPesquisa = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.gpbTipoBusca = new System.Windows.Forms.GroupBox();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbData = new System.Windows.Forms.RadioButton();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.gpbTipoBusca.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnFechar);
            this.panel1.Location = new System.Drawing.Point(8, 313);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 48);
            this.panel1.TabIndex = 8;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(409, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 32);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(508, 10);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(93, 32);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gpbTipoBusca);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 69);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pnlData);
            this.groupBox3.Controls.Add(this.btnPesquisa);
            this.groupBox3.Controls.Add(this.txtPesquisa);
            this.groupBox3.Location = new System.Drawing.Point(159, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(445, 48);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cliente ou Data";
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.lblAte);
            this.pnlData.Controls.Add(this.dtpDataIni);
            this.pnlData.Controls.Add(this.lblDe);
            this.pnlData.Controls.Add(this.dtpDataFim);
            this.pnlData.Location = new System.Drawing.Point(6, 14);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(255, 23);
            this.pnlData.TabIndex = 11;
            this.pnlData.Visible = false;
            // 
            // lblAte
            // 
            this.lblAte.AutoSize = true;
            this.lblAte.Location = new System.Drawing.Point(127, 5);
            this.lblAte.Name = "lblAte";
            this.lblAte.Size = new System.Drawing.Size(22, 13);
            this.lblAte.TabIndex = 10;
            this.lblAte.Text = "até";
            // 
            // dtpDataIni
            // 
            this.dtpDataIni.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataIni.Location = new System.Drawing.Point(27, 0);
            this.dtpDataIni.Name = "dtpDataIni";
            this.dtpDataIni.Size = new System.Drawing.Size(94, 20);
            this.dtpDataIni.TabIndex = 7;
            this.dtpDataIni.Value = new System.DateTime(2024, 11, 18, 0, 0, 0, 0);
            // 
            // lblDe
            // 
            this.lblDe.AutoSize = true;
            this.lblDe.Location = new System.Drawing.Point(3, 1);
            this.lblDe.Name = "lblDe";
            this.lblDe.Size = new System.Drawing.Size(21, 13);
            this.lblDe.TabIndex = 9;
            this.lblDe.Text = "De";
            this.lblDe.Click += new System.EventHandler(this.lblDe_Click);
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.Location = new System.Drawing.Point(154, 0);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.Size = new System.Drawing.Size(94, 20);
            this.dtpDataFim.TabIndex = 8;
            this.dtpDataFim.Value = new System.DateTime(2024, 11, 18, 0, 0, 0, 0);
            // 
            // btnPesquisa
            // 
            this.btnPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisa.Location = new System.Drawing.Point(337, 16);
            this.btnPesquisa.Name = "btnPesquisa";
            this.btnPesquisa.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisa.TabIndex = 6;
            this.btnPesquisa.Text = "&Pesquisar";
            this.btnPesquisa.UseVisualStyleBackColor = true;
            this.btnPesquisa.Click += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(6, 16);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(250, 20);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.btnPesquisa_Click);
            // 
            // gpbTipoBusca
            // 
            this.gpbTipoBusca.Controls.Add(this.rdbCliente);
            this.gpbTipoBusca.Controls.Add(this.rdbData);
            this.gpbTipoBusca.Location = new System.Drawing.Point(7, 13);
            this.gpbTipoBusca.Name = "gpbTipoBusca";
            this.gpbTipoBusca.Size = new System.Drawing.Size(146, 47);
            this.gpbTipoBusca.TabIndex = 3;
            this.gpbTipoBusca.TabStop = false;
            this.gpbTipoBusca.Text = "Tipo de Busca";
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Checked = true;
            this.rdbCliente.Location = new System.Drawing.Point(6, 20);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente.TabIndex = 1;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.CheckedChanged += new System.EventHandler(this.rdbCliente_CheckedChanged);
            // 
            // rdbData
            // 
            this.rdbData.AutoSize = true;
            this.rdbData.Location = new System.Drawing.Point(67, 20);
            this.rdbData.Name = "rdbData";
            this.rdbData.Size = new System.Drawing.Size(48, 17);
            this.rdbData.TabIndex = 0;
            this.rdbData.Text = "Data";
            this.rdbData.UseVisualStyleBackColor = true;
            this.rdbData.CheckedChanged += new System.EventHandler(this.rdbData_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.dgvVendas);
            this.groupBox9.Location = new System.Drawing.Point(8, 79);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(617, 228);
            this.groupBox9.TabIndex = 12;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Itens";
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.cliente,
            this.produto,
            this.qtd,
            this.total});
            this.dgvVendas.Location = new System.Drawing.Point(9, 19);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.Size = new System.Drawing.Size(602, 200);
            this.dgvVendas.TabIndex = 2;
            // 
            // data
            // 
            this.data.DataPropertyName = "data";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.data.DefaultCellStyle = dataGridViewCellStyle1;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            this.data.ReadOnly = true;
            this.data.Width = 70;
            // 
            // cliente
            // 
            this.cliente.DataPropertyName = "cliente";
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            this.cliente.Width = 150;
            // 
            // produto
            // 
            this.produto.DataPropertyName = "produto";
            this.produto.HeaderText = "Produto";
            this.produto.Name = "produto";
            this.produto.ReadOnly = true;
            this.produto.Width = 200;
            // 
            // qtd
            // 
            this.qtd.DataPropertyName = "qtd";
            this.qtd.HeaderText = "Qtde";
            this.qtd.Name = "qtd";
            this.qtd.ReadOnly = true;
            this.qtd.Width = 50;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = "0";
            this.total.DefaultCellStyle = dataGridViewCellStyle2;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 70;
            // 
            // frmVendasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 367);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVendasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas Realizadas";
            this.Load += new System.EventHandler(this.frmVendasRealizadas_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            this.gpbTipoBusca.ResumeLayout(false);
            this.gpbTipoBusca.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.GroupBox gpbTipoBusca;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFechar;
        public System.Windows.Forms.Button btnPesquisa;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.DateTimePicker dtpDataIni;
        private System.Windows.Forms.Label lblAte;
        private System.Windows.Forms.Label lblDe;
        private System.Windows.Forms.DateTimePicker dtpDataFim;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}