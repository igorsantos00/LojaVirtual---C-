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
        private bool validar = false;
        private clsProduto ProdutoSelecionado;
        private clsUsuario userLog;
        int idCategoria;
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

        private void mostraFoto(Byte[] imagem)
        {
            if (imagem.Length > 0)
            {
                imgImagem.Image = null;
                MemoryStream mem = new MemoryStream(imagem);
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

            txtidCategoria.Text = dgProduto.CurrentRow.Cells["nomeCategoria"].Value.ToString();
            txtIdProduto.Text = Convert.ToString(ProdutoSelecionado.idProduto);
            chkativoProduto.Checked = ProdutoSelecionado.ativoProduto;
            txtnomeProduto.Text = ProdutoSelecionado.nomeProduto;
            txtdescProduto.Text = ProdutoSelecionado.descProduto;
            txtprecProduto.Text = Convert.ToString(ProdutoSelecionado.precProduto);
            txtdescontoPromocao.Text = Convert.ToString(ProdutoSelecionado.descontoPromocao);
            txtqtdMinEstoque.Text = Convert.ToString(ProdutoSelecionado.qtdMinEstoque);
            if ((dgProduto.SelectedRows[0].Cells["imagem"].Value) != null)
            {
                imagem = (byte[])dgProduto.CurrentRow.Cells["imagem"].Value;
                mostraFoto((byte[])dgProduto.CurrentRow.Cells["imagem"].Value);


            }
            else
            {
                imgImagem.Image = null;
            }



            validar = true;
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
                txtnomeProduto.Text = null;
                txtdescProduto.Text = null;
                txtprecProduto.Text = null;
                txtdescontoPromocao.Text = null;
                txtqtdMinEstoque.Text = null;
                chkativoProduto.Checked = false;
                txtidCategoria.Text = null;
                imgImagem.Image = null;

            }
            else

            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            atualizarDgProduto();
        }

        private void dgProduto_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            txtIdProduto.Text = dgProduto.CurrentRow.Cells["idProduto"].Value.ToString();
            txtnomeProduto.Text = dgProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtdescProduto.Text = dgProduto.CurrentRow.Cells["descProduto"].Value.ToString();
            txtprecProduto.Text = dgProduto.CurrentRow.Cells["precProduto"].Value.ToString();
            txtdescontoPromocao.Text = dgProduto.CurrentRow.Cells["descontoPromocao"].Value.ToString();
            txtqtdMinEstoque.Text = dgProduto.CurrentRow.Cells["qtdMinEstoque"].Value.ToString();
            chkativoProduto.Checked = Convert.ToBoolean(dgProduto.CurrentRow.Cells["ativoProduto"].Value);
            txtnomeProduto.Text = dgProduto.CurrentRow.Cells["nomeProduto"].Value.ToString();
            txtidCategoria.Text = dgProduto.CurrentRow.Cells["nomeCategoria"].Value.ToString();
            idCategoria = Convert.ToInt32(dgProduto.CurrentRow.Cells["idCategoria"].Value.ToString());


            if ((dgProduto.SelectedRows[0].Cells["imagem"].Value) != null)
            {
                imagem = (byte[])dgProduto.CurrentRow.Cells["imagem"].Value;
                mostraFoto((byte[])dgProduto.CurrentRow.Cells["imagem"].Value);
                

            }
            else
            {
                imgImagem.Image = null;
            }
            
           
            validar = true;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            clsProduto P = new clsProduto();
            try
            {
                if (validar == false || txtnomeProduto.Text != ProdutoSelecionado.nomeProduto || txtdescProduto.Text != ProdutoSelecionado.descProduto || Convert.ToDecimal(txtprecProduto.Text) != ProdutoSelecionado.precProduto || Convert.ToDecimal(txtdescontoPromocao.Text) != ProdutoSelecionado.descontoPromocao || idCategoria != ProdutoSelecionado.idCategoria || chkativoProduto.Checked != ProdutoSelecionado.ativoProduto || userLog.idUsuario != ProdutoSelecionado.idUsuario || Convert.ToInt32(txtqtdMinEstoque.Text) != ProdutoSelecionado.qtdMinEstoque || Convert.ToBoolean((imagem == null ? new byte[0] : imagem) != ProdutoSelecionado.imagem))
                {


                    retorno = P.Salvar(0, txtnomeProduto.Text, txtdescProduto.Text, Convert.ToDecimal(txtprecProduto.Text), Convert.ToDecimal(txtdescontoPromocao.Text), Convert.ToInt32(txtidCategoria.SelectedValue), chkativoProduto.Checked, userLog.idUsuario, Convert.ToInt32(txtqtdMinEstoque.Text), imagem);

                    int idProduto = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnomeProduto.Text = null;
                    txtdescProduto.Text = null;
                    txtprecProduto.Text = null;
                    txtdescontoPromocao.Text = null;
                    txtqtdMinEstoque.Text = null;
                    chkativoProduto.Checked = false;
                    txtidCategoria.Text = null;
                    imgImagem.Image = null;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  \n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            atualizarDgProduto();
        }
        public void UpdateCategoria()
        {
            clsCategoria C = new clsCategoria();
            List<clsCategoria> Categoria = clsCategoria.GetUCategoria(Convert.ToString(txtidCategoria.Text));
            //txtidCategoria.DataSource = C.GetUCategoria(Convert.ToString(txtidCategoria));
            txtidCategoria.ValueMember = "idCategoria";
            txtidCategoria.DisplayMember = "nomeCategoria";
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

        private void button1_Click(object sender, EventArgs e)
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
                clsProduto ProdutoSelecionado = new clsProduto();
                clsProduto P = new clsProduto();
                 try
                 {       
                
                if (txtnomeProduto.Text != ProdutoSelecionado.nomeProduto || txtdescProduto.Text != ProdutoSelecionado.descProduto || Convert.ToDecimal(txtprecProduto.Text) != ProdutoSelecionado.precProduto || Convert.ToDecimal(txtdescontoPromocao.Text) != ProdutoSelecionado.descontoPromocao || idCategoria != ProdutoSelecionado.idCategoria || chkativoProduto.Checked != ProdutoSelecionado.ativoProduto || userLog.idUsuario != ProdutoSelecionado.idUsuario || Convert.ToInt32(txtqtdMinEstoque.Text) != ProdutoSelecionado.qtdMinEstoque || Convert.ToBoolean((imagem == null?new byte[0]:imagem) != ProdutoSelecionado.imagem))
                    {
                        retorno = P.Salvar(Convert.ToInt32(txtIdProduto.Text), txtnomeProduto.Text, txtdescProduto.Text, Convert.ToDecimal(txtprecProduto.Text), Convert.ToDecimal(txtdescontoPromocao.Text), idCategoria, chkativoProduto.Checked, userLog.idUsuario, Convert.ToInt32(txtqtdMinEstoque.Text), imagem);

                        int idProduto = Convert.ToInt32(retorno);
                        MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtIdProduto.Text = null;
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
                    else
                    {
                        MessageBox.Show("Nada foi alterado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return;
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtIdProduto.Text = null;
            txtnomeProduto.Text = null;
            txtdescProduto.Text = null;
            txtprecProduto.Text = null;
            txtdescontoPromocao.Text = null;
            txtqtdMinEstoque.Text = null;
            chkativoProduto.Checked = false;
            txtidCategoria.Text = null;
            imgImagem.Image = null;
        }

        private void txtnomeProduto_TextChanged_1(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtnomeProduto.Text) && txtnomeProduto.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnomeProduto.Text = "";
            }
        }

        private void txtqtdMinEstoque_TextChanged_1(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidarNumero(txtqtdMinEstoque.Text) && txtqtdMinEstoque.Text != "")
            {
                MessageBox.Show("Somente números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtqtdMinEstoque.Text = "";
            }
        }

        private void txtprecProduto_TextChanged_1(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidarNumero(txtprecProduto.Text) && txtprecProduto.Text != "")
            {
                MessageBox.Show("Somente números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtprecProduto.Text = "";
            }
        }

        private void txtdescontoPromocao_TextChanged_1(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidarNumero(txtdescontoPromocao.Text) && txtdescontoPromocao.Text != "")
            {
                MessageBox.Show("Somente números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescontoPromocao.Text = "";
            }
        }

        private void txtdescProduto_TextChanged_1(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtdescProduto.Text) && txtdescProduto.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtdescProduto.Text = "";
            }
        }
    }
}
