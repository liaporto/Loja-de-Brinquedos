namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class AlterarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbFaixaEt = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categoria:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(22, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbCategoria);
            this.groupBox1.Controls.Add(this.cmbFaixaEt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 325);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar dados:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(22, 290);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(121, 20);
            this.txtMarca.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Marca:";
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
            this.cmbCategoria.Location = new System.Drawing.Point(22, 128);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
            this.cmbCategoria.TabIndex = 6;
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
            this.cmbFaixaEt.Location = new System.Drawing.Point(22, 210);
            this.cmbFaixaEt.Name = "cmbFaixaEt";
            this.cmbFaixaEt.Size = new System.Drawing.Size(121, 21);
            this.cmbFaixaEt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Faixa Etária:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.nudQtd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDataVenda);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(226, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 200);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atualizar Estoque:";
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(22, 128);
            this.nudQtd.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(114, 20);
            this.nudQtd.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Quantidade atual:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(22, 49);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(114, 20);
            this.dtpDataVenda.TabIndex = 25;
            this.dtpDataVenda.ValueChanged += new System.EventHandler(this.dtpDataVenda_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data da última aquisição:";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackColor = System.Drawing.Color.Gold;
            this.btnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualiza.Location = new System.Drawing.Point(302, 279);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(96, 22);
            this.btnAtualiza.TabIndex = 8;
            this.btnAtualiza.Text = "Atualizar Dados";
            this.btnAtualiza.UseVisualStyleBackColor = false;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.BackColor = System.Drawing.Color.Gold;
            this.btnDeleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleta.Location = new System.Drawing.Point(302, 329);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(96, 22);
            this.btnDeleta.TabIndex = 9;
            this.btnDeleta.Text = "Deletar Produto";
            this.btnDeleta.UseVisualStyleBackColor = false;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // AlterarProduto
            // 
            this.AcceptButton = this.btnAtualiza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_yellow_form2;
            this.ClientSize = new System.Drawing.Size(424, 376);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnAtualiza);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarProduto";
            this.Text = "Alterar Produto";
            this.Load += new System.EventHandler(this.AlterarProduto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbFaixaEt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeleta;
    }
}