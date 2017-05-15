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

        public int Salvar(string nomeCategoria, string descCategoria)
        {
            bool inserir = (this.idCategoria == 0);
            int linhas = 0;
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            //Inserindo Categorias
            if (inserir)
                cmd.CommandText = "INSERT INTO Categoria " +
                                "(nomeCategoria, descCategoria)" +
                                "VALUES " +
                                "(@nomeCategoria, @descCategoria);"+
                                "select SCOPE_IDENTITY();";

            //Alterando Categorias
            else
            {
                cmd.CommandText = "UPDATE Categoria " +
                                    "SET nomeCategoria = @nomeCategoria, " +
                                    "descCategoria = @descCategoria ";

                cmd.Parameters.Add("@idCategoria", SqlDbType.Int).Value = idCategoria;
            }

            cmd.Parameters.Add("@nomeCategoria", SqlDbType.VarChar, 50).Value = nomeCategoria;
            cmd.Parameters.Add("@descCategoria", SqlDbType.VarChar, 100).Value = descCategoria;
            linhas = Convert.ToInt32(cmd.ExecuteScalar());


            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idCategoria = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return linhas;
            cn.Close();
            cn.Dispose();
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
            string sql = "SELECT idCategoria, nomeCategoria FROM dbo.Categoria " +
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



    }
}
