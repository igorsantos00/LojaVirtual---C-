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
        private bool validar = false;

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
                txtIdCategoria.Text = "";
                configuraDgCategoria();
            }
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            atualizarDgCategoria();
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            if (validar == false)
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
                    if (txtNomeCategoria.Text != CategoriaSelecionada.nomeCategoria || txtDescCategoria.Text != CategoriaSelecionada.descCategoria)
                    {
                        retorno = C.Salvar(CategoriaSelecionada.idCategoria, txtNomeCategoria.Text, txtDescCategoria.Text);

                        int idCategoria = Convert.ToInt32(retorno);
                        MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomeCategoria.Text = null;
                        txtDescCategoria.Text = null;
                        validar = false;
                        atualizarDgCategoria();
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            clsCategoria C = new clsCategoria();
            try
            {
                if (txtNomeCategoria.Text == "")
                {
                    MessageBox.Show("Campo 'Nome' invalido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (validar == false || txtNomeCategoria.Text != CategoriaSelecionada.nomeCategoria || txtDescCategoria.Text != CategoriaSelecionada.descCategoria)
                {
                    retorno = C.Salvar(0, txtNomeCategoria.Text, txtDescCategoria.Text);

                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNomeCategoria.Text = null;
                    txtDescCategoria.Text = null;
                    validar = false;
                    atualizarDgCategoria();
                }
                else
                {
                    MessageBox.Show("Dados existente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (validar == false)
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
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCategoria.Text = null;
                txtDescCategoria.Text = null;
                validar = false;
                atualizarDgCategoria();

            }
            catch (SqlException)
            {
                MessageBox.Show("Erro  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = true;
                return;
            }

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
            validar = true;
        }

        private void dgCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clsCategoria CategoriaSelecionada = new clsCategoria();
            CategoriaSelecionada = (dgCategoria.SelectedRows[0].DataBoundItem as clsCategoria);

            //Inserindo os valores nos campos

            txtNomeCategoria.Text = dgCategoria.CurrentRow.Cells["nomeCategoria"].Value.ToString();
            txtDescCategoria.Text = dgCategoria.CurrentRow.Cells["descCategoria"].Value.ToString();
            validar = true;
        }

        private void txtNomeCategoria_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtNomeCategoria.Text) && txtNomeCategoria.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCategoria.Text = "";
            }
        }

        private void txtDescCategoria_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtDescCategoria.Text) && txtDescCategoria.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescCategoria.Text = "";
            }
        }

        private void txtIdCategoria_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidarNumero(txtIdCategoria.Text) && txtIdCategoria.Text != "")
            {
                MessageBox.Show("Somente números", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdCategoria.Text = "";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDescCategoria.Text = null;
            txtIdCategoria.Text = null;
            txtNomeCategoria.Text = null;
        }
    }
}