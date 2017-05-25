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
using System.Data.SqlClient;

namespace LojaTeste
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private clsUsuario UsuarioSelecionado;
        private int retorno;
        private bool validar;

        private void configuraDgUsuario()
        {

            dgUsuario.Columns[0].HeaderText = "Código";
            dgUsuario.Columns[1].HeaderText = "Login";
            dgUsuario.Columns[2].HeaderText = "Nome";
            dgUsuario.Columns[4].HeaderText = "Perfil";
            dgUsuario.Columns[5].HeaderText = "Ativo";

            //Redimenciona o Tamanho da Coluna

            dgUsuario.Columns[0].Width = 50;
            dgUsuario.Columns[1].Width = 225;
            dgUsuario.Columns[2].Visible = false;
            dgUsuario.Columns[3].Width = 225;
            dgUsuario.Columns[4].Width = 45;
            dgUsuario.Columns[5].Width = 45;
        }

        private void atualizarDgUsuario()
        {

            List<clsUsuario> Usuario = clsUsuario.SelecionarUsuario();
            dgUsuario.DataSource = Usuario;
            configuraDgUsuario();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSairUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text.Equals(""))
            {
                atualizarDgUsuario();
            }
            else
            {
                List<clsUsuario> Usuario = clsUsuario.SelecionarUsuarioPorNome (txtNomeUsuario.Text);
                dgUsuario.DataSource = Usuario;
                configuraDgUsuario();
                atualizarDgUsuario();
            }

        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            atualizarDgUsuario();
        }

        private void btnSelecionarUsuario_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma categoria selecionada");
                return;
            }


            UsuarioSelecionado = (dgUsuario.SelectedRows[0].DataBoundItem as clsUsuario);

            //Inserindo os valores nos campos

            txtNomeUsuario.Text = UsuarioSelecionado.nomeUsuario;
            txtLogin.Text = UsuarioSelecionado.loginUsuario;
            //txtSenha1.Text = UsuarioSelecionado.senhaUsuario
            cmbTipo.Text = UsuarioSelecionado.tipoPerfil;
            cbmAtivo.Text = Convert.ToString(UsuarioSelecionado.usuarioAtivo);
            validar = false;
        }
    }
}
