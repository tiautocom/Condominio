using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TI.REGRA.NEGOCIOS
{
    public class BuscarCepRegraNegocios
    {
        public string BuscaCEP(string cep)
        {
            try
            {
                if (cep.Trim().Replace("-", "").Replace(" ", "").Equals(""))
                {
                    throw new Exception("Informe CEP Desejado");
                }
                else
                {
                    string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", cep.Trim());

                    return xml;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
