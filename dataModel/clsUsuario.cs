using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace dataModel
{
    class clsUsuario
    {
        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public decimal nomeUsuario { get; set; }
        public decimal tipoPerfil { get; set; }
        public int usuarioAtivo { get; set; }
        

        //Faz desse objeto um Singleton.
        private static clsUsuario referencia;

        public static clsUsuario getInstance()
        {
            if (referencia == null)
                referencia = new clsUsuario();

            return referencia;
        }

        public void Salvar()
        {
            bool inserir = (this.idUsuario == 0);

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Usuario " +
                                "(loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo)" +
                                "VALUES " +
                                "(@loginUsuario, @senhaUsuario, @nomeUsuario, @tipoPerfil, @usuarioAtivo)";
            else
            {
                cmd.CommandText = "UPDATE Produto " +
                                    "SET loginUsuario      = @loginUsuario, " +
                                        "senhaUsuario      = @senhaUsuario, " +
                                        "nomeUsuario     = @nomeUsuario, " +
                                        "tipoPerfil = @tipoPerfil, " +
                                        "usuarioAtivo      = @usuarioAtivo, ";

                cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value = idUsuario;
            }

            cmd.Parameters.Add("@loginUsuario", SqlDbType.VarChar, 70).Value = this.loginUsuario;
            cmd.Parameters.Add("@senhaUsuario", SqlDbType.VarChar, 500).Value = this.senhaUsuario;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.Int).Value = this.nomeUsuario;
            cmd.Parameters.Add("@tipoPerfil", SqlDbType.Money).Value = this.tipoPerfil;
            cmd.Parameters.Add("@usuarioAtivo", SqlDbType.Int).Value = this.usuarioAtivo;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.idUsuario = Convert.ToInt32(cmd.ExecuteScalar());
            }

            cn.Close();
            cn.Dispose();
        }

        public static List<clsUsuario> SelecionarProduto()
        {
            string sql = "SELECT idProduto, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuario = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                U.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                U.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                U.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                U.nomeUsuario = dr.GetInt32(dr.GetOrdinal("nomeUsuario"));
                U.tipoPerfil = dr.GetInt32(dr.GetOrdinal("tipoPerfil"));
                U.usuarioAtivo = dr.GetInt32(dr.GetOrdinal("usuarioAtivo"));
                Usuario.Add(U);
            }

            cn.Close();
            cn.Dispose();
            return Usuario;

        }

        public static List<clsUsuario> SelecionarUsuario(int IdUsuario)
        {
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem FROM dbo.Produto" +
                "WHERE idProduto = @idProduto";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuario = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                U.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                U.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                U.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                U.nomeUsuario = dr.GetInt32(dr.GetOrdinal("nomeUsuario"));
                U.tipoPerfil = dr.GetInt32(dr.GetOrdinal("tipoPerfil"));
                U.usuarioAtivo = dr.GetInt32(dr.GetOrdinal("usuarioAtivo"));
                Usuario.Add(U);
            }
            
            return Usuario;

        }


    }

}