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
        public frmMenuPrincipal()
        {
            InitializeComponent();
            Form login = new frmLogin();
            login.ShowDialog();
        }

        public frmMenuPrincipal(string text)
        {
            InitializeComponent();
            lblLogin.Text = text;
            timer1.Enabled = true;
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
            //teste
        }



        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      
        private void imgProduto_Click(object sender, EventArgs e)
        {
            Form tela = new frmProduto();
            tela.ShowDialog();
        }

        private void imgCliente_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja fazer logoff?");
            Form Tela1 = new frmLogin();
            Tela1.Show();
            this.Hide();
            Form frmMenuPrincipal = new frmMenuPrincipal();
            frmMenuPrincipal.Show();
            
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
            Form tela = new frmUsuario();
            tela.ShowDialog();
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            Form tela = new frmCategoria();
            tela.ShowDialog();
        }

        private void Estoque_Click(object sender, EventArgs e)
        {
            Form tela = new frmEstoque();
            tela.ShowDialog();
        }

        private void Produto_Click(object sender, EventArgs e)
        {
            Form tela = new frmProduto();
            tela.ShowDialog();
        }
    }
}
