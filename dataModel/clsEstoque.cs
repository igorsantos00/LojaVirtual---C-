using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataModel
{
    public class clsEstoque
    {
        public int idProduto { get; set; }
        public string nomeProduto { get; set; }
        public int qtdProdutoDisponivel { get; set; }

        private static clsEstoque referencia;

        public static clsEstoque getInstance()
        {
            if (referencia == null)
                referencia = new clsEstoque();

            return referencia;
        }

        public int Salvar(int nomeProduto, int qtdProdutoDisponivel)
        {
            int linhas = 0;
            try
            {
                int inserir = idProduto;

                clsConexao conexao = new clsConexao();
                SqlConnection cn = conexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                if (inserir == 0)
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

                if (inserir == 0)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT @@Identity";
                    this.idProduto = Convert.ToInt32(cmd.ExecuteScalar());
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

        public static List<clsEstoque> SelecionarEstoque()
        {
            string sql = "SELECT e.idProduto, p.nomeProduto, e.qtdProdutoDisponivel FROM dbo.Estoque as e"+ 
                "inner join dbo.Produto as p where e.idProduto = p.idProduto";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsEstoque> Estoque = new List<clsEstoque>();
            while (dr.Read())
            {

                clsEstoque E = new clsEstoque();
                if (!dr.IsDBNull(dr.GetOrdinal("idProduto")))
                {
                    E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("nomeProduto")))
                {
                    E.nomeProduto = dr.GetString(dr.GetOrdinal("nomeProduto"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("qtdProdutoDisponive")))
                {
                    E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                }

                Estoque.Add(E);
            }

            return Estoque;
        }


        public static List<clsEstoque> SelecionarEstoqueID(int idProduto)
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
                if (!dr.IsDBNull(dr.GetOrdinal("idProduto")))
                {
                    E.idProduto = dr.GetInt32(dr.GetOrdinal("idProduto"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("qtdProdutoDisponivel")))
                {
                    E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                }

                Estoque.Add(E);
            }

            return Estoque;
        }

    }
}

           
