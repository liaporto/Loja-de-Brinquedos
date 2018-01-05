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
    public partial class frmCadastroBrinq : Form
    {
        public frmCadastroBrinq()
        {
            InitializeComponent();
        }

        private void CadastroBrinquedo_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastraBrinq_Click(object sender, EventArgs e)
        {
            Brinquedo novo = new Brinquedo();
            string nome_brinquedo = txtNomeBrinq.Text; string categoria = Convert.ToString(cmbCategoria.SelectedItem);
            string faixa_etaria = Convert.ToString(cmbFaixaEt.SelectedItem); string marca = txtMarca.Text;
            string data_aquisicao = dtpDataAq.Value.ToString().Substring(0,10); int qtd_estoque = Convert.ToInt16(nudQtdEstoque.Text);

            bool recebe;
            recebe = novo.AlteraAtributo(nome_brinquedo, categoria, Convert.ToDateTime(data_aquisicao), faixa_etaria, marca, qtd_estoque);
            recebe = true;
            if (recebe)
            
                if (novo.CadastraBanco())
                {
                    txtMarca.Clear(); txtNomeBrinq.Clear(); cmbCategoria.SelectedItem = null; cmbFaixaEt.SelectedItem = null; //nudQtdEstoque.Value = 0;
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
            
            else
                MessageBox.Show("Erro no cadastro. Por favor confira se os dados estão preenchidos da forma correta.");
        }

        private void dtpDataAq_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbFaixaEt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpDataVenda_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
