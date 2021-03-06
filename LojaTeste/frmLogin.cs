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
using System.Data.SqlClient;

namespace LojaTeste
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                clsUsuario log = new clsUsuario();

                log = log.Logar(txtLogin.Text, txtSenha.Text);
               
                if (log != null)
                {
                    bool ativo = Convert.ToBoolean(log.usuarioAtivo);
                    if (ativo == false)
                    {
                        MessageBox.Show("Usuário desativado, contate o administrador!");
                        return;
                    }
                    MessageBox.Show("Seja bem vindo!");
                   
                    Form tela = new frmMenuPrincipal(log, this);
                    this.Hide();
                    tela.Show();
                }
                else
                {

                    MessageBox.Show("Login ou Senha inválido!");
                    txtSenha.Text = "";
                }
            }
            catch (SqlException sx)
            {

                MessageBox.Show("Tente novamente");
                
            }
            catch (ConexaoException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Obrigado por usar nosso sistema!");
            this.Close();
            this.Hide();
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
