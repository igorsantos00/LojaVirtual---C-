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
using System.Data.SqlClient;

namespace LojaTeste
{
    public partial class frmEstoque : Form
    {
        private clsEstoque EstoqueSelecionada;
        private int retorno;
        private bool validar = false;

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void configuraDgEstoque()
        {

            dgEstoque.Columns[0].HeaderText = "Código";
            dgEstoque.Columns[1].HeaderText = "Nome";
            dgEstoque.Columns[2].HeaderText = "Quantidade Disponível";

            //Redimenciona o Tamanho da Coluna

            dgEstoque.Columns[0].Width = 50;
            dgEstoque.Columns[1].Width = 190;
            dgEstoque.Columns[2].Width = 346;



        }

        private void atualizarDgEstoque()
        {

            List<clsEstoque> Estoque = clsEstoque.SelecionarEstoque();
            dgEstoque.DataSource = Estoque;
            configuraDgEstoque();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            atualizarDgEstoque();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtIdProduto.Text.Equals(""))
            {
                atualizarDgEstoque();
            }
            else
            {
                List<clsEstoque> Estoque = clsEstoque.SelecionarEstoquePorNome(txtIdProduto.Text);
                dgEstoque.DataSource = Estoque;
                dgEstoque.Refresh();
                txtIdProduto.Text = null;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validar == false)
            {
                MessageBox.Show("Nenhum Produto selecionado");
                return;
            }

            //Pergunta se quer mesmo Alterar
            DialogResult resultado = MessageBox.Show("Deseja Alterar", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                clsEstoque E = new clsEstoque();
                try
                {
                    if (txtQtdProduto.Text != Convert.ToString(EstoqueSelecionada.qtdProdutoDisponivel))
                    {
                        retorno = E.Salvar(EstoqueSelecionada.idProduto, Convert.ToInt32(txtQtdProduto.Text));

                        int idProduto = Convert.ToInt32(retorno);
                        MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomeProduto.Text = null;
                        txtQtdProduto.Text = null;
                        validar = false;
                        atualizarDgEstoque();
                    }
                    else
                    {
                        MessageBox.Show("Nada foi alterado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

            }

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto selecionado");
                return;
            }


            EstoqueSelecionada = (dgEstoque.SelectedRows[0].DataBoundItem as clsEstoque);

            //Inserindo os valores nos campos
            txtNomeProduto.Text = EstoqueSelecionada.nomeProduto;
            txtQtdProduto.Text = Convert.ToString(EstoqueSelecionada.qtdProdutoDisponivel);

            validar = true;
        }

        private void txtQtdProduto_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidarNumero(txtQtdProduto.Text) && txtQtdProduto.Text != "")
            {
                MessageBox.Show("Somente números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtQtdProduto.Text = "";
            }
        }

        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtIdProduto.Text) && txtIdProduto.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdProduto.Text = "";
            }
        }
    }
}
