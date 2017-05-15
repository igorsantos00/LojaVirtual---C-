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

        public void configuraDgCategoria()
        {

            dgCategoria.Columns[0].HeaderText = "Código";
            dgCategoria.Columns[1].HeaderText = "Nome";
            dgCategoria.Columns[2].HeaderText = "Descrição";

            //Redimenciona o Tamanho da Coluna

            dgCategoria.Columns[0].Width = 50;
            dgCategoria.Columns[1].Width = 100;
            dgCategoria.Columns[2].Width = 100;

        }

        public void atualizarDgCategoria() {

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
            if (txtIdCategoria.Text.Equals(""))
            {
                MessageBox.Show("Informar a Categoria!");
            }
            else
            {
                if (txtNomeCategoria.Text.Equals(""))
                {
                    MessageBox.Show("Informar Nome!");
                }
                else
                {
                    if (txtDescCategoria.Text.Equals(""))
                    {
                        MessageBox.Show("Informar Descrição!");
                    }
                    else
                    {
                        MessageBox.Show("Dados Conformados!");
                        txtIdCategoria.Text = "";
                        txtNomeCategoria.Text = "";
                        txtDescCategoria.Text = "";
                    }
                }

            }
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
            int valida = C.Salvar(txtNomeCategoria.Text, txtDescCategoria.Text);
            if (valida >= 1)
            {
                MessageBox.Show("Inserido com sucesso");
            }
            else {

                MessageBox.Show("Erro verifique os campos");
            }

            atualizarDgCategoria();
        }

        private void btnSelecionar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
