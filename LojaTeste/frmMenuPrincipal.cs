﻿using System;
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

        //public frmMenuPrincipal()
        //{
        //    InitializeComponent();
        //    Form login = new frmLogin();
        //    login.ShowDialog();

        //}



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


        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void imgProduto_Click(object sender, EventArgs e)
        {
            Form tela = new frmProduto(userLog);
            tela.ShowDialog();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja fazer logoff?");
            //Form Tela1 = new frmLogin();
            //Tela1.Show();
            this.Hide();
            //Form frmMenuPrincipal = new frmMenuPrincipal();
            //frmMenuPrincipal.Show();
            login.Show();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Form tela = new frmEstoque();
            tela.ShowDialog();
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
            Form tela = new frmEstoque();
            tela.ShowDialog();
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


        private void frmMenuPrincipal_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_TextChanged(object sender, EventArgs e)
        {
            lblLogin.Text = userLog.nomeUsuario;
        }

        private void frmMenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            login.Dispose();
        }
    }
}
