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

        public int Salvar(int idProduto,  int qtdProdutoDisponivel)
        {
            int linhas = 0;
           


                clsConexao conexao = new clsConexao();
                SqlConnection cn = conexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();


                cmd.CommandText = @"UPDATE Estoque 
                                    SET qtdProdutoDisponivel = @qtdProdutoDisponivel
                                        where idProduto = @idProduto";

                cmd.Parameters.Add("idProduto", SqlDbType.Int).Value = idProduto;

               
                cmd.Parameters.Add("@qtdProdutoDisponivel", SqlDbType.Int).Value = qtdProdutoDisponivel;
                cmd.ExecuteNonQuery();


                cn.Close();
                cn.Dispose();
           

            return linhas;
        }

        public static List<clsEstoque> SelecionarEstoque()
        {
            string sql = @"SELECT e.idProduto, p.nomeProduto, e.qtdProdutoDisponivel 
                           FROM dbo.Estoque as e inner join dbo.Produto as p
                           on e.idProduto = p.idProduto ";

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
                if (!dr.IsDBNull(dr.GetOrdinal("qtdProdutoDisponivel")))
                {
                    E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                }

                Estoque.Add(E);
            }

            return Estoque;
        }


        public static List<clsEstoque> SelecionarEstoquePorNome(string nomeProduto)
        {
            try
            {


                string sql = @"SELECT e.idProduto, p.nomeProduto, e.qtdProdutoDisponivel 
                           FROM dbo.Estoque as e inner join dbo.Produto as p
                           on e.idProduto = p.idProduto
                           where p.nomeProduto like @nomeProduto ";

                clsConexao conexao = new clsConexao();

                SqlConnection cn = conexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@nomeProduto", "%" + nomeProduto + "%");

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
                    if (!dr.IsDBNull(dr.GetOrdinal("qtdProdutoDisponivel")))
                    {
                        E.qtdProdutoDisponivel = dr.GetInt32(dr.GetOrdinal("qtdProdutoDisponivel"));
                    }

                    Estoque.Add(E);
                }

                return Estoque;

            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}


