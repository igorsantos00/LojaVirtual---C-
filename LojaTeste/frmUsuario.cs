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
                List<clsUsuario> Usuario = clsUsuario.SelecionarUsuarioPorNome(txtNomeUsuario.Text);
                dgUsuario.DataSource = Usuario;
                txtNomeUsuario.Text = "";
                dgUsuario.Refresh();
               
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

            txtNomeCompleto.Text = UsuarioSelecionado.nomeUsuario;
            txtLogin.Text = UsuarioSelecionado.loginUsuario;
            cmbTipo.Text = UsuarioSelecionado.tipoPerfil;
            ckAtivo.Text = Convert.ToString(UsuarioSelecionado.usuarioAtivo);
            ckAtivo.Checked = Convert.ToBoolean(dgUsuario.CurrentRow.Cells["usuarioAtivo"].Value);
            validar = false;
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado
            if (dgUsuario.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Usuario selecionado");
                return;
            }

            //Pergunta se quer mesmo excluir
            DialogResult resultado = MessageBox.Show("Deseja excluir " + dgUsuario.SelectedRows[0].Cells["nomeUsuario"].Value, "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            clsUsuario CategoriaSelecionada = (dgUsuario.SelectedRows[0].DataBoundItem as clsUsuario);

            //Instância a class, e chama o método de excluir
            clsUsuario C = new clsUsuario();

            try
            {
                retorno = C.ExcluirUsuario(CategoriaSelecionada.idUsuario);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificando se deu certo
            if (retorno != 0)
            {
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Excluido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else

            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            atualizarDgUsuario();

        }

        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            clsUsuario U = new clsUsuario();
            try
            {
                retorno = U.Salvar(0, txtLogin.Text, txtSenha1.Text, txtNomeCompleto.Text, cmbTipo.Text, ckAtivo.Checked);

                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Inserido com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = null;
                txtNomeCompleto.Text = null;
                txtSenha1.Text = null;
                txtSenha2.Text = null;
                cmbTipo.Text = null;
                ckAtivo.Checked = false;



            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            atualizarDgUsuario();
        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            if (validar)
            {
                MessageBox.Show("Nenhum Usuario selecionado");
                return;
            }

            //Pergunta se quer mesmo Alterar
            DialogResult resultado = MessageBox.Show("Deseja Alterar", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }
            else
            {
                clsUsuario C = new clsUsuario();
                try
                {
                    retorno = C.Salvar(UsuarioSelecionado.idUsuario, txtLogin.Text, txtSenha1.Text, txtNomeCompleto.Text, cmbTipo.Text, ckAtivo.Checked);
                    txtLogin.Text = null;
                    txtNomeCompleto.Text = null;
                    txtSenha1.Text = null;
                    txtSenha2.Text = null;
                    cmbTipo.Text = null;
                    ckAtivo.Checked = false;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    int idCategoria = Convert.ToInt32(retorno);
                    MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    validar = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atencão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }

                atualizarDgUsuario();
            }
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
