using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataModel
{
    class clsEstoque
    {
        public int idProduto { get; set; }
        public int qtdProdutoDisponivel { get; set; }
        
        
        private static clsEstoque referencia;

        public static clsEstoque getInstance()
        {
            if (referencia == null)
                referencia = new clsEstoque();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idProduto == 0);

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Estoque " +
                                "(idProduto, qtdProdutoDisponivel)" +
                                "VALUES " +
                                "(@idProduto, @qtdProdutoDisponivel)";
            else
            {
                cmd.CommandText = "UPDATE Estoque " +
                                    "SET qtdProdutoDisponivel = @qtdProdutoDisponivel";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;
            }
                        
            cmd.Parameters.Add("@qtdProdutoDisponivel", SqlDbType.Int).Value = this.qtdProdutoDisponivel;
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

        public static List<clsEstoque> SelecionarCategoria()
        {
            string sql = "SELECT idProduto, qtdProdutoDisponivel FROM dbo.Estoque";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                Estoque.Add(E);
            }

            return Estoque;
        }

        public static List<clsEstoque> SelecionarCategoria(int idProduto)
        {
            string sql = "SELECT idProduto, qtdProdutoDisponivel FROM dbo.Estoque " +
                "WHERE idProduto = @idProduto";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@idProduto", SqlDbType.Int).Value = idProduto;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {
                clsEstoque E = new clsEstoque();
                E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                Estoque.Add(E);
            }

            return Estoque;
        }
    }
}
