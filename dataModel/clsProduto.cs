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
        public string ativoProduto { get; set; }
        public int idUsuario { get; set; }
        public int qtdMinEstoque { get; set; }
        public int imagem { get; set; }

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
            bool inserir = (this.idProduto == 0);

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Produto " +
                                "(nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem)" +
                                "VALUES " +
                                "(@nomeProduto, @descProduto, @precProduto, @descontoPromocao, @idCategoria, @ativoProduto, @idUsuario, @qtdMinEstoque, @imagem)";
            else
            {
                cmd.CommandText = "UPDATE Produto " +
                                    "SET nomeProduto      = @nomeProduto, " +
                                        "descProduto      = @descProduto, " +
                                        "prescProduto     = @prescProduto, " +
                                        "descontoPromocao = @descontoPromocao, " +
                                        "idCategoria      = @idCategoria, " +
                                        "ativoProduto     = @ativoProduto, " +
                                        "idUsuario        = @idUsuario, " +
                                        "qtdMinEstoque    = @qtdMinEstoque, " +
                                        "imagem           = @imagem " +
                                        "WHERE idProduto  = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
            }

            cmd.Parameters.Add("@nomeProduto", SqlDbType.VarChar, 70).Value = this.nomeProduto;
            cmd.Parameters.Add("@descProduto", SqlDbType.VarChar, 500).Value = this.descProduto;
            cmd.Parameters.Add("@precProduto", SqlDbType.Int).Value = this.precProduto;
            cmd.Parameters.Add("@descontoPromocao", SqlDbType.Money).Value = this.descontoPromocao;
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = this.idCategoria;
            cmd.Parameters.Add("@ativoProduto", SqlDbType.VarChar, 1).Value = this.ativoProduto;
            cmd.Parameters.Add("@idUsuario", SqlDbType.Int).Value = this.idUsuario;
            cmd.Parameters.Add("@qtdMinEstoque", SqlDbType.Int).Value = this.qtdMinEstoque;
            cmd.Parameters.Add("@imagem", SqlDbType.Image).Value = this.imagem;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idProduto = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsProduto> SelecionarProduto()
        {
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem FROM dbo.Produto";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produto = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto C = new clsProduto();
                C.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                C.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                C.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                C.precProduto = dr.GetInt32(dr.GetOrdinal("precProduto"));
                C.descontoPromocao = dr.GetInt32(dr.GetOrdinal("descontoPromocao"));
                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                C.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                C.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                C.imagem = dr.GetInt32(dr.GetOrdinal("imagem"));
                Produto.Add(C);
            }

            cn.Close();
            cn.Dispose();
            return Produto;

        }

        public static List<clsProduto> SelecionarProduto(int IdProduto)
        {
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem FROM dbo.Produto" +
                "WHERE idProduto = @idProduto";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsProduto> Produto = new List<clsProduto>();
            while (dr.Read())
            {
                clsProduto C = new clsProduto();
                C.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                C.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                C.descProduto = dr.GetString(dr.GetOrdinal("descProduto"));
                C.precProduto = dr.GetInt32(dr.GetOrdinal("precProduto"));
                C.descontoPromocao = dr.GetInt32(dr.GetOrdinal("descontoPromocao"));
                C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                C.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                C.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                C.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                C.imagem = dr.GetInt32(dr.GetOrdinal("imagem"));
                Produto.Add(C);
            }

            cn.Close();
            cn.Dispose();
            return Produto;

        }
        public static List<clsProduto> SelecionarProdutoID(int idProduto)
        {
            string sql = "SELECT idProduto, nomeProduto, qtdMinEstoque, precProduto, idCategoria, descontoPromocao, ativoProduto imagem FROM dbo.Produto" +
                "WHERE idProduto = @idProduto";

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
                if (!dr.IsDBNull(dr.GetOrdinal("qtdMinEstoque")))
                {
                    C.qtdMinEstoque = dr.GetInt32(dr.GetOrdinal("qtdMinEstoque"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("precProduto")))
                {
                    C.precProduto = dr.GetInt32(dr.GetOrdinal("precProduto"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("descontoPromocao")))
                {
                    C.descontoPromocao = dr.GetInt32(dr.GetOrdinal("descontoPromocao"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("ativoProduto")))
                {
                    C.ativoProduto = dr.GetString(dr.GetOrdinal("ativoProduto"));
                }

                Produto.Add(C);
            }

            return Produto;
        }


    }

}

