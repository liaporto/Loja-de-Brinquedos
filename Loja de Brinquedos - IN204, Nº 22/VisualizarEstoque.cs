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
    public partial class VisualizarEstoque : Form
    {
        List<Brinquedo> listaBrinquedo = new List<Brinquedo>();
        Brinquedo novo2 = new Brinquedo();
        CriticaDados critica = new CriticaDados();
        public VisualizarEstoque()
        {
            InitializeComponent();
        }

        private void VisualizarEstoque_Load(object sender, EventArgs e)
        {
            lblCategoria.Text = " ";
            lblCodigo.Text = " ";
            lblData.Text = " ";
            lblFaixaEt.Text = " ";
            lblNome.Text = " ";
            lblQtd.Text = " ";
            lblMarca.Text = " ";
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

        private void btnPesquisaCod_Click(object sender, EventArgs e)
        {
            Brinquedo novo = new Brinquedo();
            CriticaDados critica = new CriticaDados();
            if (critica.VerificaNum(txtCodigo.Text))
            {
                listaBrinquedo = novo.BuscaBrinquedosCodBanco(Convert.ToInt16(txtCodigo.Text));
                if (listaBrinquedo.Count() == 0)
                {
                    MessageBox.Show("Produto inexistente!");

                }
                else
                {
                    lblCodigo.Text = listaBrinquedo[0].Cod_Brinquedo.ToString();
                    lblNome.Text = listaBrinquedo[0].Nome_Brinquedo.ToString();
                    lblData.Text = listaBrinquedo[0].Data_Aquisicao.ToString().Substring(0, 10);
                    lblQtd.Text = listaBrinquedo[0].Qtd_Estoque.ToString();
                    lblCategoria.Text = listaBrinquedo[0].Categoria.ToString();
                    lblFaixaEt.Text = listaBrinquedo[0].FaixaEtaria.ToString();
                    lblMarca.Text = listaBrinquedo[0].Marca.ToString();
                    novo2 = listaBrinquedo[0];
                }
            }
            else
            {
                MessageBox.Show("Formato de código inválido");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Brinquedo novo = new Brinquedo();

            if (cmbNomeProduto.SelectedItem == null)
            {
                listaBrinquedo = novo.BuscaBrinquedosBanco(cmbNomeProduto.SelectedItem.ToString());

                lblCodigo.Text = listaBrinquedo[0].Cod_Brinquedo.ToString();
                lblNome.Text = listaBrinquedo[0].Nome_Brinquedo.ToString();
                lblData.Text = listaBrinquedo[0].Data_Aquisicao.ToString().Substring(0, 10);
                lblQtd.Text = listaBrinquedo[0].Qtd_Estoque.ToString();
                lblCategoria.Text = listaBrinquedo[0].Categoria.ToString();
                lblFaixaEt.Text = listaBrinquedo[0].FaixaEtaria.ToString();
                lblMarca.Text = listaBrinquedo[0].Marca.ToString();
                novo2 = listaBrinquedo[0];
            }
            else
                MessageBox.Show("Você não selecionou nenhum produto!");
            
               
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbNomeProduto.SelectedItem == null || lblCodigo.Text == "")
            {
                AlterarProduto altera = new AlterarProduto();
                altera.Recebe(novo2.Cod_Brinquedo);
                altera.ShowDialog();
            }
            else
                MessageBox.Show("Não há nenhum brinquedo selecionado. Você pode resolver isso escolhendo um brinquedo na lista e clicando em confirmar para ver informações sobre ele.");
 
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbNomeProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblQtd_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAlteraDados_Click(object sender, EventArgs e)
        {
            if (cmbNomeProduto.SelectedItem == null || lblCodigo.Text == "")
            {
                AlterarProduto altera = new AlterarProduto();
                altera.Recebe(novo2.Cod_Brinquedo);
                altera.ShowDialog();
            }
            else
                MessageBox.Show("Não há nenhum brinquedo selecionado. Você pode resolver esse problema escolhendo um na lista e clicando em confirmar para obter informações sobre ele.");
 
        }
    }
}
