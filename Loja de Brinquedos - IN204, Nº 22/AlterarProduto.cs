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
    public partial class AlterarProduto : Form
    {
        VisualizarEstoque novo = new VisualizarEstoque();
       List<Brinquedo> listaBrinquedos = new List<Brinquedo>();
        Brinquedo brinquedo = new Brinquedo();
        int cod_produto;

        public AlterarProduto()
        {
            InitializeComponent();
        }

        public void Recebe(int cod)
        {
            cod_produto = cod;
            metodo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void AlterarProduto_Load(object sender, EventArgs e)
        {
        
           

        }

        public void metodo()
        {
            listaBrinquedos = brinquedo.BuscaBrinquedosCodBanco(cod_produto);
                cod_produto = listaBrinquedos[0].Cod_Brinquedo;
                txtNome.Text = listaBrinquedos[0].Nome_Brinquedo.ToString();
                dtpDataVenda.Value = listaBrinquedos[0].Data_Aquisicao;
                nudQtd.Value = listaBrinquedos[0].Qtd_Estoque;
                cmbCategoria.SelectedItem = listaBrinquedos[0].Categoria.ToString();
                cmbFaixaEt.SelectedItem = listaBrinquedos[0].FaixaEtaria.ToString();
                txtMarca.Text = listaBrinquedos[0].Marca.ToString();
                  }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            
            brinquedo = listaBrinquedos[0];
            
            string nomeProduto = txtNome.Text; string categoria = cmbCategoria.SelectedItem.ToString();
            string FaixaEt = cmbFaixaEt.SelectedItem.ToString(); string marca = txtMarca.Text;
            int QtdEstoque = Convert.ToInt16(nudQtd.Value); string dataaquisicao = dtpDataVenda.Value.ToString().Substring(0, 10);
           

            bool recebe = true;
            recebe = brinquedo.AlteraAtributo(nomeProduto, categoria, Convert.ToDateTime(dataaquisicao), FaixaEt, marca, QtdEstoque);
            if(recebe)
            {
                if(brinquedo.AlteraBrinquedosBanco())
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

        private void dtpDataVenda_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleta_Click(object sender, EventArgs e)
        {
          DialogResult dr = MessageBox.Show("Tem certeza de que deseja deletar esse produto?", "Confirmação", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);
          if (dr == DialogResult.Yes)
          {
              brinquedo = listaBrinquedos[0];
                  if (brinquedo.DeletaBinquedosBanco(cod_produto))
                  {
                      MessageBox.Show("Produto deletado");
                      txtMarca.Text = "";
                      txtNome.Text = "";
                      nudQtd.Value = 0;
                      cmbCategoria.SelectedItem = null;
                      cmbFaixaEt.SelectedItem = null;
                      
                  }
                  else
                      MessageBox.Show("Erro ao deletar produto.");
              }
             

          }
        }
    }

