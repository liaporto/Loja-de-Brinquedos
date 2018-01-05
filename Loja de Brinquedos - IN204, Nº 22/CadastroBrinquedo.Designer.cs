namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class frmCadastroBrinq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroBrinq));
            this.txtNomeBrinq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbFaixaEt = new System.Windows.Forms.ComboBox();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudQtdEstoque = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.gpbEstoque = new System.Windows.Forms.GroupBox();
            this.BtnCadastraBrinq = new System.Windows.Forms.Button();
            this.dtpDataAq = new System.Windows.Forms.DateTimePicker();
            this.gpbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEstoque)).BeginInit();
            this.gpbEstoque.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNomeBrinq
            // 
            this.txtNomeBrinq.Location = new System.Drawing.Point(133, 43);
            this.txtNomeBrinq.Name = "txtNomeBrinq";
            this.txtNomeBrinq.Size = new System.Drawing.Size(126, 20);
            this.txtNomeBrinq.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Brinquedo:*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Categoria:*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faixa Etária:*";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Jogos de Tabuleiro",
            "Automóveis",
            "Bonecos",
            "Ar Livre",
            "Blocos de Montar",
            "Pelúcias",
            "Fantasias",
            "Primeira Infância",
            "Quebra-Cabeças",
            "Artes e Atividades",
            "Eletrônicos"});
            this.cmbCategoria.Location = new System.Drawing.Point(133, 96);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(126, 21);
            this.cmbCategoria.TabIndex = 4;
            // 
            // cmbFaixaEt
            // 
            this.cmbFaixaEt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaixaEt.FormattingEnabled = true;
            this.cmbFaixaEt.Items.AddRange(new object[] {
            "0-3",
            "4-6",
            "7-9",
            "10-13",
            "14+",
            "Para toda a família"});
            this.cmbFaixaEt.Location = new System.Drawing.Point(133, 145);
            this.cmbFaixaEt.Name = "cmbFaixaEt";
            this.cmbFaixaEt.Size = new System.Drawing.Size(126, 21);
            this.cmbFaixaEt.TabIndex = 5;
            this.cmbFaixaEt.SelectedIndexChanged += new System.EventHandler(this.cmbFaixaEt_SelectedIndexChanged);
            // 
            // gpbDados
            // 
            this.gpbDados.BackColor = System.Drawing.Color.ForestGreen;
            this.gpbDados.Controls.Add(this.txtMarca);
            this.gpbDados.Controls.Add(this.label4);
            this.gpbDados.Controls.Add(this.cmbFaixaEt);
            this.gpbDados.Controls.Add(this.cmbCategoria);
            this.gpbDados.Controls.Add(this.label3);
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.txtNomeBrinq);
            this.gpbDados.Location = new System.Drawing.Point(24, 25);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(276, 250);
            this.gpbDados.TabIndex = 6;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados do Produto";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(133, 197);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(126, 20);
            this.txtMarca.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Marca:*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Data da Aquisição:*";
            // 
            // nudQtdEstoque
            // 
            this.nudQtdEstoque.Location = new System.Drawing.Point(112, 83);
            this.nudQtdEstoque.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQtdEstoque.Name = "nudQtdEstoque";
            this.nudQtdEstoque.Size = new System.Drawing.Size(132, 20);
            this.nudQtdEstoque.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade:*";
            // 
            // gpbEstoque
            // 
            this.gpbEstoque.BackColor = System.Drawing.Color.ForestGreen;
            this.gpbEstoque.Controls.Add(this.dtpDataAq);
            this.gpbEstoque.Controls.Add(this.label6);
            this.gpbEstoque.Controls.Add(this.nudQtdEstoque);
            this.gpbEstoque.Controls.Add(this.label5);
            this.gpbEstoque.Location = new System.Drawing.Point(323, 25);
            this.gpbEstoque.Name = "gpbEstoque";
            this.gpbEstoque.Size = new System.Drawing.Size(328, 152);
            this.gpbEstoque.TabIndex = 13;
            this.gpbEstoque.TabStop = false;
            this.gpbEstoque.Text = "Dados de Estoque";
            // 
            // BtnCadastraBrinq
            // 
            this.BtnCadastraBrinq.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnCadastraBrinq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCadastraBrinq.Location = new System.Drawing.Point(553, 252);
            this.BtnCadastraBrinq.Name = "BtnCadastraBrinq";
            this.BtnCadastraBrinq.Size = new System.Drawing.Size(98, 23);
            this.BtnCadastraBrinq.TabIndex = 14;
            this.BtnCadastraBrinq.Text = "Confirmar";
            this.BtnCadastraBrinq.UseVisualStyleBackColor = false;
            this.BtnCadastraBrinq.Click += new System.EventHandler(this.btnCadastraBrinq_Click);
            // 
            // dtpDataAq
            // 
            this.dtpDataAq.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAq.Location = new System.Drawing.Point(112, 43);
            this.dtpDataAq.Name = "dtpDataAq";
            this.dtpDataAq.Size = new System.Drawing.Size(132, 20);
            this.dtpDataAq.TabIndex = 26;
            this.dtpDataAq.ValueChanged += new System.EventHandler(this.dtpDataVenda_ValueChanged);
            // 
            // frmCadastroBrinq
            // 
            this.AcceptButton = this.BtnCadastraBrinq;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_green_2;
            this.ClientSize = new System.Drawing.Size(675, 303);
            this.Controls.Add(this.BtnCadastraBrinq);
            this.Controls.Add(this.gpbEstoque);
            this.Controls.Add(this.gpbDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroBrinq";
            this.Text = "Cadastrar Brinquedo";
            this.Load += new System.EventHandler(this.CadastroBrinquedo_Load);
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtdEstoque)).EndInit();
            this.gpbEstoque.ResumeLayout(false);
            this.gpbEstoque.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeBrinq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbFaixaEt;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudQtdEstoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpbEstoque;
        private System.Windows.Forms.Button BtnCadastraBrinq;
        private System.Windows.Forms.DateTimePicker dtpDataAq;
    }
}