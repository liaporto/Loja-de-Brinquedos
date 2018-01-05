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
    public partial class Vendas : Form
    {
        CriticaDados critica = new CriticaDados();
        List<Cliente> listaCliente = new List<Cliente>();
        List<Brinquedo> listaBrinquedo = new List<Brinquedo>();
        List<Brinquedo> listaSelecionados = new List<Brinquedo>();
        List<int> listaqtd = new List<int>();

        //int contador = 0;

       
        public Vendas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Vendas_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNumCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            cmbNomeCliente.Items.Clear();
            Cliente novo = new Cliente();
            listaCliente = novo.BuscaClientesBanco(txtLetraCliente.Text);
            for (int i = 0; i < listaCliente.Count; i++)
            {
                cmbNomeCliente.Items.Add(listaCliente[i].Nome.ToString());
            }
        }

        private void btnPesquisaNomeBrinq_Click(object sender, EventArgs e)
        {

            cmbNomeProduto.Items.Clear();
            Brinquedo novo = new Brinquedo();
            listaBrinquedo = novo.BuscaBrinquedosBanco(txtNomeProduto.Text);
            for (int i = 0; i < listaBrinquedo.Count; i++)
            {
                cmbNomeProduto.Items.Add(listaBrinquedo[i].Nome_Brinquedo.ToString());

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
                    for (int i = 0; i < listaCliente.Count; i++)
                    {
                        cmbNomeCliente.Items.Add(listaCliente[i].Nome.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Formato de cpf inválido");
            }
        }

        private void btnPesquisaCod_Click(object sender, EventArgs e)
        {

            Brinquedo novo = new Brinquedo();
            if (critica.VerificaNum(txtCodigo.Text))
            {
                listaBrinquedo = novo.BuscaBrinquedosCodBanco(Convert.ToInt16(txtCodigo.Text));
                if (listaBrinquedo.Count() == 0)
                {
                    MessageBox.Show("Produto inexistente!");

                }
                else
                {
                    cmbNomeProduto.Items.Clear();
                    cmbNomeProduto.Items.Add(listaBrinquedo[0].Nome_Brinquedo.ToString());

                }
            }
            else
            {
                MessageBox.Show("Formato de código inválido");
            }

        }

        private void btnConfirmaVenda_Click(object sender, EventArgs e)
        {
            if (cmbNomeCliente != null && cmbNomeProduto != null && nudQtd.Value != 0)
            {
                Brinquedo brinquedo = new Brinquedo();
                Cliente cliente = new Cliente();
                listaCliente = cliente.BuscaClientesBanco(cmbNomeCliente.SelectedItem.ToString());

                int[] cod_Brinquedo = new int[lbProdutos.Items.Count];
                DateTime[] dataVenda = new DateTime[lbProdutos.Items.Count];
                string[] cpf_cliente = new string[lbProdutos.Items.Count];
                int[] quantidade = new int[lbProdutos.Items.Count];


                for (int i = 0; i < lbProdutos.Items.Count; i++)
                {
                    Brinquedo novo = new Brinquedo();
                    novo = listaSelecionados[i];
                    cod_Brinquedo[i] = novo.Cod_Brinquedo;
                    dataVenda[i] = dtpDataVenda.Value;
                    cpf_cliente[i] = listaCliente[0].CPF.ToString();
                    quantidade[i] = Convert.ToInt16(nudQtd.Value)/*Convert.ToInt16(listaqtd[i])*/;
                }

                VendasClasse vendarealizada = new VendasClasse();

                if (vendarealizada.CadastraBancoemBloco(cod_Brinquedo, dataVenda, cpf_cliente, quantidade))
                {
                    MessageBox.Show("Venda Registrada");
                    txtCodigo.Clear(); txtCPF.Clear(); txtLetraCliente.Clear(); txtNomeProduto.Clear(); cmbNomeProduto.SelectedItem = null;
                    cmbNomeCliente.SelectedItem = null; nudQtd.Value = 0;
                }

                else
                    MessageBox.Show("Erro no registro. Por favor tente novamente mais tarde.");
            }
            else
                MessageBox.Show("Por favor insira todos os dados");

        }

        private void btnAdiciona_Click(object sender, EventArgs e)
        {
            Brinquedo novo = new Brinquedo();
            novo = listaBrinquedo[cmbNomeProduto.SelectedIndex];
            lbProdutos.Items.Add(cmbNomeProduto.SelectedItem.ToString() + " (" + nudQtd.Value + ")");
            //listaqtd[contador] = Convert.ToInt16(nudQtd.Value);
            //contador++;
            listaSelecionados.Add(novo);
        }

        public void lbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDataVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

