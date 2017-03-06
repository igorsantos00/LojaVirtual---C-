using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaTeste
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            
        }

        public frmMenuPrincipal(string text)
        {
            InitializeComponent();
            lblLogin.Text = text;
        }

        private void frnTeste2_Click(object sender, EventArgs e)
        {
            Form tela = new frmUsuario();
            tela.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tela = new frmUsuario();
            tela.ShowDialog();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            //teste
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form tela = new ();
            //tela.ShowDialog();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tela = new frmPedido();
            tela.ShowDialog();
        }

        private void imgUsuario_Click(object sender, EventArgs e)
        {
            Form tela = new frmUsuario();
            tela.ShowDialog();
        }

        private void imgCategoria_Click(object sender, EventArgs e)
        {
            //Form tela = new frmCategoria();
            //tela.ShowDialog();
        }

        private void imgProduto_Click(object sender, EventArgs e)
        {
            Form tela = new frmProduto();
            tela.ShowDialog();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            Form tela = new frmCliente();
            tela.ShowDialog();
        }

        private void imgStatusPedido_Click(object sender, EventArgs e)
        {
            Form tela = new frmStatusPedido();
            tela.ShowDialog();
        }

        private void imgTipoPagamento_Click(object sender, EventArgs e)
        {
            Form tela = new frmTipoPagamento();
            tela.ShowDialog();
        }

        private void imgEstoque_Click(object sender, EventArgs e)
        {
            //Form tela = new frmEstoque();
            //tela.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //Form tela = new frmPedido();
            //tela.ShowDialog();
        }
    }
}
