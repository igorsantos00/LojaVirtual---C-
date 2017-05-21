using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dataModel;

namespace LojaTeste
{
    public partial class frmProduto : Form
    {
      
        public frmProduto()
        {
            InitializeComponent();
        }

        private void configuraDgProduto()
        {

            dgProduto.Columns[0].HeaderText = "Código";
            dgProduto.Columns[1].HeaderText = "Nome";
            dgProduto.Columns[2].HeaderText = "Quantidade";
            dgProduto.Columns[3].HeaderText = "Preço";
            dgProduto.Columns[4].HeaderText = "IDCategoria";
            dgProduto.Columns[5].HeaderText = "Desconto";
            dgProduto.Columns[6].HeaderText = "Status";

            //Redimenciona o Tamanho da Coluna

            dgProduto.Columns[0].Width = 50;
            dgProduto.Columns[1].Width = 150;
            dgProduto.Columns[2].Width = 347;

        }

        private void atualizarDgProduto()
        {

            List<clsProduto> Produto = clsProduto.SelecionarProduto();
            dgProduto.DataSource = Produto;
            configuraDgProduto();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarProduto_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Equals(""))
            {
                atualizarDgProduto();
            }
            else
            {
                List<clsProduto> Produto = clsProduto.SelecionarProdutoID(Convert.ToInt32(txtIdProduto.Text));
                dgProduto.DataSource = Produto;
                configuraDgProduto();
            }
        }
    }
}
