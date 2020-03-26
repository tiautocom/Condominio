using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.ACESSO.DADOS;

namespace TI.REGRA.NEGOCIOS
{
    public class AlbumRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public string GerarXmlFotos(string titulo, string urlBanco, bool hr)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<a class='example-image-link' style='height: 500px; width: 500px;' href='" + urlBanco + "' data-lightbox='example-set' data-title='" + titulo + "'>");
                sb.Append("<img class='example-image' style='height: 200px; width: 300px;' src='" + urlBanco + "' alt='' />");
                sb.Append("</a>");
                sb.Append("&nbsp");

                if (hr == true)
                {
                    sb.Append("<hr/>");
                }

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListarFotoTipo(int idGaleria)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_GALERIA", idGaleria);
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarFotoId");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
