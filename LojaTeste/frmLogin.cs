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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
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
                if (txtSenha.Text.Equals(""))
                {
                    MessageBox.Show("Informe a senha!");
                }
                else
                {
                    //Verifica usuário e senha implantar verificação no BD
                    if (txtLogin.Text.Equals("suporte") && txtSenha.Text.Equals("suporte"))
                    {
                        MessageBox.Show("Seja bem vindo!");
                        Form tela = new frmMenuPrincipal(txtLogin.Text);
                        this.Hide();
                        tela.Show();


                    }
                    else
                    {
                        MessageBox.Show("Login ou Senha não válido!");
                        
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar nosso sistema!");
            this.Close();
            this.Hide();
        }
    }
}
