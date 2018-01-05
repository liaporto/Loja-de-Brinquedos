namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.txtLetraCliente = new System.Windows.Forms.TextBox();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmaVenda = new System.Windows.Forms.Button();
            this.btnPesquisaCPF = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnPesquisaNomeBrinq = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.cmbNomeProduto = new System.Windows.Forms.ComboBox();
            this.btnPesquisaCod = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbProdutos = new System.Windows.Forms.ListBox();
            this.btnAdiciona = new System.Windows.Forms.Button();
            this.nudQtd = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            this.gbxProduto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).BeginInit();
            this.gbxCliente.SuspendLayout();
            this.gbxProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeCliente.FormattingEnabled = true;
            this.cmbNomeCliente.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cmbNomeCliente.Location = new System.Drawing.Point(14, 57);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(169, 21);
            this.cmbNomeCliente.TabIndex = 1;
            this.cmbNomeCliente.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtLetraCliente
            // 
            this.txtLetraCliente.Location = new System.Drawing.Point(15, 30);
            this.txtLetraCliente.Name = "txtLetraCliente";
            this.txtLetraCliente.Size = new System.Drawing.Size(39, 20);
            this.txtLetraCliente.TabIndex = 2;
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisaNome.Location = new System.Drawing.Point(60, 28);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisaNome.TabIndex = 3;
            this.btnPesquisaNome.Text = "Pesquisar por nome";
            this.btnPesquisaNome.UseVisualStyleBackColor = true;
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data da Venda:";
            // 
            // btnConfirmaVenda
            // 
            this.btnConfirmaVenda.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirmaVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmaVenda.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConfirmaVenda.Location = new System.Drawing.Point(476, 301);
            this.btnConfirmaVenda.Name = "btnConfirmaVenda";
            this.btnConfirmaVenda.Size = new System.Drawing.Size(100, 49);
            this.btnConfirmaVenda.TabIndex = 10;
            this.btnConfirmaVenda.Text = "Confirmar Venda";
            this.btnConfirmaVenda.UseVisualStyleBackColor = false;
            this.btnConfirmaVenda.Click += new System.EventHandler(this.btnConfirmaVenda_Click);
            // 
            // btnPesquisaCPF
            // 
            this.btnPesquisaCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisaCPF.Location = new System.Drawing.Point(60, 122);
            this.btnPesquisaCPF.Name = "btnPesquisaCPF";
            this.btnPesquisaCPF.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisaCPF.TabIndex = 13;
            this.btnPesquisaCPF.Text = "Registrar por CPF";
            this.btnPesquisaCPF.UseVisualStyleBackColor = true;
            this.btnPesquisaCPF.Click += new System.EventHandler(this.btnPesquisaCPF_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(14, 96);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(169, 20);
            this.txtCPF.TabIndex = 12;
            this.txtCPF.TextChanged += new System.EventHandler(this.txtNumCPF_TextChanged);
            // 
            // btnPesquisaNomeBrinq
            // 
            this.btnPesquisaNomeBrinq.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisaNomeBrinq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaNomeBrinq.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisaNomeBrinq.Location = new System.Drawing.Point(60, 28);
            this.btnPesquisaNomeBrinq.Name = "btnPesquisaNomeBrinq";
            this.btnPesquisaNomeBrinq.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisaNomeBrinq.TabIndex = 16;
            this.btnPesquisaNomeBrinq.Text = "Pesquisar por nome";
            this.btnPesquisaNomeBrinq.UseVisualStyleBackColor = false;
            this.btnPesquisaNomeBrinq.Click += new System.EventHandler(this.btnPesquisaNomeBrinq_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(14, 32);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(39, 20);
            this.txtNomeProduto.TabIndex = 15;
            // 
            // cmbNomeProduto
            // 
            this.cmbNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeProduto.FormattingEnabled = true;
            this.cmbNomeProduto.Location = new System.Drawing.Point(14, 57);
            this.cmbNomeProduto.Name = "cmbNomeProduto";
            this.cmbNomeProduto.Size = new System.Drawing.Size(169, 21);
            this.cmbNomeProduto.TabIndex = 14;
            // 
            // btnPesquisaCod
            // 
            this.btnPesquisaCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCod.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPesquisaCod.Location = new System.Drawing.Point(60, 122);
            this.btnPesquisaCod.Name = "btnPesquisaCod";
            this.btnPesquisaCod.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisaCod.TabIndex = 19;
            this.btnPesquisaCod.Text = "Pesquisar por código";
            this.btnPesquisaCod.UseVisualStyleBackColor = true;
            this.btnPesquisaCod.Click += new System.EventHandler(this.btnPesquisaCod_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(14, 96);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // lbProdutos
            // 
            this.lbProdutos.FormattingEnabled = true;
            this.lbProdutos.Location = new System.Drawing.Point(189, 32);
            this.lbProdutos.Name = "lbProdutos";
            this.lbProdutos.Size = new System.Drawing.Size(121, 264);
            this.lbProdutos.TabIndex = 20;
            this.lbProdutos.SelectedIndexChanged += new System.EventHandler(this.lbProdutos_SelectedIndexChanged);
            // 
            // btnAdiciona
            // 
            this.btnAdiciona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdiciona.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAdiciona.Location = new System.Drawing.Point(75, 272);
            this.btnAdiciona.Name = "btnAdiciona";
            this.btnAdiciona.Size = new System.Drawing.Size(108, 23);
            this.btnAdiciona.TabIndex = 21;
            this.btnAdiciona.Text = "Adicionar à lista ->";
            this.btnAdiciona.UseVisualStyleBackColor = true;
            this.btnAdiciona.Click += new System.EventHandler(this.btnAdiciona_Click);
            // 
            // nudQtd
            // 
            this.nudQtd.Location = new System.Drawing.Point(14, 181);
            this.nudQtd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudQtd.Name = "nudQtd";
            this.nudQtd.Size = new System.Drawing.Size(169, 20);
            this.nudQtd.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Quantidade:";
            // 
            // dtpDataVenda
            // 
            this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataVenda.Location = new System.Drawing.Point(14, 236);
            this.dtpDataVenda.Name = "dtpDataVenda";
            this.dtpDataVenda.Size = new System.Drawing.Size(169, 20);
            this.dtpDataVenda.TabIndex = 24;
            this.dtpDataVenda.ValueChanged += new System.EventHandler(this.dtpDataVenda_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "ou";
            // 
            // gbxCliente
            // 
            this.gbxCliente.BackColor = System.Drawing.Color.DarkOrange;
            this.gbxCliente.Controls.Add(this.label5);
            this.gbxCliente.Controls.Add(this.btnPesquisaCPF);
            this.gbxCliente.Controls.Add(this.txtCPF);
            this.gbxCliente.Controls.Add(this.btnPesquisaNome);
            this.gbxCliente.Controls.Add(this.txtLetraCliente);
            this.gbxCliente.Controls.Add(this.cmbNomeCliente);
            this.gbxCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxCliente.Location = new System.Drawing.Point(375, 26);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Size = new System.Drawing.Size(199, 172);
            this.gbxCliente.TabIndex = 27;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cliente:";
            this.gbxCliente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // gbxProduto
            // 
            this.gbxProduto.BackColor = System.Drawing.Color.DarkOrange;
            this.gbxProduto.Controls.Add(this.label1);
            this.gbxProduto.Controls.Add(this.dtpDataVenda);
            this.gbxProduto.Controls.Add(this.lbProdutos);
            this.gbxProduto.Controls.Add(this.label4);
            this.gbxProduto.Controls.Add(this.btnAdiciona);
            this.gbxProduto.Controls.Add(this.label3);
            this.gbxProduto.Controls.Add(this.nudQtd);
            this.gbxProduto.Controls.Add(this.btnPesquisaCod);
            this.gbxProduto.Controls.Add(this.txtCodigo);
            this.gbxProduto.Controls.Add(this.btnPesquisaNomeBrinq);
            this.gbxProduto.Controls.Add(this.txtNomeProduto);
            this.gbxProduto.Controls.Add(this.cmbNomeProduto);
            this.gbxProduto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxProduto.Location = new System.Drawing.Point(26, 26);
            this.gbxProduto.Name = "gbxProduto";
            this.gbxProduto.Size = new System.Drawing.Size(322, 324);
            this.gbxProduto.TabIndex = 28;
            this.gbxProduto.TabStop = false;
            this.gbxProduto.Text = "Produto:";
            this.gbxProduto.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "ou";
            // 
            // Vendas
            // 
            this.AcceptButton = this.btnConfirmaVenda;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_orange;
            this.ClientSize = new System.Drawing.Size(602, 377);
            this.Controls.Add(this.gbxProduto);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.btnConfirmaVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vendas";
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.Vendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQtd)).EndInit();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.gbxProduto.ResumeLayout(false);
            this.gbxProduto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetraCliente;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConfirmaVenda;
        private System.Windows.Forms.Button btnPesquisaCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnPesquisaNomeBrinq;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox cmbNomeProduto;
        private System.Windows.Forms.Button btnPesquisaCod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ListBox lbProdutos;
        private System.Windows.Forms.Button btnAdiciona;
        private System.Windows.Forms.NumericUpDown nudQtd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxCliente;
        private System.Windows.Forms.GroupBox gbxProduto;
        private System.Windows.Forms.Label label1;
    }
}