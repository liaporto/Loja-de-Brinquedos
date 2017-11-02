using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja_de_Brinquedos___IN204__Nº_22
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
            frmCadastroCliente novo = new frmCadastroCliente();
            novo.ShowDialog();
        }
    }
}
