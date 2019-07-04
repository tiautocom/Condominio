using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas
{
    public partial class LeiAcesso : System.Web.UI.Page
    {
        #region CLASSES OBJETIVOS

        DataTable dadosTabela;
        Tranparencias tranparencias;
        LeiAcessoRegraNegocios leiAcessoRegraNegocios;
        TransparenciaRegraNegocios transparenciaRegraNegocios;

        #endregion

        #region VARIAVEIS

        public int idUsuario = 0;
        public int idEmpresa = 0;
        public int idLai = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
                idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);

                Listar();
            }
        }

        public void Listar()
        {
            try
            {
                HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
                idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);

                dadosTabela = new DataTable();
                leiAcessoRegraNegocios = new LeiAcessoRegraNegocios();
                dadosTabela = leiAcessoRegraNegocios.ListarAll(idEmpresa);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvLei.DataSource = null;
                    gdvLei.DataSource = dadosTabela;
                    gdvLei.DataBind();
                }
                else
                {
                    gdvLei.DataSource = null;
                    gdvLei.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void gdvLei_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("SelecionarLai"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);

                    idLai = Convert.ToInt32(gdvLei.DataKeys[index].Values["Id"].ToString().Trim());
                    DescLai.Text = gdvLei.DataKeys[index].Values["Descricao"].ToString().Trim();

                    Session["IdLai"] = idLai;
                    Session["DescLai"] = DescLai.Text.Trim();

                    Response.Redirect("~/Pesquisas/Transparencias.aspx", false);
                }
                else if (e.CommandName.Equals("Novo"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);

                    idLai = Convert.ToInt32(gdvLei.DataKeys[index].Values["Id"].ToString().Trim());
                    DescLai.Text = gdvLei.DataKeys[index].Values["Descricao"].ToString().Trim();

                    Session["IdLai"] = idLai;

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalCadTranp", "$('#modalCadTranp').modal();", true);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void SalvarArquivos_Click(object sender, EventArgs e)
        {
            SalvarTransparencia();
        }

        public void SalvarTransparencia()
        {
            try
            {
                HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
                idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);

                tranparencias = new Tranparencias();
                transparenciaRegraNegocios = new TransparenciaRegraNegocios();

                tranparencias.IdLei = Convert.ToInt32(Session["IdLai"]);
                tranparencias.IdUsuario = idUsuario;
                tranparencias.IdPessoa = idEmpresa;
                tranparencias.Data = DateTime.Now.Date;
                tranparencias.Descricao = txtTransparencia.Text.Trim();

                int idRet = transparenciaRegraNegocios.Salvar(tranparencias);

                if (idRet > 0)
                {
                    Response.Write("<script>alert('Nova Tranparência foi Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    Response.Write("<script>alert('Erro ao Inserir nova Tranparência.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;

                Response.Redirect("~/Error.aspx");
            }
        }
    }
}