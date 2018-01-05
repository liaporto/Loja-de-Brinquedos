namespace Loja_de_Brinquedos_IN204_Nº_22
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelCelular = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAtualiza = new System.Windows.Forms.Button();
            this.btnDeleta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(101, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = "99999-9999";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(72, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 12);
            this.label15.TabIndex = 28;
            this.label15.Text = "aaaaaa@aaaa.aaa";
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(6, 251);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(148, 20);
            this.dtpDataNasc.TabIndex = 26;
            this.dtpDataNasc.ValueChanged += new System.EventHandler(this.dtpDataVenda_ValueChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(7, 113);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(147, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // txtTelCelular
            // 
            this.txtTelCelular.Location = new System.Drawing.Point(6, 190);
            this.txtTelCelular.Name = "txtTelCelular";
            this.txtTelCelular.Size = new System.Drawing.Size(148, 20);
            this.txtTelCelular.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone Celular:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(7, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data de Nascimento:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Completo:";
            // 
            // btnAtualiza
            // 
            this.btnAtualiza.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAtualiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualiza.Location = new System.Drawing.Point(229, 250);
            this.btnAtualiza.Name = "btnAtualiza";
            this.btnAtualiza.Size = new System.Drawing.Size(92, 25);
            this.btnAtualiza.TabIndex = 9;
            this.btnAtualiza.Text = "Atualizar Dados";
            this.btnAtualiza.UseVisualStyleBackColor = false;
            this.btnAtualiza.Click += new System.EventHandler(this.btnAtualiza_Click);
            // 
            // btnDeleta
            // 
            this.btnDeleta.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleta.Location = new System.Drawing.Point(229, 300);
            this.btnDeleta.Name = "btnDeleta";
            this.btnDeleta.Size = new System.Drawing.Size(92, 25);
            this.btnDeleta.TabIndex = 10;
            this.btnDeleta.Text = "Deletar Cliente";
            this.btnDeleta.UseVisualStyleBackColor = false;
            this.btnDeleta.Click += new System.EventHandler(this.btnDeleta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.dtpDataNasc);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtTelCelular);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Location = new System.Drawing.Point(23, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 303);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais:";
            // 
            // AlterarCliente
            // 
            this.AcceptButton = this.btnAtualiza;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Loja_de_Brinquedos_IN204_Nº_22.Properties.Resources.lego_bg_blue;
            this.ClientSize = new System.Drawing.Size(351, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleta);
            this.Controls.Add(this.btnAtualiza);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarCliente";
            this.Text = "Editar Cliente";
            this.Load += new System.EventHandler(this.AlterarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtTelCelular;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnAtualiza;
        private System.Windows.Forms.Button btnDeleta;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}