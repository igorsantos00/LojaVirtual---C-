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



    public partial class frmCategoria : Form
    {
        private clsCategoria CategoriaSelecionada;
        private int retorno;
        private bool validar = true;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void configuraDgCategoria()
        {

            dgCategoria.Columns[0].HeaderText = "Código";
            dgCategoria.Columns[1].HeaderText = "Nome";
            dgCategoria.Columns[2].HeaderText = "Descrição";

            //Redimenciona o Tamanho da Coluna

            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[1].Width = 190;
            dgCategoria.Columns[2].Width = 346;

        }

        private void atualizarDgCategoria()
        {

            List<clsCategoria> Categoria = clsCategoria.SelecionarCategoria();
            dgCategoria.DataSource = Categoria;
            configuraDgCategoria();

        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtIdCategoria.Text.Equals(""))
            {
                atualizarDgCategoria();
            }
            else
            {
                List<clsCategoria> Categoria = clsCategoria.SelecionarCategoriaID(Convert.ToInt32(txtIdCategoria.Text));
                dgCategoria.DataSource = Categoria;
                configuraDgCategoria();
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            atualizarDgCategoria();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
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
                clsCategoria C = new clsCategoria();
                try
                {
                    retorno = C.Salvar(CategoriaSelecionada.idCategoria, txtNomeCategoria.Text, txtDescCategoria.Text);
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCategoria.Text = null;
                    txtDescCategoria.Text = null;
                    validar = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                atualizarDgCategoria();
            }

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            clsCategoria C = new clsCategoria();
            try
            {
                retorno = C.Salvar(0, txtNomeCategoria.Text, txtDescCategoria.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txtNomeCategoria.Text == "")
            {
                MessageBox.Show("Campo 'Nome' invalido");
                return;
            }
            try
            {
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCategoria.Text = null;
                txtDescCategoria.Text = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }

            atualizarDgCategoria();

        }
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionada");
                return;
            }

            //Pergunta se quer mesmo excluir
            DialogResult resultado = MessageBox.Show("Deseja excluir " + dgCategoria.SelectedRows[0].Cells["nomeCategoria"].Value, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            clsCategoria CategoriaSelecionada = (dgCategoria.SelectedRows[0].DataBoundItem as clsCategoria);

            //Instância a class, e chama o método de excluir
            clsCategoria C = new clsCategoria();

            try
            {
                retorno = C.ExcluirCategorias(CategoriaSelecionada.idCategoria);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificando se deu certo
            if (retorno != 0)
            {
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else

            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            atualizarDgCategoria();

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionada");
                return;
            }


            CategoriaSelecionada = (dgCategoria.SelectedRows[0].DataBoundItem as clsCategoria);

            //Inserindo os valores nos campos

            txtNomeCategoria.Text = CategoriaSelecionada.nomeCategoria;
            txtDescCategoria.Text = CategoriaSelecionada.descCategoria;
            validar = false;
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgCategoria.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionada");
                return;
            }


            CategoriaSelecionada = (dgCategoria.SelectedRows[0].DataBoundItem as clsCategoria);

            //Inserindo os valores nos campos

            txtNomeCategoria.Text = CategoriaSelecionada.nomeCategoria;
            txtDescCategoria.Text = CategoriaSelecionada.descCategoria;
            validar = false;
        }
    }
}