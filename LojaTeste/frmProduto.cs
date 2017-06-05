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
using System.IO;

namespace LojaTeste
{
    public partial class frmProduto : Form
    {
        byte[] imagem;
        private int retorno;
        private bool validar = true;
        private clsProduto ProdutoSelecionado;
        private clsUsuario userLog;
        public frmProduto(clsUsuario userLog)
        {
            this.userLog = userLog;
            InitializeComponent();
        }

        private void configuraDgProduto()
        {

            dgProduto.Columns[0].HeaderText = "Código";
            dgProduto.Columns[1].HeaderText = "Nome";
            dgProduto.Columns[2].HeaderText = "Descricão";
            dgProduto.Columns[3].HeaderText = "Preço";
            dgProduto.Columns[4].HeaderText = "Desconto";
            dgProduto.Columns[5].HeaderText = "IDCategoria";
            dgProduto.Columns[6].HeaderText = "Status";
            dgProduto.Columns[7].HeaderText = "IDUsuario";
            dgProduto.Columns[8].HeaderText = "QtdMin.Estoque";
            dgProduto.Columns[9].HeaderText = "Nome Categoria";
            //Redimenciona o Tamanho da Coluna

            dgProduto.Columns[0].Width = 50;
            dgProduto.Columns[1].Width = 170;
            dgProduto.Columns[2].Width = 347;
            dgProduto.Columns[3].Width = 100;
            dgProduto.Columns[4].Width = 100;
            dgProduto.Columns[5].Width = 70;
            dgProduto.Columns[6].Width = 50;
            dgProduto.Columns[7].Width = 70;
            dgProduto.Columns[8].Width = 70;
            dgProduto.Columns[9].Width = 150;


        }

        private void atualizarDgProduto()
        {

            List<clsProduto> Produto = clsProduto.SelecionarProduto();            
            dgProduto.DataSource = Produto;
            dgProduto.Columns["idProduto"].Visible = true;
            dgProduto.Columns["Imagem"].Visible = false;
            dgProduto.Columns["nomeProduto"].Width = 200;
            configuraDgProduto();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            atualizarDgProduto();
       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnCarregarFoto_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagem (*.jpg)|*.jpg";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.CheckFileExists)
                {
                    imagem = File.ReadAllBytes(ofd.FileName);
                    mostraFoto(imagem);
                }
                else
                {
                    imagem = new byte[0];
                    MessageBox.Show("Arquivo Inválido! Tente novamente...");
                }
            }
        }

        private void mostraFoto(Byte[] dados)
        {
            if (dados.Length > 0)
            {
                MemoryStream mem = new MemoryStream(dados);
                imgImagem.Image = Image.FromStream(mem);
            }
            else
            {
                imgImagem.Image = null;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (dgProduto.SelectedRows.Count > 0)
            {
                clsProduto P = (clsProduto)dgProduto.SelectedRows[0].DataBoundItem;
                P.imagem = imagem;
               
            }
        }
        private void dgProduto_SelectionChanged(object sender, EventArgs e)
        {
            if (dgProduto.SelectedRows.Count > 0)
            {
                if (dgProduto.SelectedRows[0].Cells[1].Value != null)
                {
                    imagem = new byte[0];
                    imagem = (byte[])(dgProduto.SelectedRows[0].Cells["Imagem"].Value);
                    mostraFoto(imagem);
                }
            }
        }

        private void btnSelecionarProduto_Click_1(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto selecionada");
                return;
            }


            ProdutoSelecionado = (dgProduto.SelectedRows[0].DataBoundItem as clsProduto);

            //Inserindo os valores nos campos

            txtnomeProduto.Text = ProdutoSelecionado.nomeProduto;
            txtdescProduto.Text = ProdutoSelecionado.descProduto;
            txtprecProduto.Text = Convert.ToString(ProdutoSelecionado.precProduto);
            txtdescontoPromocao.Text = Convert.ToString(ProdutoSelecionado.descontoPromocao);
            txtqtdMinEstoque.Text = Convert.ToString(ProdutoSelecionado.qtdMinEstoque);
            

            validar = false;
        }

        private void btnExcluirProduto_Click_1(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgProduto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Produto selecionado");
                return;
            }

            //Pergunta se quer mesmo excluir
            DialogResult resultado = MessageBox.Show("Deseja excluir " + dgProduto.SelectedRows[0].Cells["nomeProduto"].Value, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            clsProduto ProdutoSelecionado = (dgProduto.SelectedRows[0].DataBoundItem as clsProduto);

            //Instância a class, e chama o método de excluir
            clsProduto C = new clsProduto();

            try
            {
                retorno = C.ExcluirProdutos(ProdutoSelecionado.idProduto);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificando se deu certo
            if (retorno != 0)
            {
                int idProduto = Convert.ToInt32(retorno);
                MessageBox.Show("Excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else

            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            atualizarDgProduto();
        }

        private void dgProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtnomeProduto.Text = dgProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtdescProduto.Text = dgProduto.CurrentRow.Cells["descProduto"].Value.ToString();
            txtprecProduto.Text = dgProduto.CurrentRow.Cells["precProduto"].Value.ToString();
            txtdescontoPromocao.Text = dgProduto.CurrentRow.Cells["descontoPromocao"].Value.ToString();
            txtqtdMinEstoque.Text = dgProduto.CurrentRow.Cells["qtdMinEstoque"].Value.ToString();
            chkativoProduto.Checked = Convert.ToBoolean(dgProduto.CurrentRow.Cells["ativoProduto"].Value);
            txtnomeProduto.Text = dgProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtidCategoria.Text = dgProduto.CurrentRow.Cells["nomeCategoria"].Value.ToString();

            if (((byte[])dgProduto.CurrentRow.Cells["imagem"].Value).Length != 0 )
            {
                MemoryStream imagem = new MemoryStream((byte[])dgProduto.CurrentRow.Cells["imagem"].Value);
                imgImagem.Image = Image.FromStream(imagem);
            }
            else
            {
                imgImagem.Image = null;
            }
        }

        private void mnuPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    

        private void btnInserir_Click(object sender, EventArgs e)
        {
            clsProduto P = new clsProduto();
          
                retorno = P.Salvar(0, txtnomeProduto.Text, txtdescProduto.Text, Convert.ToDecimal(txtprecProduto.Text), Convert.ToDecimal(txtdescontoPromocao.Text), Convert.ToInt32(txtidCategoria.Text), chkativoProduto.Checked, 0, Convert.ToInt32(txtqtdMinEstoque.Text), imagem);

                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomeProduto.Text = null;
                txtdescProduto.Text = null;
                txtprecProduto.Text = null;
                txtdescontoPromocao.Text = null;
                txtqtdMinEstoque.Text = null;
                chkativoProduto.Checked = false;
                txtidCategoria.Text = null;
                imgImagem.Image = null;
         

            atualizarDgProduto();
        }


        public void atualizarcomboCategoria()
        {
            clsCategoria C = new clsCategoria();

            txtidCategoria.DataSource = C.GetCategoria();
            txtidCategoria.ValueMember = "idCategoria";
            txtidCategoria.DisplayMember = "nomeCategoria";
        }



        private void txtidCategoria_Click(object sender, EventArgs e)
        {
            atualizarcomboCategoria();
        }

   
    }
}
