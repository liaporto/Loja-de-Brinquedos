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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cadastrarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarVendaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadastroBrinq novo = new frmCadastroBrinq();
            novo.ShowDialog();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente novo = new frmCadastroCliente();
            novo.Show();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            frmCadastroBrinq novo = new frmCadastroBrinq();
            novo.Show();
        }

        private void btnVisualizaCliente_Click(object sender, EventArgs e)
        {
            VisualizarCliente novo = new VisualizarCliente();
            novo.Show();
        }

        private void btnVisualizaEstoque_Click(object sender, EventArgs e)
        {
            VisualizarEstoque novo = new VisualizarEstoque();
            novo.Show();
        }

        private void btnRegistraVenda_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            vendas.Show();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click_1(object sender, EventArgs e)
        {
            RelatForm relatorio = new RelatForm();
            relatorio.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
