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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals(""))
            {
                MessageBox.Show("Informar o Login!");
            }
            else
            {
                if (txtNomeCompleto.Text.Equals(""))
                {
                    MessageBox.Show("Informar Nome Completo!");
                }
                else
                {
                    if (txtSenha.Text.Equals(""))
                    {
                        MessageBox.Show("Informar a Senha!");
                    }
                    else
                    {
                        MessageBox.Show("Dados Confirmados!");

                    }
                }
            }
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
