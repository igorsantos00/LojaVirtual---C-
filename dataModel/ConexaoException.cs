using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataModel
{
    public class ConexaoException : Exception
    {
        public ConexaoException(Exception cause)
            : base("Erro de conexão! Verifique sua rede...", cause)
        {

        }
    }
}
