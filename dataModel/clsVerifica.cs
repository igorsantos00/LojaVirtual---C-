using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataModel
{
    public class clsVerifica
    {
        public bool ValidarNumero(string texto)
        {
            bool eNumero = true;

            try
            {
                double num = Convert.ToDouble(texto);
            }
            catch (Exception)
            {

                eNumero = false;
                //throw;
            }

            return eNumero;
        }

        public bool ValidaLetras(string texto)
        {

            if (texto.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }
    }

}
