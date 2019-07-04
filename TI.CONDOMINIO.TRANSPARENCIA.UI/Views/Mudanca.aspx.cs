using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Views
{
    public partial class Mudanca : System.Web.UI.Page
    {
        MudancaRegraNegocios mudancaRegraNegocios;
        StatusRegraNegocios statusRegraNegocios;
        Mudancas mudancas;
        DataTable dadosTabela;

        public int IdUsuario, IdSindico, tipoUsuario, idMudanca = 0;
        public int idNumTorre, lado, apto, periodo = 0;
        public string hIni, hFim, bloco = "";
        public string nomeUsuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadPagina();
            }
        }


        public void LoadPagina()
        {
            LerCookie();
            Listar();
        }

        protected void gdvAgendaAdm_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "SelApto")
                {
                    GridViewRow row = null;

                    int index = Convert.ToInt32(e.CommandArgument);

                    row = gdvAgendaAdm.Rows[index];

                    idMudanca = Convert.ToInt32(gdvAgendaAdm.DataKeys[index].Values["IdMudanca"].ToString().Trim());
                    descTorre.Text = "TORRE: " + gdvAgendaAdm.DataKeys[index].Values["NumTorre"].ToString().Trim() + ".";
                    descBlocos.Text = "BLOCO: " + gdvAgendaAdm.DataKeys[index].Values["Bloco"].ToString().Trim() + ".";
                    descApto.Text = "APARTAMENTO: " + gdvAgendaAdm.DataKeys[index].Values["Apto"].ToString().Trim() + ".";

                    Session["idMudanca"] = idMudanca;

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlterarStatus", "$('#modalAlterarStatus').modal();", true);

                    ListarStatus();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            statusRegraNegocios = new StatusRegraNegocios();

            int idRet = statusRegraNegocios.Salvar(Convert.ToInt32(ddlStatus.SelectedValue), Convert.ToInt32(Session["idMudanca"]));

            if (idRet > 0)
            {
                LerCookie();

                Listar();
            }
        }

        public void Listar()
        {
            try
            {
                dadosTabela = new DataTable();
                mudancaRegraNegocios = new MudancaRegraNegocios();

                dadosTabela = mudancaRegraNegocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    if (tipoUsuario == 1 || tipoUsuario == 2)
                    {
                        #region GRID ADM

                        gdvAgendaAdm.DataSource = null;
                        gdvAgendaAdm.DataSource = dadosTabela;
                        gdvAgendaAdm.DataBind();

                        for (int i = 0; i < gdvAgendaAdm.Rows.Count; i++)
                        {
                            if (gdvAgendaAdm.Rows[i].Cells[0].Text == "1")
                            {
                                gdvAgendaAdm.Rows[i].ForeColor = System.Drawing.Color.Red;
                            }
                            else if (gdvAgendaAdm.Rows[i].Cells[0].Text == "2")
                            {
                                gdvAgendaAdm.Rows[i].ForeColor = System.Drawing.Color.Blue;
                            }
                            else if (gdvAgendaAdm.Rows[i].Cells[0].Text == "3")
                            {
                                gdvAgendaAdm.Rows[i].ForeColor = System.Drawing.Color.Green;
                            }
                            else if (gdvAgendaAdm.Rows[i].Cells[0].Text == "4")
                            {
                                gdvAgendaAdm.Rows[i].ForeColor = System.Drawing.Color.Indigo;
                            }
                        }

                        #endregion 
                    }
                    else
                    {
                        #region GRID USUARIO

                        gdvAgenda.DataSource = null;
                        gdvAgenda.DataSource = dadosTabela;
                        gdvAgenda.DataBind();

                        for (int i = 0; i < gdvAgenda.Rows.Count; i++)
                        {
                            if (gdvAgenda.Rows[i].Cells[0].Text == "1")
                            {
                                gdvAgenda.Rows[i].ForeColor = System.Drawing.Color.Red;
                            }
                            else if (gdvAgenda.Rows[i].Cells[0].Text == "2")
                            {
                                gdvAgenda.Rows[i].ForeColor = System.Drawing.Color.Blue;
                            }
                            else if (gdvAgenda.Rows[i].Cells[0].Text == "3")
                            {
                                gdvAgenda.Rows[i].ForeColor = System.Drawing.Color.Green;
                            }
                            else if (gdvAgenda.Rows[i].Cells[0].Text == "4")
                            {
                                gdvAgenda.Rows[i].ForeColor = System.Drawing.Color.Indigo;
                            }
                        }

                        #endregion
                    }
                }
                else
                {
                    gdvAgenda.DataSource = null;
                    gdvAgendaAdm.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void Cadastrar(EventArgs e)
        {
            try
            {
                mudancas = new Mudancas();
                mudancaRegraNegocios = new MudancaRegraNegocios();

                mudancas.Data = Convert.ToDateTime(dataGaleria.Text);
                mudancas.IdTorre = Convert.ToInt32(ddlTorre.SelectedValue);
                mudancas.IdBloco = 0;
                mudancas.IdPeriodo = Convert.ToInt32(ddlPeriodo.SelectedValue);
                mudancas.IdStatus = 1;
                mudancas.IdUsuario = IdUsuario;
                mudancas.IdSindico = IdSindico;
                mudancas.Apto = Convert.ToInt32(txtApto.Text);
                mudancas.Lado = lado;
                mudancas.Bloco = ddlBloco.SelectedValue.Trim();

                int idRet = mudancaRegraNegocios.Cadastrar(mudancas);

                if (idRet > 0)
                {
                    Response.Write("<script>alert('Mudança Agendado com Data e Perido com Sucesso.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void PesquisarDataMudanca(EventArgs e)
        {
            try
            {
                CultureInfo culturaAmericana = new CultureInfo("en-US");

                apto = Convert.ToInt32(txtApto.Text);
                idNumTorre = Convert.ToInt32(ddlTorre.SelectedValue);
                bloco = ddlBloco.SelectedValue.Trim();
                periodo = Convert.ToInt32(ddlPeriodo.SelectedValue);

                dadosTabela = new DataTable();
                mudancaRegraNegocios = new MudancaRegraNegocios();

                dadosTabela = mudancaRegraNegocios.PesquisarTorres(idNumTorre, bloco, apto);

                if (dadosTabela.Rows.Count > 0)
                {
                    lado = Convert.ToInt32(dadosTabela.Rows[0]["Lado"].ToString());

                    dadosTabela = new DataTable();
                    mudancaRegraNegocios = new MudancaRegraNegocios();

                    dadosTabela = mudancaRegraNegocios.PesquisarDataMudanca(Convert.ToDateTime(dataGaleria.Text).ToString("yyyy-MM-dd", culturaAmericana), lado, periodo, idNumTorre);

                    if (dadosTabela.Rows.Count == 0)
                    {
                        Cadastrar(e);
                    }
                    else
                    {
                        Response.Write("<script>alert('Atenção Já Existe Mudança Agendado com Data e Perido Desejado.'); window.location.href = window.location.href;</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Atenção Numero de Apartamento não Foi Localizado em nossa Base de Cadastros. Verifique se: 1-Torre foi Selecionado Corretamente.2-Bloco foi Selecionado Corretamente.3-Numero de Apartamento foi Digitado Corretamente.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void btnSolicitar_Click(object sender, EventArgs e)
        {
            try
            {
                hIni = Request["HoraInicio"];
                hFim = Request["HoraFim"];

                if (dataGaleria.Text.Trim().Equals(""))
                {
                    Response.Write("<script>alert('Campo Data da Solicitação de Mudança não Pode ser Nulo ou Vázio.'); window.location.href = window.location.href;</script>");
                }
                else if (CompararDatas() == false)
                {
                    Response.Write("<script>alert('A Data da Solicitação de Mudança não Pode ser Menor que a Data Atual.'); window.location.href = window.location.href;</script>");
                }
                else if (hIni == "")
                {
                    Response.Write("<script>alert('Campo Hora de Inicio da Solicitação de Mudança não Pode ser Nulo ou Vázio.'); window.location.href = window.location.href;</script>");
                }
                else if (Convert.ToInt32(txtApto.Text) == 0)
                {
                    Response.Write("<script>alert('Campo Numero de Apartamento para Solicitação de Mudança não Pode ser Nulo ou Vázio.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    PesquisarDataMudanca(e);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public bool CompararDatas()
        {
            try
            {
                DateTime data = DateTime.Now;
                DateTime date1 = new DateTime(data.Year, data.Month, data.Day, 0, 0, 0);
                DateTime date2 = new DateTime(Convert.ToDateTime(dataGaleria.Text).Year, Convert.ToDateTime(dataGaleria.Text).Month, Convert.ToDateTime(dataGaleria.Text).Day, 0, 0, 0);

                int result = DateTime.Compare(date1, date2);

                if (result < 0)
                    return true;
                else if (result == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
                return false;
            }
        }

        private void LerCookie()
        {
            try
            {
                //Cria o obj cookie e recebe o IdUsuario
                HttpCookie cookieU = new HttpCookie("IdUsuario");
                cookieU = Request.Cookies["IdUsuario"];
                IdUsuario = Convert.ToInt32(cookieU.Value.ToString());

                //Cria o obj cookie e recebe o Login
                HttpCookie cookieLogin = new HttpCookie("Login");
                cookieLogin = Request.Cookies["Login"];
                nomeUsuario = cookieLogin.Value.ToString().Trim();

                //Cria o obj cookie e recebe o Login
                HttpCookie cookieTipoUsuario = new HttpCookie("TipoUsuario");
                cookieTipoUsuario = Request.Cookies["TipoUsuario"];
                tipoUsuario = Convert.ToInt32(cookieTipoUsuario.Value.ToString().Trim());

                if (IdUsuario == 0)
                {
                    Response.Redirect("~/Account/Login.aspx", false);

                    btnSolicitarMudanca.Visible = false;
                }
                else
                {
                    btnSolicitarMudanca.Visible = true;
                }
            }
            catch
            {
                IdUsuario = 0;
            }
        }

        public void ListarStatus()
        {
            try
            {
                statusRegraNegocios = new StatusRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = statusRegraNegocios.Listar();

                if (dadosTabela.Rows.Count > 0)
                {
                    ddlStatus.DataSource = null;
                    ddlStatus.DataSource = dadosTabela;

                    ddlStatus.DataTextField = "Descricao";
                    ddlStatus.DataValueField = "Id";
                    ddlStatus.DataBind();
                }
                else
                {
                    ddlStatus.DataSource = null;
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