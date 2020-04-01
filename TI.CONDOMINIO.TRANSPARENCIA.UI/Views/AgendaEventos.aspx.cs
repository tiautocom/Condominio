using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Views
{
    public partial class AgendaEventos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarEvento();
            }
        }

        EventoRegraNegocios eventoRegraNegocios;

        public string html = "";
        string dia, mes, mesDesc = "";
        string dadosMorado = "";
        string dataSem = "";
        string hIni = "";
        string hFi = "";
        string local = "";
        string obs = "";

        public void ListarEvento()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                eventoRegraNegocios = new EventoRegraNegocios();

                dadosTabela = eventoRegraNegocios.Listar();

                if (dadosTabela.Rows.Count > 0)
                {
                    CultureInfo culture = new CultureInfo("pt-BR");

                    DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                    html = "";

                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        dia = Convert.ToDateTime(dadosTabela.Rows[i]["Data"]).ToString("dd");
                        mes = Convert.ToDateTime(dadosTabela.Rows[i]["Data"]).ToString("MM");

                        if (mes.Trim() == "01")
                            mesDesc = "JAN";
                        else if (mes.Trim() == "02")
                            mesDesc = "FEV";
                        else if (mes.Trim() == "03")
                            mesDesc = "MAR";
                        else if (mes.Trim() == "04")
                            mesDesc = "ABR";
                        else if (mes.Trim() == "05")
                            mesDesc = "MAI";
                        else if (mes.Trim() == "06")
                            mesDesc = "JUN";
                        else if (mes.Trim() == "07")
                            mesDesc = "JAN";
                        else if (mes.Trim() == "08")
                            mesDesc = "AGO";
                        else if (mes.Trim() == "09")
                            mesDesc = "SET";
                        else if (mes.Trim() == "10")
                            mesDesc = "OUT";
                        else if (mes.Trim() == "11")
                            mesDesc = "NOV";
                        else if (mes.Trim() == "12")
                            mesDesc = "DEZ";

                        dataSem = dtfi.GetDayName(Convert.ToDateTime(dadosTabela.Rows[i]["Data"].ToString()).DayOfWeek).ToUpper();

                        dadosMorado = dadosTabela.Rows[i]["Titular"].ToString() + " - Torre: " + dadosTabela.Rows[i]["Torre"].ToString().Trim() + " - Bloco: " + dadosTabela.Rows[i]["Bloco"].ToString().Trim() + " - Apto: " + dadosTabela.Rows[i]["Apto"].ToString().Trim() + ".";

                        hIni = dadosTabela.Rows[i]["HoraInicio"].ToString().Trim();
                        hFi = dadosTabela.Rows[i]["HoraFim"].ToString().Trim();
                        local = dadosTabela.Rows[i]["Descricao"].ToString().Trim();
                        obs = dadosTabela.Rows[i]["Observacao"].ToString().Trim();

                        html += eventoRegraNegocios.GerarHtmlAgenda(dia, mesDesc, dadosMorado, dataSem, hIni, hFi, local, obs);
                    }

                    iframeObras.Controls.Add(new LiteralControl(html));
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }
    }
}