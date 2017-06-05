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
        private bool validar = false;

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
                MessageBox.Show("Nenhum Usuário selecionado");
                return;
            }


            UsuarioSelecionado = (dgUsuario.SelectedRows[0].DataBoundItem as clsUsuario);

            //Inserindo os valores nos campos

            txtNomeCompleto.Text = UsuarioSelecionado.nomeUsuario;
            txtLogin.Text = UsuarioSelecionado.loginUsuario;
            cmbTipo.Text = UsuarioSelecionado.tipoPerfil;
            txtSenha1.Text = UsuarioSelecionado.senhaUsuario;
            txtSenha2.Text = UsuarioSelecionado.senhaUsuario;
            ckAtivo.Text = Convert.ToString(UsuarioSelecionado.usuarioAtivo);
            ckAtivo.Checked = Convert.ToBoolean(dgUsuario.CurrentRow.Cells["usuarioAtivo"].Value);
            validar = true;
        }

        private void btnExcluirUsuario_Click(object sender, EventArgs e)
        {
            //Verifica se tem algum registro selecionado

            if (validar == false)
            {
                MessageBox.Show("Nenhum Usuário selecionado");
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
                int idCategoria = Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = null;
                txtNomeCompleto.Text = null;
                txtSenha1.Text = null;
                txtSenha2.Text = null;
                cmbTipo.Text = null;
                ckAtivo.Checked = false;
                validar = false;
                atualizarDgUsuario();

            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                validar = true;
                return;
            }

        }

        private void btnInserirUsuario_Click(object sender, EventArgs e)
        {
            clsUsuario U = new clsUsuario();
            try
            {
                if (U.VerificarUsuario(txtLogin.Text) || txtLogin.Text == "")
                {
                    MessageBox.Show("Campo 'Login' inválido", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (txtSenha1.Text == "")
                {
                    MessageBox.Show("Qual a senha", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha1.Text = "";
                    txtSenha2.Text = "";
                    return;
                }
                if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("Senhas não correspondentes", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha2.Text = "";
                    return;
                }
                if (cmbTipo.Text == null)
                {
                    MessageBox.Show("Qual o Tipo do usuário", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
               

                if (validar == false || txtLogin.Text != UsuarioSelecionado.loginUsuario)
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
                    validar = false;
                    atualizarDgUsuario();

                }
                else
                {
                    MessageBox.Show("Dados existente", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }

        private void btnAlterarUsuario_Click(object sender, EventArgs e)
        {
            if (validar == false)
            {
                MessageBox.Show("Nenhum Usuário selecionado");
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
                if (txtSenha1.Text == "")
                {
                    MessageBox.Show("Senha não pode ser em branco", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha1.Text = "";
                    txtSenha2.Text = "";
                    return;
                }
                if (txtSenha1.Text != txtSenha2.Text)
                {
                    MessageBox.Show("Senhas não correspondentes", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha2.Text = "";
                    return;
                }
               
                clsUsuario C = new clsUsuario();
                try
                {
                    if (txtLogin.Text != UsuarioSelecionado.loginUsuario || txtNomeCompleto.Text != UsuarioSelecionado.nomeUsuario || txtSenha1.Text != UsuarioSelecionado.senhaUsuario || cmbTipo.Text != UsuarioSelecionado.tipoPerfil || ckAtivo.Checked != UsuarioSelecionado.usuarioAtivo)
                    {
                        retorno = C.Salvar(UsuarioSelecionado.idUsuario, txtLogin.Text, txtSenha1.Text, txtNomeCompleto.Text, cmbTipo.Text, ckAtivo.Checked);

                        int idCategoria = Convert.ToInt32(retorno);
                        MessageBox.Show("Alterado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtLogin.Text = null;
                        txtNomeCompleto.Text = null;
                        txtSenha1.Text = null;
                        txtSenha2.Text = null;
                        cmbTipo.Text = null;
                        ckAtivo.Checked = false;
                        validar = false;
                        atualizarDgUsuario();
                    }
                    else
                    {
                        MessageBox.Show("Nada foi alterado", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro verifique os campos  /n Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void dgUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimparUsuario_Click(object sender, EventArgs e)
        {
            txtLogin.Text = null;
            txtNomeCompleto.Text = null;
            txtSenha1.Text = null;
            txtSenha2.Text = null;
            cmbTipo.Text = null;
            ckAtivo.Checked = false;
            validar = false;
        }

        private void txtNomeUsuario_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtNomeUsuario.Text) && txtNomeUsuario.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeUsuario.Text = "";
            }
        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtNomeCompleto.Text) && txtNomeCompleto.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCompleto.Text = "";
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            clsVerifica v = new clsVerifica();

            if (!v.ValidaLetras(txtLogin.Text) && txtLogin.Text != "")
            {
                MessageBox.Show("Primeira tem que ser letra", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLogin.Text = "";
            }
        }
    }
}
