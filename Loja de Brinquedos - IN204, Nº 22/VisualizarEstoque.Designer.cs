namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class VisualizarEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarEstoque));
            this.btnPesquisaCod = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPesquisaNomeBrinq = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.cmbNomeProduto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFaixaEt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnAlteraDados = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisaCod
            // 
            this.btnPesquisaCod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCod.Location = new System.Drawing.Point(13, 166);
            this.btnPesquisaCod.Name = "btnPesquisaCod";
            this.btnPesquisaCod.Size = new System.Drawing.Size(169, 23);
            this.btnPesquisaCod.TabIndex = 25;
            this.btnPesquisaCod.Text = "Pesquisar por código";
            this.btnPesquisaCod.UseVisualStyleBackColor = true;
            this.btnPesquisaCod.Click += new System.EventHandler(this.btnPesquisaCod_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(13, 140);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(169, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // btnPesquisaNomeBrinq
            // 
            this.btnPesquisaNomeBrinq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaNomeBrinq.Location = new System.Drawing.Point(59, 23);
            this.btnPesquisaNomeBrinq.Name = "btnPesquisaNomeBrinq";
            this.btnPesquisaNomeBrinq.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisaNomeBrinq.TabIndex = 23;
            this.btnPesquisaNomeBrinq.Text = "Pesquisar nome";
            this.btnPesquisaNomeBrinq.UseVisualStyleBackColor = true;
            this.btnPesquisaNomeBrinq.Click += new System.EventHandler(this.btnPesquisaNomeBrinq_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(13, 26);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(39, 20);
            this.txtNomeProduto.TabIndex = 22;
            // 
            // cmbNomeProduto
            // 
            this.cmbNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeProduto.Location = new System.Drawing.Point(13, 52);
            this.cmbNomeProduto.Name = "cmbNomeProduto";
            this.cmbNomeProduto.Size = new System.Drawing.Size(169, 21);
            this.cmbNomeProduto.TabIndex = 21;
            this.cmbNomeProduto.SelectedIndexChanged += new System.EventHandler(this.cmbNomeProduto_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gold;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.btnPesquisaCod);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.btnPesquisaNomeBrinq);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Controls.Add(this.cmbNomeProduto);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 222);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(83, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "ou";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(13, 89);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Código:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 49);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(50, 13);
            this.lblCodigo.TabIndex = 30;
            this.lblCodigo.Text = "lblCodigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data da última reposição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Estoque:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.lblMarca);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblFaixaEt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblCategoria);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblQtd);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCodigo);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(250, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(423, 172);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados:";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(225, 49);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(47, 13);
            this.lblMarca.TabIndex = 45;
            this.lblMarca.Text = "lblMarca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Marca:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblFaixaEt
            // 
            this.lblFaixaEt.AutoSize = true;
            this.lblFaixaEt.Location = new System.Drawing.Point(25, 117);
            this.lblFaixaEt.Name = "lblFaixaEt";
            this.lblFaixaEt.Size = new System.Drawing.Size(52, 13);
            this.lblFaixaEt.TabIndex = 43;
            this.lblFaixaEt.Text = "lblFaixaEt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Faixa Etária:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(312, 49);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(62, 13);
            this.lblCategoria.TabIndex = 41;
            this.lblCategoria.Text = "lblCategoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Categoria:";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(324, 118);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(34, 13);
            this.lblQtd.TabIndex = 39;
            this.lblQtd.Text = "lblQtd";
            this.lblQtd.Click += new System.EventHandler(this.lblQtd_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(158, 117);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(40, 13);
            this.lblData.TabIndex = 38;
            this.lblData.Text = "lblData";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(105, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "lblNome";
            // 
            // btnAlteraDados
            // 
            this.btnAlteraDados.BackColor = System.Drawing.Color.Gold;
            this.btnAlteraDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraDados.Location = new System.Drawing.Point(577, 227);
            this.btnAlteraDados.Name = "btnAlteraDados";
            this.btnAlteraDados.Size = new System.Drawing.Size(96, 23);
            this.btnAlteraDados.TabIndex = 36;
            this.btnAlteraDados.Text = "Alterar Dados";
            this.btnAlteraDados.UseVisualStyleBackColor = false;
            this.btnAlteraDados.Click += new System.EventHandler(this.btnAlteraDados_Click);
            // 
            // VisualizarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_yellow_form2;
            this.ClientSize = new System.Drawing.Size(701, 275);
            this.Controls.Add(this.btnAlteraDados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarEstoque";
            this.Text = "Gerenciar Estoque";
            this.Load += new System.EventHandler(this.VisualizarEstoque_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisaCod;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnPesquisaNomeBrinq;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox cmbNomeProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFaixaEt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAlteraDados;
    }
}