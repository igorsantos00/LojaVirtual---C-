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
            InitializeComponent();
            mnuPrincipal.Enabled = false;
        }


        private void frnTeste2_Click(object sender, EventArgs e)
        {
            Form tela = new frmUsuario();
            tela.ShowDialog();
            //this.Close();
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

        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mnuPrincipal.Enabled = false;     
        }


        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form tela = new frmCategoria();
            tela.ShowDialog();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tela = new frmPedido();
            tela.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
