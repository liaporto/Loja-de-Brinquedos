namespace Loja_de_Brinquedos_IN204_Nº_22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnCadastroCliente = new System.Windows.Forms.Button();
            this.btnVisualizaCliente = new System.Windows.Forms.Button();
            this.btnCadastroProduto = new System.Windows.Forms.Button();
            this.btnVisualizaEstoque = new System.Windows.Forms.Button();
            this.btnRegistraVenda = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.Location = new System.Drawing.Point(3, 7);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Size = new System.Drawing.Size(108, 23);
            this.btnCadastroCliente.TabIndex = 2;
            this.btnCadastroCliente.Text = "Cadastrar Cliente";
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnVisualizaCliente
            // 
            this.btnVisualizaCliente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnVisualizaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizaCliente.Location = new System.Drawing.Point(3, 65);
            this.btnVisualizaCliente.Name = "btnVisualizaCliente";
            this.btnVisualizaCliente.Size = new System.Drawing.Size(108, 23);
            this.btnVisualizaCliente.TabIndex = 3;
            this.btnVisualizaCliente.Text = "Visualizar Cliente";
            this.btnVisualizaCliente.UseVisualStyleBackColor = false;
            this.btnVisualizaCliente.Click += new System.EventHandler(this.btnVisualizaCliente_Click);
            // 
            // btnCadastroProduto
            // 
            this.btnCadastroProduto.BackColor = System.Drawing.Color.Green;
            this.btnCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroProduto.Location = new System.Drawing.Point(3, 36);
            this.btnCadastroProduto.Name = "btnCadastroProduto";
            this.btnCadastroProduto.Size = new System.Drawing.Size(108, 23);
            this.btnCadastroProduto.TabIndex = 4;
            this.btnCadastroProduto.Text = "Cadastrar Produto";
            this.btnCadastroProduto.UseVisualStyleBackColor = false;
            this.btnCadastroProduto.Click += new System.EventHandler(this.btnCadastroProduto_Click);
            // 
            // btnVisualizaEstoque
            // 
            this.btnVisualizaEstoque.BackColor = System.Drawing.Color.Gold;
            this.btnVisualizaEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizaEstoque.Location = new System.Drawing.Point(3, 94);
            this.btnVisualizaEstoque.Name = "btnVisualizaEstoque";
            this.btnVisualizaEstoque.Size = new System.Drawing.Size(108, 23);
            this.btnVisualizaEstoque.TabIndex = 5;
            this.btnVisualizaEstoque.Text = "Visualizar Estoque";
            this.btnVisualizaEstoque.UseVisualStyleBackColor = false;
            this.btnVisualizaEstoque.Click += new System.EventHandler(this.btnVisualizaEstoque_Click);
            // 
            // btnRegistraVenda
            // 
            this.btnRegistraVenda.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRegistraVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraVenda.Location = new System.Drawing.Point(3, 123);
            this.btnRegistraVenda.Name = "btnRegistraVenda";
            this.btnRegistraVenda.Size = new System.Drawing.Size(108, 23);
            this.btnRegistraVenda.TabIndex = 6;
            this.btnRegistraVenda.Text = "Registrar Venda";
            this.btnRegistraVenda.UseVisualStyleBackColor = false;
            this.btnRegistraVenda.Click += new System.EventHandler(this.btnRegistraVenda_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Gold;
            this.flowLayoutPanel1.Controls.Add(this.btnCadastroCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnCadastroProduto);
            this.flowLayoutPanel1.Controls.Add(this.btnVisualizaCliente);
            this.flowLayoutPanel1.Controls.Add(this.btnVisualizaEstoque);
            this.flowLayoutPanel1.Controls.Add(this.btnRegistraVenda);
            this.flowLayoutPanel1.Controls.Add(this.btnRelatorio);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(202, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(115, 194);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Location = new System.Drawing.Point(3, 152);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(108, 23);
            this.btnRelatorio.TabIndex = 8;
            this.btnRelatorio.Text = "Gerar Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Harlow Solid Italic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(81, 40);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(28, 3, 23, 3);
            this.label2.Size = new System.Drawing.Size(358, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Empório dos Brinquedos ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(10)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nº 22, Turma IN204";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_yellow;
            this.ClientSize = new System.Drawing.Size(522, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmInicio";
            this.Text = "Página Inicial";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroCliente;
        private System.Windows.Forms.Button btnVisualizaCliente;
        private System.Windows.Forms.Button btnCadastroProduto;
        private System.Windows.Forms.Button btnVisualizaEstoque;
        private System.Windows.Forms.Button btnRegistraVenda;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Label label1;
    }
}

