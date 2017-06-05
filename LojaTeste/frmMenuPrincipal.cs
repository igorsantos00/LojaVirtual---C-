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
    public partial class frmMenuPrincipal : Form
    {

        private clsUsuario userLog;
        private frmLogin login;

        public frmMenuPrincipal(clsUsuario userLog, frmLogin login)
        {

            InitializeComponent();
            this.userLog = userLog;
            timer1.Enabled = true;
            this.login = login;
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
            if (userLog.tipoPerfil == "A")
            {
                Form tela = new frmUsuario();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Pergunta se quer mesmo fazer logoff
            DialogResult resultado = MessageBox.Show("Deseja Fazer Logoff? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            this.Hide();
            login.Show();
        }


        private void imgProduto_Click(object sender, EventArgs e)
        {
            Form tela = new frmProduto(userLog);
            tela.ShowDialog();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            //Pergunta se quer mesmo fazer logoff
            DialogResult resultado = MessageBox.Show("Deseja Fazer Logoff? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            this.Hide();
            login.Show();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }


        private void Usuario_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A")
            {
                Form tela = new frmUsuario();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A")
            {
                Form tela = new frmCategoria();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A" || userLog.tipoPerfil == "C")
            {
                Form tela = new frmEstoque();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Permissão Invalida, consulte o administrador", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Produto_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A")
            {
                Form tela = new frmProduto(userLog);
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void lblLogin_TextChanged(object sender, EventArgs e)
        {
            lblLogin.Text = userLog.nomeUsuario;
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Dispose();
        }



        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A" || userLog.tipoPerfil == "C")
            {
                Form tela = new frmEstoque();
                tela.ShowDialog();
            }

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A")
            {
                Form tela = new frmCategoria();
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userLog.tipoPerfil == "A")
            {
                Form tela = new frmProduto(userLog);
                tela.ShowDialog();
            }
            else
            {
                MessageBox.Show("Somente administrador", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
