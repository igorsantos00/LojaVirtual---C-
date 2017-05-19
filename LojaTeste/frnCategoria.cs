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



    public partial class frmCategoria : Form
    {
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
            dgCategoria.Columns[1].Width = 150;
            dgCategoria.Columns[2].Width = 347;

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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {


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

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            clsCategoria C = new clsCategoria();
            string retorno = C.Salvar(txtNomeCategoria.Text, txtDescCategoria.Text);
            try
            {
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Inserido com sucesso" + retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult resultado = MessageBox.Show("Deseja excluir", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            clsCategoria CategoriaSelecionada = (dgCategoria.SelectedRows[0].DataBoundItem as clsCategoria);

            //Instância a class, e chama o método de excluir
            clsCategoria C = new clsCategoria();
            string retorno = C.ExcluirCategorias(CategoriaSelecionada.idCategoria);

            //Verificando se deu certo
            try
            {
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Inserido com sucesso" + retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                atualizarDgCategoria();
            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }




        }
    }
}
