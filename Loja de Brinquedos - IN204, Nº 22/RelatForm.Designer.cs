namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class RelatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RelatForm));
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnPesquisaNomeBrinq = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.cmbNomeProduto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(300, 184);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(110, 23);
            this.btnConfirmar.TabIndex = 30;
            this.btnConfirmar.Text = "Gerar Relatório";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnPesquisaNomeBrinq
            // 
            this.btnPesquisaNomeBrinq.Location = new System.Drawing.Point(325, 78);
            this.btnPesquisaNomeBrinq.Name = "btnPesquisaNomeBrinq";
            this.btnPesquisaNomeBrinq.Size = new System.Drawing.Size(76, 23);
            this.btnPesquisaNomeBrinq.TabIndex = 29;
            this.btnPesquisaNomeBrinq.Text = "Buscar";
            this.btnPesquisaNomeBrinq.UseVisualStyleBackColor = true;
            this.btnPesquisaNomeBrinq.Click += new System.EventHandler(this.btnPesquisaNomeBrinq_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(232, 52);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(169, 20);
            this.txtNomeProduto.TabIndex = 28;
            // 
            // cmbNomeProduto
            // 
            this.cmbNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeProduto.Location = new System.Drawing.Point(232, 120);
            this.cmbNomeProduto.Name = "cmbNomeProduto";
            this.cmbNomeProduto.Size = new System.Drawing.Size(169, 21);
            this.cmbNomeProduto.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.btnPesquisaNomeBrinq);
            this.groupBox1.Controls.Add(this.txtNomeProduto);
            this.groupBox1.Controls.Add(this.cmbNomeProduto);
            this.groupBox1.Location = new System.Drawing.Point(25, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 225);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatório de vendas por produto:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Selecione o produto desejado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Insira uma ou mais letras para iniciar a busca:";
            // 
            // RelatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_white;
            this.ClientSize = new System.Drawing.Size(478, 276);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RelatForm";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.RelatForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button btnPesquisaNomeBrinq;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.ComboBox cmbNomeProduto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}