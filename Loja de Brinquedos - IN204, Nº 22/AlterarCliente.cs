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
    public partial class AlterarCliente : Form
    {
        
        List<Cliente> listaCliente = new List<Cliente>();
        Cliente cliente = new Cliente();
        string cpf_cliente;

        public AlterarCliente()
        {
            InitializeComponent();
        }

        private void AlterarCliente_Load(object sender, EventArgs e)
        {
                   
        }

        public void Recebe(string cpf)
        {
            cpf_cliente = cpf;
            metodo();
        }

        public void metodo()
        {
            listaCliente = cliente.BuscaClientesCPFBanco(cpf_cliente);

            txtNome.Text = listaCliente[0].Nome.ToString();
            dtpDataNasc.Value = Convert.ToDateTime(listaCliente[0].DataNascimento);
            txtEmail.Text = listaCliente[0].Email.ToString();
            txtTelCelular.Text = listaCliente[0].TelCelular.ToString();
        }
         

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtpDataVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text; string Email = txtEmail.Text;     
            string TelCelular = txtTelCelular.Text; string dataNasc = dtpDataNasc.Value.ToString().Substring(0, 10);
           

            bool recebe = true;
            cliente.AlteraAtributo(nomeCliente, cpf_cliente, Convert.ToDateTime(dataNasc), Email, TelCelular);
            if (recebe)
            {
                if (cliente.AlteraClientesBanco())
                {
                    MessageBox.Show("Dados alterados com sucesso!");
                }

                else
                {
                    MessageBox.Show("Erro no processo. Por favor tente novamente mais tarde.");
                }

            }
            else
            {
                MessageBox.Show("Dados inseridos de forma incorreta.");
            }
        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem certeza de que deseja deletar esse cliente?", "Confirmação", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                cliente = listaCliente[0];

                if (cliente.DeletaClientesBanco())
                {
                    MessageBox.Show("Registro deletado");
                }
                else
                    MessageBox.Show("Erro ao deletar registro");
            }

            
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
