using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataModel
{
    public class clsConexao
    {
       
            public SqlConnection Conectar()
            {
                SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
                sb.UserID = "TSI";
                sb.Password = "SIstemas123";
                sb.DataSource = "assirati.database.windows.net";
                sb.InitialCatalog = "Kanino";

                SqlConnection cn = new SqlConnection(sb.ConnectionString);
                cn.Open();
                return cn;
            }
        }

}
