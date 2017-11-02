namespace Loja_de_Brinquedos___IN204__Nº_22
{
    partial class frmInicio
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
            this.mstrpMenu = new System.Windows.Forms.MenuStrip();
            this.cadastrarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarVendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstrpMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstrpMenu
            // 
            this.mstrpMenu.Dock = System.Windows.Forms.DockStyle.None;
            this.mstrpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarClienteToolStripMenuItem,
            this.cadastrarProdutoToolStripMenuItem,
            this.registrarVendaToolStripMenuItem});
            this.mstrpMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mstrpMenu.Location = new System.Drawing.Point(0, -1);
            this.mstrpMenu.Name = "mstrpMenu";
            this.mstrpMenu.Size = new System.Drawing.Size(322, 24);
            this.mstrpMenu.TabIndex = 0;
            this.mstrpMenu.Text = "mstrpMenu";
            this.mstrpMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // cadastrarClienteToolStripMenuItem
            // 
            this.cadastrarClienteToolStripMenuItem.Name = "cadastrarClienteToolStripMenuItem";
            this.cadastrarClienteToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.cadastrarClienteToolStripMenuItem.Text = "Cadastrar Cliente";
            this.cadastrarClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarClienteToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem1,
            this.visualizarEstoqueToolStripMenuItem});
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cadastrarProdutoToolStripMenuItem.Text = "Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // registrarVendaToolStripMenuItem
            // 
            this.registrarVendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendaToolStripMenuItem1,
            this.históricoDeVendasToolStripMenuItem});
            this.registrarVendaToolStripMenuItem.Name = "registrarVendaToolStripMenuItem";
            this.registrarVendaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.registrarVendaToolStripMenuItem.Text = "Venda";
            this.registrarVendaToolStripMenuItem.Click += new System.EventHandler(this.registrarVendaToolStripMenuItem_Click);
            // 
            // cadastrarProdutoToolStripMenuItem1
            // 
            this.cadastrarProdutoToolStripMenuItem1.Name = "cadastrarProdutoToolStripMenuItem1";
            this.cadastrarProdutoToolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.cadastrarProdutoToolStripMenuItem1.Text = "Cadastrar Produto";
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            this.visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            this.visualizarEstoqueToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.visualizarEstoqueToolStripMenuItem.Text = "Visualizar Estoque";
            // 
            // registrarVendaToolStripMenuItem1
            // 
            this.registrarVendaToolStripMenuItem1.Name = "registrarVendaToolStripMenuItem1";
            this.registrarVendaToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.registrarVendaToolStripMenuItem1.Text = "Registrar Venda";
            // 
            // históricoDeVendasToolStripMenuItem
            // 
            this.históricoDeVendasToolStripMenuItem.Name = "históricoDeVendasToolStripMenuItem";
            this.históricoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.históricoDeVendasToolStripMenuItem.Text = "Histórico de Vendas";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 261);
            this.Controls.Add(this.mstrpMenu);
            this.MainMenuStrip = this.mstrpMenu;
            this.Name = "frmInicio";
            this.Text = "Página Inicial";
            this.mstrpMenu.ResumeLayout(false);
            this.mstrpMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstrpMenu;
        private System.Windows.Forms.ToolStripMenuItem cadastrarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem visualizarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem históricoDeVendasToolStripMenuItem;
    }
}

