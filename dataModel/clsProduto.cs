using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace dataModel
{
    
    public class clsProduto
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public string descProduto { get; set; }
        public decimal precProduto { get; set; }
        public decimal descontoPromocao { get; set; }
        public int idCategoria { get; set; }
        public bool ativoProduto { get; set; }
        public int idUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public byte[] imagem { get; set; }

        public string nomeCategoria { get; set; }

        //Faz desse objeto um Singleton.

        private static clsProduto referencia;

        public static clsProduto getInstance()
        {
            if (referencia == null)
                referencia = new clsProduto();

            return referencia;
        }

        public int Salvar(int idProduto, string nomeProduto, string descProduto, decimal precProduto, decimal descontoPromocao, int idCategoria, bool ativoProduto, int idUsuario, int qtdMinEstoque, byte[] imagem)


        {

            int linhas = 0;
            try
            {

                int inserir = idProduto;



                clsConexao conexao = new clsConexao();
                SqlConnection cn = conexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                if (inserir == 0)
                    cmd.CommandText = "INSERT INTO Produto " +
                                    "(nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem)" +
                                    "VALUES " +
                                    "(@nomeProduto, @descProduto, @precProduto, @descontoPromocao, @idCategoria, @ativoProduto, @idUsuario, @qtdMinEstoque, @imagem);";
                else
                {
                    cmd.CommandText = "UPDATE Produto " +
                                        "SET nomeProduto      = @nomeProduto, " +
                                            "descProduto      = @descProduto, " +
                                            "precProduto      = @precProduto, " +
                                            "descontoPromocao = @descontoPromocao, " +
                                            "idCategoria      = @idCategoria, " +
                                            "ativoProduto     = @ativoProduto, " +
                                            "idUsuario        = @idUsuario, " +
                                            "qtdMinEstoque    = @qtdMinEstoque, " +
                                            "imagem           = @imagem " +
                                            "WHERE idProduto  = @idProduto";

                    cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
                }

                cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar, 70).Value = nomeProduto;
                cmd.Parameters.Add("@descProduto", SqlDbType.VarChar, 500).Value = descProduto;
                cmd.Parameters.Add("@precProduto", SqlDbType.Money).Value = precProduto;
                cmd.Parameters.Add("@descontoPromocao", SqlDbType.Money).Value = descontoPromocao;
                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                cmd.Parameters.Add("@ativoProduto", SqlDbType.Bit).Value = ativoProduto;
                cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = idUsuario;
                cmd.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = qtdMinEstoque;
                if (imagem == null)
                {
                    imagem = new byte[0];
                    cmd.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = imagem;
                }
                else
                {
                    cmd.Parameters.Add("@imagem", SqlDbType.Image, imagem.Length).Value = imagem;
                }
                
                cmd.ExecuteNonQuery();

                if (inserir == 0)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT @@Identity";
                    idProduto = Convert.ToInt32(cmd.ExecuteScalar());
                    linhas = cmd.ExecuteNonQuery();
                }

                cn.Close();
                cn.Dispose();
            }
            catch (SqlException ex)
            {

                Console.WriteLine("Erro \n" + ex.Message);
                throw;
            }


            return linhas;
          }

        public static List<clsProduto> SelecionarProduto()
        {
            string sql = "SELECT idProduto,nomeProduto,descProduto,precProduto,descontoPromocao,P.IDCategoria, nomeCategoria, ativoProduto = CONVERT(BIT,CASE WHEN ATIVOPRODUTO NOT IN (0,1) THEN 0 ELSE ATIVOPRODUTO END), idUsuario, qtdMinEstoque, imagem FROM dbo.Produto P INNER JOIN dbo.Categoria C ON P.idCategoria = C.idCategoria";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produto = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto C = new clsProduto();
                if (!dr.IsDBNull(dr.GetOrdinal("idProduto")))
                {
                    C.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("nomeProduto")))
                {
                    C.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("descProduto")))
                {
                    C.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("precProduto")))
                {
                    C.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("descontoPromocao")))
                {
                    C.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("ativoProduto")))
                {
                    C.ativoProduto = dr.GetBoolean(dr.GetOrdinal("ativoProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                {
                    C.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("qtdMinEstoque")))
                {
                    C.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("nomeCategoria")))
                {
                    C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                }
                if (dr["Imagem"] != DBNull.Value)
                    C.imagem = (byte[])dr["Imagem"];
                else
                    C.imagem = new byte[0];
                Produto.Add(C);
            }

            cn.Close();
            cn.Dispose();
            return Produto;

        }

        public static List<clsProduto> SelecionarProdutoID(int idProduto)
        {
            string sql = @"SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, P.idCategoria, nomeCategoria,  ativoProduto = CONVERT(BIT,CASE WHEN ATIVOPRODUTO NOT IN (0,1) THEN 0 ELSE ATIVOPRODUTO END), idUsuario, qtdMinEstoque FROM dbo.Produto P INNER JOIN dbo.Categoria C
                         ON P.idCategoria = C.idCategoria WHERE idProduto = @idProduto";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produto = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto C = new clsProduto();

                if (!dr.IsDBNull(dr.GetOrdinal("idProduto")))
                {
                    C.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("nomeProduto")))
                {
                    C.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("descProduto")))
                {
                    C.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("precProduto")))
                {
                    C.precProduto = dr.GetDecimal(dr.GetOrdinal("precProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("descontoPromocao")))
                {
                    C.descontoPromocao = dr.GetDecimal(dr.GetOrdinal("descontoPromocao"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("ativoProduto")))
                {
                    C.ativoProduto = dr.GetBoolean(dr.GetOrdinal("ativoProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                {
                    C.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("qtdMinEstoque")))
                {
                    C.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("nomeCategoria")))
                {
                    C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                }

                Produto.Add(C);
            }

            return Produto;
        }

        public int ExcluirProdutos(int idProduto)
        {

            string sql = "Delete FROM dbo.Produto " +
           "WHERE idProduto = @idProduto";
            

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            int linhas = cmd.ExecuteNonQuery();

            AtualizaEstoque();
            return linhas;

        }

        public void AtualizaEstoque()
        {
            string sql = "Delete FROM dbo.Estoque " +
           "WHERE idProduto = @idProduto";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            int linhas = cmd.ExecuteNonQuery();


            


        }


    }
}

