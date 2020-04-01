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
    public class EventoRegraNegocios
    {
        Conexao conexaoSqlServer = new Conexao();

        public int Salvar(Eventos evento, string dataSemana)
        {
            try
            {
                conexaoSqlServer.LimparParametros();

                conexaoSqlServer.AdicionarParametros("@IdMorador", evento.IdMorador);
                conexaoSqlServer.AdicionarParametros("@IdUsuario", evento.IdUsuario);
                conexaoSqlServer.AdicionarParametros("@Data", evento.Date);
                conexaoSqlServer.AdicionarParametros("@HoraInicio", evento.HoraInicio);
                conexaoSqlServer.AdicionarParametros("@HoraFim", evento.HoraFim);
                conexaoSqlServer.AdicionarParametros("@Observacao", evento.Observacao);
                conexaoSqlServer.AdicionarParametros("@IdLocal", evento.IdLocal);
                conexaoSqlServer.AdicionarParametros("@DataCadastro", evento.DataCadastro);

                int ret = 0;
                ret = Convert.ToInt32(conexaoSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAgendaEventoSalvar").ToString());
                return ret;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarHtmlAgenda(string dia, string mes, string dadosMorador, string dataSem, string hIni, string hFim, string local, string obs)
        {
            try
            {
                StringBuilder sb = new StringBuilder();

                sb.Append("<div class='row row-striped'>");
                sb.Append("<div class='col-2 text-right'>");
                sb.Append("<h1 class='display-4'><span class='badge badge-secondary'>" + dia + "</span></h1>");
                sb.Append("<h2>" + mes + "</h2>");
                sb.Append("</div>");
                sb.Append("<div class='col-10'>");
                sb.Append("<h3 class='text-uppercase'><strong>" + dadosMorador + "</strong></h3>");
                sb.Append("<ul class='list-inline'>");
                sb.Append("<li class='list-inline-item'><i class='fa fa-calendar-o' aria-hidden='true'></i> " + dataSem + "</li>");
                sb.Append("<li class='list-inline-item'><i class='fa fa-clock-o' aria-hidden='true'></i> " + hIni + " PM - " + hFim + " PM</li>");
                sb.Append("<li class='list-inline-item'><i class='fa fa-location-arrow' aria-hidden='true'></i> " + local + "</li>");
                sb.Append("<li class='list-inline-item'><i class='fa fa-list' aria-hidden='true'></i> <a href='/Pesquisas/ListarConvidado.aspx'>LISTA DE CONVIDADOS</a> </li>");
                sb.Append("</ul>");
                sb.Append("<p>" + obs + "</p>");
                sb.Append("</div>");
                sb.Append("</div>");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable Listar()
        {
            try
            {
                conexaoSqlServer.LimparParametros();
                DataTable dadosTabela = new DataTable();
                dadosTabela = conexaoSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspListarAgendaEventos");
                return dadosTabela;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
