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
        public int txtidUsuario { get; set; }
        public string txtloginUsuario { get; set; }
        public string txtsenhaUsuario { get; set; }
        public decimal txtnomeUsuario { get; set; }
        public decimal txttipoPerfil { get; set; }
        public int txtusuarioAtivo { get; set; }
        

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
            bool inserir = (this.txtidUsuario == 0);

            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();

            if (inserir)
                cmd.CommandText = "INSERT INTO Usuario " +
                                "(loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo)" +
                                "VALUES " +
                                "(@txtloginUsuario, @txtsenhaUsuario, @txtnomeUsuario, @txttipoPerfil, @txtusuarioAtivo)";
            else
            {
                cmd.CommandText = "UPDATE Produto " +
                                    "SET loginUsuario      = @txtloginUsuario, " +
                                        "senhaUsuario      = @txtsenhaUsuario, " +
                                        "nomeUsuario     = @txtnomeUsuario, " +
                                        "tipoPerfil = @txttipoPerfil, " +
                                        "usuarioAtivo      = @txtusuarioAtivo, ";

                cmd.Parameters.Add("idUsuario", SqlDbType.Int).Value = txtidUsuario;
            }

            cmd.Parameters.Add("@txtloginUsuario", SqlDbType.VarChar, 70).Value = this.txtloginUsuario;
            cmd.Parameters.Add("@txtsenhaUsuario", SqlDbType.VarChar, 500).Value = this.txtsenhaUsuario;
            cmd.Parameters.Add("@txtnomeUsuario", SqlDbType.Int).Value = this.txtnomeUsuario;
            cmd.Parameters.Add("@txttipoPerfil", SqlDbType.Money).Value = this.txttipoPerfil;
            cmd.Parameters.Add("@txtusuarioAtivo", SqlDbType.Int).Value = this.txtusuarioAtivo;
            cmd.ExecuteNonQuery();

            if (inserir)
            {
                cmd.Parameters.Clear();
                cmd.CommandText = "SELECT @@Identity";
                this.txtidUsuario = Convert.ToInt32(cmd.ExecuteScalar());
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
                U.txtidUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                U.txtloginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                U.txtsenhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                U.txtnomeUsuario = dr.GetInt32(dr.GetOrdinal("nomeUsuario"));
                U.txttipoPerfil = dr.GetInt32(dr.GetOrdinal("tipoPerfil"));
                U.txtusuarioAtivo = dr.GetInt32(dr.GetOrdinal("usuarioAtivo"));
                Usuario.Add(U);
            }

            cn.Close();
            cn.Dispose();
            return Usuario;

        }

        public static List<clsUsuario> SelecionarUsuario(int IdUsuario)
        {
            string sql = "SELECT idProduto, nomeProduto, descProduto, precProduto, descontoPromocao, idCategoria, ativoProduto, idUsuario, qtdMinEstoque, imagem FROM dbo.Produto" +
                "WHERE idProduto = @txtidProduto";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuario = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                U.txtidUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                U.txtloginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                U.txtsenhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                U.txtnomeUsuario = dr.GetInt32(dr.GetOrdinal("nomeUsuario"));
                U.txttipoPerfil = dr.GetInt32(dr.GetOrdinal("tipoPerfil"));
                U.txtusuarioAtivo = dr.GetInt32(dr.GetOrdinal("usuarioAtivo"));
                Usuario.Add(U);
            }
            
            return Usuario;

        }


    }

}