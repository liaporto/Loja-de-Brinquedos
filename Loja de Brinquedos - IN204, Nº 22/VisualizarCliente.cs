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
    public partial class VisualizarCliente : Form
    {
        CriticaDados critica = new CriticaDados();
        List<Cliente> listaCliente = new List<Cliente>();
        Cliente novo2 = new Cliente();
      
        public VisualizarCliente()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void VisualizarCliente_Load(object sender, EventArgs e)
        {
            lblCPF.Text = " ";
            lblData.Text = " ";
            lblEmail.Text = " ";
            lblNome.Text = " ";
            lblTelCelular.Text = " ";
        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            cmbNomeCliente.Items.Clear();
            Cliente novo = new Cliente();
            listaCliente = novo.BuscaClientesBanco(txtNomeCliente.Text);
            for (int i = 0; i < listaCliente.Count; i++)
            {
                cmbNomeCliente.Items.Add(listaCliente[i].Nome.ToString());
            }
        }

        private void btnPesquisaCPF_Click(object sender, EventArgs e)
        {
            cmbNomeCliente.Items.Clear();
            Cliente novo = new Cliente();
            if (critica.VerificaNum_Ponto_Traco(txtCPF.Text))
            {
                listaCliente = novo.BuscaClientesCPFBanco(txtCPF.Text);
                if (listaCliente.Count() == 0)
                {
                    MessageBox.Show("Cliente inexistente!");

                }
                else
                {
                   
                    lblNome.Text = listaCliente[0].Nome.ToString();
                    lblData.Text = listaCliente[0].DataNascimento.ToString().Substring(0,10);
                    lblCPF.Text = listaCliente[0].CPF.ToString();
                    lblEmail.Text = listaCliente[0].Email.ToString();
                    lblTelCelular.Text = listaCliente[0].TelCelular.ToString();
                    novo2 = listaCliente[0];
                }
            }
            else
            {
                MessageBox.Show("Formato de cpf inválido");
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Cliente novo = new Cliente();
            if (cmbNomeCliente.SelectedItem != null)
            {
                listaCliente = novo.BuscaClientesNomeBanco(cmbNomeCliente.SelectedItem.ToString());

                lblNome.Text = listaCliente[0].Nome.ToString();
                lblData.Text = listaCliente[0].DataNascimento.ToString().Substring(0, 10);
                lblCPF.Text = listaCliente[0].CPF.ToString();
                lblEmail.Text = listaCliente[0].Email.ToString();
                lblTelCelular.Text = listaCliente[0].TelCelular.ToString();
                novo2 = listaCliente[0];
            }
            else
                MessageBox.Show("Você não selecionou nenhum cliente!");

            
        }

        private void btnAlteraDados_Click(object sender, EventArgs e)
        {
            if (cmbNomeCliente.SelectedItem == null ||  lblCPF.Text != " ")
            {
                AlterarCliente altera = new AlterarCliente();
                altera.Recebe(novo2.CPF);
                altera.ShowDialog();
            }
           else
                MessageBox.Show("Não há nenhum cliente selecionado. Você pode resolver esse problema escolhendo um cliente na lista e clicando em confirmar para exibir seus dados.");
           
        }

        private void cmbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }
        }
    }

