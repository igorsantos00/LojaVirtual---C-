using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace dataModel
{
    public class clsUsuario
    {
        public int idUsuario { get; set; }
        public string loginUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string nomeUsuario { get; set; }
        public string tipoPerfil { get; set; }
        public bool usuarioAtivo { get; set; }


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

        public static List<clsUsuario> SelecionarUsuario()
        {
            string sql = "SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuario = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                {

                    U.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("loginUsuario")))
                {
                    U.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    U.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    U.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("tipoPerfil")))
                {
                    U.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("usuarioAtivo")))
                {
                    U.usuarioAtivo = dr.GetBoolean(dr.GetOrdinal("usuarioAtivo"));
                }

                Usuario.Add(U);
            }

            cn.Close();
            return Usuario;
        }


        public static List<clsUsuario> SelecionarUsuarioPorNome(string nomeUsuario)
        {
            string sql = @"SELECT idUsuario, loginUsuario, senhaUsuario, nomeUsuario, tipoPerfil, usuarioAtivo FROM dbo.Usuario
                           Where nomeUsuario like '%@nomeUsuario%' ";
            clsConexao conexao = new clsConexao();
            SqlConnection cn = conexao.Conectar();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar).Value = nomeUsuario;

            SqlDataReader dr = cmd.ExecuteReader();
            List<clsUsuario> Usuario = new List<clsUsuario>();
            while (dr.Read())
            {
                clsUsuario U = new clsUsuario();
                if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                {

                    U.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("loginUsuario")))
                {
                    U.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    U.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    U.nomeUsuario = dr.GetString(dr.GetOrdinal("nomeUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("tipoPerfil")))
                {
                    U.tipoPerfil = dr.GetString(dr.GetOrdinal("tipoPerfil"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("usuarioAtivo")))
                {
                    U.usuarioAtivo = dr.GetBoolean(dr.GetOrdinal("usuarioAtivo"));
                }

                Usuario.Add(U);
            }

           return Usuario;

        }

        //------------------------Login

        public clsUsuario Logar(string login, string senha)
        {
            clsUsuario log = null;

            try
            {

                clsConexao conexao = new clsConexao();
                SqlConnection cn = conexao.Conectar();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandText = (@"Select idUsuario, loginusuario, senhausuario,tipoperfil from usuario 
                                    where loginusuario = @login and senhausuario = @senha");

                cmd.Parameters.Add("@login", SqlDbType.VarChar).Value = login;
                cmd.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;
                SqlDataReader dr = cmd.ExecuteReader();

                log = new clsUsuario();
                dr.Read();

                if (!dr.IsDBNull(dr.GetOrdinal("loginUsuario")))
                {
                    log.loginUsuario = dr.GetString(dr.GetOrdinal("loginUsuario"));
                }

                if (!dr.IsDBNull(dr.GetOrdinal("senhaUsuario")))
                {
                    log.senhaUsuario = dr.GetString(dr.GetOrdinal("senhaUsuario"));
                }
                if (!dr.IsDBNull(dr.GetOrdinal("idUsuario")))
                {
                    log.idUsuario = dr.GetInt32(dr.GetOrdinal("idUsuario"));
                }



            }
            catch (InvalidOperationException e)
            {
                log = null;
            }

            return log;

        }

    }

}