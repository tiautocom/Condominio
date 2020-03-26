using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.ACESSO.DADOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.REGRA.NEGOCIOS
{
    public class GaleriaRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public DataTable ListarGaleria(int idEmpresa)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@ID_EMPRESA", idEmpresa);

                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarGaleriaIdEmpresa");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarXml(int id, string titulo, string url, DateTime data)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class='col-md-7 col-lg-7'>");
                sb.Append("<ul class='media-list main-list'>");
                sb.Append("<li class='media'>");
                sb.Append("<a class='pull-left' href='/Views/Album.aspx?Id=" + id + "&Galeria=" + titulo + "'>");
                sb.Append("<img class='media-object' src='" + url + "' style='height: 200px; width: 349px;' alt='...'>");
                sb.Append("</a>");
                sb.Append("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class='media-body'>");
                sb.Append("<h4 class='media-heading'>" + titulo + "</h4>");
                sb.Append("<p class='by-author'>" + data.ToString("dd/MM/yyyy") + "</p>");
                sb.Append("<a runat='server' href='/Cadastro/AdicinarFoto.aspx?Id=" + id + "&Galeria=" + titulo + "'>+ Foto</a>");
                sb.Append("</div>");
                sb.Append("</li>");
                sb.Append("</ul>");
                sb.Append("</div>");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int Salvar(GaleriaFoto galeria)
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                conexaoSqlServer.AdicionarParametros("@Titulo", galeria.Titulo);
                conexaoSqlServer.AdicionarParametros("@Url", galeria.Url);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", galeria.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@DataCadastro", DateTime.Now.Date);
                conexaoSqlServer.AdicionarParametros("@Data", galeria.Data);
                conexaoSqlServer.AdicionarParametros("@IdEmpresa", galeria.IdEmpresa);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspGaleriaSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
