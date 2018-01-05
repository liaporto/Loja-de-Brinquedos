namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class VisualizarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualizarCliente));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTelCelular = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlteraDados = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesquisaCPF = new System.Windows.Forms.Button();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnPesquisaNome = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.cmbNomeCliente = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox2.Controls.Add(this.lblEmail);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblTelCelular);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblData);
            this.groupBox2.Controls.Add(this.lblNome);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblCPF);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(248, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(428, 177);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(161, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 13);
            this.lblEmail.TabIndex = 45;
            this.lblEmail.Text = "lblEmail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Email:";
            // 
            // lblTelCelular
            // 
            this.lblTelCelular.AutoSize = true;
            this.lblTelCelular.Location = new System.Drawing.Point(25, 144);
            this.lblTelCelular.Name = "lblTelCelular";
            this.lblTelCelular.Size = new System.Drawing.Size(64, 13);
            this.lblTelCelular.TabIndex = 41;
            this.lblTelCelular.Text = "lblTelCelular";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefone Celular:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(297, 49);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(40, 13);
            this.lblData.TabIndex = 38;
            this.lblData.Text = "lblData";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(161, 49);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 13);
            this.lblNome.TabIndex = 37;
            this.lblNome.Text = "lblNome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Data de Nascimento:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(25, 49);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 13);
            this.lblCPF.TabIndex = 30;
            this.lblCPF.Text = "lblCPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "CPF:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome do Cliente:";
            // 
            // btnAlteraDados
            // 
            this.btnAlteraDados.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAlteraDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlteraDados.Location = new System.Drawing.Point(576, 227);
            this.btnAlteraDados.Name = "btnAlteraDados";
            this.btnAlteraDados.Size = new System.Drawing.Size(100, 23);
            this.btnAlteraDados.TabIndex = 35;
            this.btnAlteraDados.Text = "Alterar Dados";
            this.btnAlteraDados.UseVisualStyleBackColor = false;
            this.btnAlteraDados.Click += new System.EventHandler(this.btnAlteraDados_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.btnPesquisaCPF);
            this.groupBox1.Controls.Add(this.txtCPF);
            this.groupBox1.Controls.Add(this.btnPesquisaNome);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.cmbNomeCliente);
            this.groupBox1.Location = new System.Drawing.Point(24, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 224);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisa:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "ou";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Location = new System.Drawing.Point(13, 86);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 26;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesquisaCPF
            // 
            this.btnPesquisaCPF.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisaCPF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaCPF.Location = new System.Drawing.Point(13, 170);
            this.btnPesquisaCPF.Name = "btnPesquisaCPF";
            this.btnPesquisaCPF.Size = new System.Drawing.Size(169, 23);
            this.btnPesquisaCPF.TabIndex = 25;
            this.btnPesquisaCPF.Text = "Pesquisar por CPF";
            this.btnPesquisaCPF.UseVisualStyleBackColor = false;
            this.btnPesquisaCPF.Click += new System.EventHandler(this.btnPesquisaCPF_Click);
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(13, 144);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(169, 20);
            this.txtCPF.TabIndex = 24;
            // 
            // btnPesquisaNome
            // 
            this.btnPesquisaNome.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPesquisaNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisaNome.Location = new System.Drawing.Point(59, 20);
            this.btnPesquisaNome.Name = "btnPesquisaNome";
            this.btnPesquisaNome.Size = new System.Drawing.Size(123, 23);
            this.btnPesquisaNome.TabIndex = 23;
            this.btnPesquisaNome.Text = "Pesquisar nome";
            this.btnPesquisaNome.UseVisualStyleBackColor = false;
            this.btnPesquisaNome.Click += new System.EventHandler(this.btnPesquisaNome_Click);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(13, 23);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(39, 20);
            this.txtNomeCliente.TabIndex = 22;
            // 
            // cmbNomeCliente
            // 
            this.cmbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeCliente.Location = new System.Drawing.Point(13, 49);
            this.cmbNomeCliente.Name = "cmbNomeCliente";
            this.cmbNomeCliente.Size = new System.Drawing.Size(169, 21);
            this.cmbNomeCliente.TabIndex = 21;
            this.cmbNomeCliente.SelectedIndexChanged += new System.EventHandler(this.cmbNomeCliente_SelectedIndexChanged);
            // 
            // VisualizarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_blue;
            this.ClientSize = new System.Drawing.Size(699, 274);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAlteraDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualizarCliente";
            this.Text = "Visualizar Cliente";
            this.Load += new System.EventHandler(this.VisualizarCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTelCelular;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnAlteraDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnPesquisaCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Button btnPesquisaNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.ComboBox cmbNomeCliente;
    }
}