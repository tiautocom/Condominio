using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class Evento : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        Eventos evento;
        EventoRegraNegocios eventoRegraNegocios;

        #endregion

        #region VARIAVEIS

        public int idUsuario, idMorador = 0; 
      
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            LerCookie();
        }

        private void LerCookie()
        {
            try
            {
                //Cria o obj cookie e recebe o IdUsuario
                HttpCookie cookieU = new HttpCookie("idUsuario");
                cookieU = Request.Cookies["idUsuario"];
                idUsuario = Convert.ToInt32(cookieU.Value.ToString());

                //Cria o obj cookie e recebe o IdUsuario
                HttpCookie cookieMorador = new HttpCookie("idMorador");
                cookieMorador = Request.Cookies["idMorador"];
                idMorador = Convert.ToInt32(cookieMorador.Value.ToString());
            }
            catch
            {
                idUsuario = 0;
                idMorador = 0;
            }
        }

        public void SalvarEvento()
        {
            try
            {
                if (dataGaleria.Text.Trim().Equals(""))
                {
                    Response.Write("<script>alert('Atenção, Informe Data do Evento Desejado.'); window.location.href = window.location.href;</script>");

                    dataGaleria.Focus();
                }
                else if (ddlLocal.Text == "")
                {
                    Response.Write("<script>alert('Atenção, Informe Local do Evento Desejado.'); window.location.href = window.location.href;</script>");

                    ddlLocal.Focus();
                }
                else if (horaInicio.Text == "")
                {
                    Response.Write("<script>alert('Atenção, Informe Hora de Inicio do Evento Desejado.'); window.location.href = window.location.href;</script>");

                    horaInicio.Focus();
                }
                else if (horaFim.Text == "")
                {
                    Response.Write("<script>alert('Atenção, Informe Hora de Fim do Evento Desejado.'); window.location.href = window.location.href;</script>");

                    horaFim.Focus();
                }
                else
                {
                    string data = Convert.ToDateTime(dataGaleria.Text.Trim()).ToString("yyyy/MM/dd");

                    CultureInfo culture = new CultureInfo("pt-BR");

                    DateTimeFormatInfo dtfi = culture.DateTimeFormat;

                    string dataSemana = dtfi.GetDayName(Convert.ToDateTime(data).DayOfWeek);

                    evento = new Eventos();

                    evento.IdMorador = idMorador;
                    evento.IdLocal = Convert.ToInt32(ddlLocal.SelectedValue);
                    evento.IdUsuario = idUsuario;
                    evento.Date = Convert.ToDateTime(data);
                    evento.HoraInicio = horaInicio.Text.Trim();
                    evento.HoraFim = horaFim.Text.Trim();
                    evento.Observacao = Obs.Text.Trim().ToUpper();
                    evento.DataCadastro = DateTime.Now.Date;

                    eventoRegraNegocios = new EventoRegraNegocios();

                    int idRet = eventoRegraNegocios.Salvar(evento, dataSemana);

                    if (idRet > 0)
                    {
                        Response.Write("<script>alert('Evento Cadastrado com Sucesso.'); window.location.href = window.location.href;</script>");

                        Response.Redirect("~/Views/AgendaEventos.aspx", false);
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void Unnamed6_Click(object sender, EventArgs e)
        {
            SalvarEvento();
        }
    }
}