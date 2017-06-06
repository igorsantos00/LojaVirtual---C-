using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataModel
{
    public class clsCategoria
    {
        public int idCategoria { get; set; }
        public string nomeCategoria { get; set; }
        public string descCategoria { get; set; }



        //Faz desse objeto um Singleton
        private static clsCategoria referencia;

        public static clsCategoria getInstance()
        {
            if (referencia == null)
                referencia = new clsCategoria();

            return referencia;
        }

        public int Salvar(int idCategoria, string nomeCategoria, string descCategoria)
        {
            int linhas = 0;
            try
            {

                int inserir = idCategoria;

                clsConexao conexao = new clsConexao();
                SqlConnection cn = conexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();

                //Inserindo Categorias
                if (inserir == 0)
                    cmd.CommandText = "INSERT INTO Categoria " +
                                    "(nomeCategoria, descCategoria)" +
                                    "VALUES " +
                                    "(@nomeCategoria, @descCategoria);" +
                                    "select SCOPE_IDENTITY();";

                //Alterando Categorias
                else
                {
                    cmd.CommandText = "UPDATE Categoria " +
                                        "SET nomeCategoria = @nomeCategoria, " +
                                        "descCategoria = @descCategoria " +
                                        "Where idCategoria = @idCategoria"
                                        ;

                    cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
                }

                cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = nomeCategoria;
                cmd.Parameters.Add("@descCategoria", SqlDbType.VarChar, 100).Value = descCategoria;
                linhas = cmd.ExecuteNonQuery();


                if (inserir == 0)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "SELECT @@Identity";
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

        public static List<clsCategoria> SelecionarCategoria()
        {
            string sql = "SELECT idCategoria, nomeCategoria, descCategoria FROM dbo.Categoria";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCategoria> Categoria = new List<clsCategoria>();
            while (dr.Read())
            {

                clsCategoria C = new clsCategoria();
                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("nomeCategoria")))
                {
                    C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }

                Categoria.Add(C);
            }

            return Categoria;
        }

        public static List<clsCategoria> SelecionarCategoriaID(int idCategoria)
        {
            string sql = "SELECT idCategoria, nomeCategoria, descCategoria FROM dbo.Categoria " +
                "WHERE idCategoria = @idCategoria";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCategoria> Categoria = new List<clsCategoria>();
            while (dr.Read())
            {
                clsCategoria C = new clsCategoria();

                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("nomeCategoria")))
                {
                    C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("descCategoria")))
                {
                    C.descCategoria = dr.GetString(dr.GetOrdinal("descCategoria"));
                }

                Categoria.Add(C);
            }

            return Categoria;
        }

        public int ExcluirCategorias(int idCategoria)
        {

            string sql = "Delete FROM dbo.Categoria " +
           "WHERE idCategoria = @idCategoria";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;

            int linhas = cmd.ExecuteNonQuery();


            return linhas;
        }

        public List<clsCategoria> GetCategoria()
        {
            string sql = "SELECT nomeCategoria, idCategoria FROM dbo.Categoria";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCategoria> Categoria = new List<clsCategoria>();
            while (dr.Read())
            {
                clsCategoria C = new clsCategoria();

                if (!dr.IsDBNull(dr.GetOrdinal("nomeCategoria")))
                {
                    C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }
                Categoria.Add(C);

            }
            return Categoria;

        }

        public static List<clsCategoria> GetUCategoria(string nomeCategoria)
        {
            string sql = "SELECT nomeCategoria, idCategoria FROM dbo.Categoria WHERE nomeCategoria = @nomeCategoria";

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = nomeCategoria;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsCategoria> Categoria = new List<clsCategoria>();
            while (dr.Read())
            {
                clsCategoria C = new clsCategoria();

                if (!dr.IsDBNull(dr.GetOrdinal("nomeCategoria")))
                {
                    C.nomeCategoria = dr.GetString(dr.GetOrdinal("nomeCategoria"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idCategoria")))
                {
                    C.idCategoria = dr.GetInt32(dr.GetOrdinal("idCategoria"));
                }
                Categoria.Add(C);

            }
            return Categoria;

        }

    }
}
