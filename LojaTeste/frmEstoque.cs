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
        private bool validar;

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void configuraDgEstoque()
        {

            dgEstoque.Columns[0].HeaderText = "Código";
            dgEstoque.Columns[1].HeaderText = "Nome";
            dgEstoque.Columns[2].HeaderText = "Quantidade Disponivel";

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
            if (validar)
            {
                MessageBox.Show("Nenhuma categoria selecionada");
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
                    retorno = E.Salvar(EstoqueSelecionada.idProduto,  EstoqueSelecionada.qtdProdutoDisponivel);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    int idProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeProduto.Text = null;
                    txtQtdProduto.Text = null;
                    validar = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                atualizarDgEstoque();
            }

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgEstoque.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionada");
                return;
            }


            EstoqueSelecionada = (dgEstoque.SelectedRows[0].DataBoundItem as clsEstoque);

            //Inserindo os valores nos campos
            txtNomeProduto.Text = EstoqueSelecionada.nomeProduto;
            txtQtdProduto.Text = Convert.ToString(EstoqueSelecionada.qtdProdutoDisponivel);
           
            validar = false;
        }

        private void dgEstoque_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNomeProduto.Text = dgEstoque.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtQtdProduto.Text = dgEstoque.CurrentRow.Cells["qtdProdutoDisponivel"].Value.ToString();
        }

       

        private void txtQtdProduto_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();
                        
            if (!v.ValidarNumero(txtQtdProduto.Text) && txtQtdProduto.Text != "")
            {
                MessageBox.Show("Só número");
                txtQtdProduto.Text = "0";
            }
        }

        private void txtIdProduto_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtIdProduto.Text) && txtIdProduto.Text != "")
            {
                MessageBox.Show("Só letras");
                txtIdProduto.Text = "";
            }
        }
    }
}
