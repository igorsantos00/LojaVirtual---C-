using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using dataModel;

namespace LojaTeste
{
    public partial class frmProduto : Form
    {
        public class clsProduto
        {
            public int txtidProduto { get; set; }
            public string txtnomeProduto { get; set; }
            public string txtdescProduto { get; set; }
            public decimal txtprecProduto { get; set; }
            public decimal txtdescontoPromocao { get; set; }
            public int txtidCategoria { get; set; }
            public string txtativoProduto { get; set; }
            public int txtidUsuario { get; set; }
            public int txtqtdMinEstoque { get; set; }
            public int txtimagem { get; set; }

            //Faz desse objeto um Singleton.
            private static clsProduto referencia;

            public static clsProduto getInstance()
            {
                if (referencia == null)
                    referencia = new clsProduto();

                return referencia;
            }

            public void Salvar()
            {
                bool inserir = (this.txtidProduto == 0);

                SqlConnection cn = clsConexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                if (inserir)
                    cmd.CommandText = "INSERT INTO Produto " +
                                    "(nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem)" +
                                    "VALUES " +
                                    "(@txtnomeProduto, @txtdescProduto, @txtprecProduto, @txtdescontoPromocao, @txtidCategoria, @txtativoProduto, @txtidUsuario, @txtqtdMinEstoque, @txtimagem)";
                else
                {
                    cmd.CommandText = "UPDATE Produto " +
                                        "SET nomeProduto      = @txtnomeProduto, " +
                                            "descProduto      = @txtdescProduto, " +
                                            "prescProduto     = @txtprescProduto, " +
                                            "descontoPromocao = @txtdescontoPromocao, " +
                                            "idCategoria      = @txtidCategoria, " +
                                            "ativoProduto     = @txtativoProduto, " +
                                            "idUsuario        = @txtidUsuario, " +
                                            "qtdMinEstoque    = @txtqtdMinEstoque, " +
                                            "imagem           = @txtimagem " +
                                            "WHERE idProduto  = @txtidProduto";

                    cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = txtidProduto;
                }

                cmd.Parameters.Add("@txtnomeProduto", SqlDbType.VarChar, 70).Value = this.txtnomeProduto;
                cmd.Parameters.Add("@txtdescProduto", SqlDbType.VarChar, 500).Value = this.txtdescProduto;
                cmd.Parameters.Add("@txtprecProduto", SqlDbType.Int).Value = this.txtprecProduto;
                cmd.Parameters.Add("@txtdescontoPromocao", SqlDbType.Money).Value = this.txtdescontoPromocao;
                cmd.Parameters.Add("@txtidCategoria", SqlDbType.Int).Value = this.txtidCategoria;
                cmd.Parameters.Add("@txtativoProduto", SqlDbType.VarChar, 1).Value = this.txtativoProduto;
                cmd.Parameters.Add("@txtidUsuario", SqlDbType.Int).Value = this.txtidUsuario;
                cmd.Parameters.Add("@txtqtdMinEstoque", SqlDbType.Int).Value = this.txtqtdMinEstoque;
                cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = this.txtimagem;
                cmd.ExecuteNonQuery();

                if (inserir)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT @@Identity";
                    this.txtidProduto = Convert.ToInt32(cmd.ExecuteScalar());
                }

                cn.Close();
                cn.Dispose();
            }

            public static List<clsProduto> SelecionarProduto()
            {
                string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem FROM dbo.Produto";
                SqlConnection cn = clsConexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader dr = cmd.ExecuteReader();
                List<clsProduto> Produto = new List<clsProduto>();
                while (dr.Read())
                {
                    clsProduto C = new clsProduto();
                    C.txtidProduto        = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    C.txtnomeProduto      = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    C.txtdescProduto      = dr.GetString(dr.GetOrdinal("descProduto"));
                    C.txtprecProduto      = dr.GetInt32(dr.GetOrdinal("precProduto"));
                    C.txtdescontoPromocao = dr.GetInt32(dr.GetOrdinal("descontoPromocao"));
                    C.txtidCategoria      = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                    C.txtativoProduto     = dr.GetString(dr.GetOrdinal("ativoProduto"));
                    C.txtidUsuario        = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                    C.txtqtdMinEstoque    = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                    C.txtimagem           = dr.GetInt32(dr.GetOrdinal("imagem"));
                    Produto.Add(C);
                }

                cn.Close();
                cn.Dispose();
                return Produto;

            }

            public static List<clsProduto> SelecionarProduto(int IdProduto)
            {
                string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem FROM dbo.Produto" +
                    "WHERE idProduto = @txtidProduto"; 
                SqlConnection cn = clsConexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;

                SqlDataReader dr = cmd.ExecuteReader();
                List<clsProduto> Produto = new List<clsProduto>();
                while (dr.Read())
                {
                    clsProduto C = new clsProduto();
                    C.txtidProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                    C.txtnomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                    C.txtdescProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                    C.txtprecProduto = dr.GetInt32(dr.GetOrdinal("precProduto"));
                    C.txtdescontoPromocao = dr.GetInt32(dr.GetOrdinal("descontoPromocao"));
                    C.txtidCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                    C.txtativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                    C.txtidUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                    C.txtqtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                    C.txtimagem = dr.GetInt32(dr.GetOrdinal("imagem"));
                    Produto.Add(C);
                }

                cn.Close();
                cn.Dispose();
                return Produto;

            }


        }
        public frmProduto()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
