namespace ControleClientesProdudos.View
{
    partial class mdiPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mnInicio = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnInicio});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(905, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // mnInicio
            // 
            this.mnInicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnClientes,
            this.toolStripSeparator3,
            this.mnProdutos,
            this.toolStripSeparator4,
            this.mnVendas,
            this.toolStripSeparator5,
            this.mnSair});
            this.mnInicio.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnInicio.Name = "mnInicio";
            this.mnInicio.Size = new System.Drawing.Size(48, 20);
            this.mnInicio.Text = "&Inicio";
            // 
            // mnClientes
            // 
            this.mnClientes.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnClientes.Name = "mnClientes";
            this.mnClientes.Size = new System.Drawing.Size(180, 22);
            this.mnClientes.Text = "&Clientes";
            this.mnClientes.Click += new System.EventHandler(this.mnClientesCad_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // mnProdutos
            // 
            this.mnProdutos.ImageTransparentColor = System.Drawing.Color.Black;
            this.mnProdutos.Name = "mnProdutos";
            this.mnProdutos.Size = new System.Drawing.Size(180, 22);
            this.mnProdutos.Text = "&Produtos";
            this.mnProdutos.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // mnVendas
            // 
            this.mnVendas.Name = "mnVendas";
            this.mnVendas.Size = new System.Drawing.Size(180, 22);
            this.mnVendas.Text = "&Vendas";
            this.mnVendas.Click += new System.EventHandler(this.mnVendas_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // mnSair
            // 
            this.mnSair.Name = "mnSair";
            this.mnSair.Size = new System.Drawing.Size(180, 22);
            this.mnSair.Text = "Sai&r";
            this.mnSair.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 569);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(905, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // mdiPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 591);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mdiPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem mnInicio;
        private System.Windows.Forms.ToolStripMenuItem mnClientes;
        private System.Windows.Forms.ToolStripMenuItem mnProdutos;
        private System.Windows.Forms.ToolStripMenuItem mnVendas;
        private System.Windows.Forms.ToolStripMenuItem mnSair;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}



