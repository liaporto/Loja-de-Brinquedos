using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Brinquedos_IN204_Nº_22
{
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastra_Click(object sender, EventArgs e)
        {
            bool recebe;
            Cliente novo = new Cliente();
            string nome = txtNome.Text; string cpf = txtCPF.Text;
            string datanasc = dtpDataNasc.Value.ToString().Substring(0,10); string email = txtEmail.Text; string tel_celular = txtTelCel.Text;
           

            if (txtNome.Text == " " || txtEmail.Text == " " || txtCPF.Text == " " || txtTelCel.Text == " ")
            {
                MessageBox.Show("Por favor preencha todos os dados.");
            }

            else
            {

                recebe = novo.AlteraAtributo(nome, cpf, Convert.ToDateTime(datanasc), email, tel_celular);
                if (recebe)
                {
                    if (novo.CadastraBanco())
                    {
                        
                        MessageBox.Show("Cadastro realizado com sucesso!");
                        txtNome.Clear(); txtCPF.Clear(); txtTelCel.Clear(); txtEmail.Clear();
                    }

                    else
                        MessageBox.Show("Erro no cadastro. Pedimos perdão pelo transtorno. Tente novamente mais tarde");
                }

                else
                    MessageBox.Show("Erro no cadastro. Por favor confira se os dados estão preenchidos da forma correta.");

            }
           }


        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
