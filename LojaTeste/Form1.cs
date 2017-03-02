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

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals(""))
            {
                MessageBox.Show("Informe o login!");
            }
            else
            {
                if(txtSenha.Text.Equals(""))
                {
                    MessageBox.Show("Informe a senha!");
                }
                else
                {
                    //Verifica usuário e senha implantar verificação no BD
                    if(txtLogin.Text.Equals("suporte") && txtSenha.Text.Equals("suporte"))
                    {
                        mnuPrincipal.Enabled = true;
                        MessageBox.Show("Seja bem vindo!");
                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha não válido!");
                    }
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtLogin.Text = "";
            txtSenha.Text = "";
            mnuPrincipal.Enabled = false;
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar nosso sistema!");
            this.Close();
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
    }
}
