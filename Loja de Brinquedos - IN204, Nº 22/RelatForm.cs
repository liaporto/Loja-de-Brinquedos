using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastReport;

namespace Loja_de_Brinquedos_IN204_Nº_22
{
    public partial class RelatForm : Form
    {
        List<Brinquedo> listaBrinquedo = new List<Brinquedo>();
        public RelatForm()
        {
            InitializeComponent();
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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cmbNomeProduto.SelectedItem != null)
            {
                VendasClasse novaVenda = new VendasClasse();
                DataTable dt = new DataTable();
                dt = novaVenda.BuscaVendaBanco(listaBrinquedo[cmbNomeProduto.SelectedIndex].Cod_Brinquedo);

                Report report = new Report();

                report.Load("Relatorio.frx");

                report.RegisterData(dt, "Tabela_de_Dados");
                report.GetDataSource("Tabela_de_Dados").Enabled = true;
                FastReport.DataBand dados = (FastReport.DataBand)report.FindObject("Data1");
                dados.DataSource = report.GetDataSource("Tabela_de_Dados");



                FastReport.TextObject Nome_brinquedo = (FastReport.TextObject)report.FindObject("txtNomeBrinq");
                FastReport.TextObject Nome = (FastReport.TextObject)report.FindObject("txtNomeCliente");
                FastReport.TextObject data_Venda = (FastReport.TextObject)report.FindObject("txtdataVenda");
                FastReport.TextObject quantidade = (FastReport.TextObject)report.FindObject("txtqtd");



                Nome_brinquedo.Text = "[Tabela_de_Dados.Nome_Brinquedo]";
                data_Venda.Text = "[Tabela_de_Dados.data_Venda]";
                Nome.Text = "[Tabela_de_Dados.Nome]";
                quantidade.Text = "[Tabela_de_Dados.quantidade]";

                report.Show();
            }
            else
                MessageBox.Show("Não há nenhum produto selecionado!");
             
          }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RelatForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

