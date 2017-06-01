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
                sb.Password = "SistemasInternet123";
                sb.DataSource = "foxtrot-pi.database.windows.net";
                sb.InitialCatalog = "foxtrot";

                SqlConnection cn = new SqlConnection(sb.ConnectionString);
                cn.Open();
                return cn;

            //if (cn == null)
            //{
            //    throw new SqlException(); 
            
            //}
                

        }
    }

}
