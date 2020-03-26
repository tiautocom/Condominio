using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas
{
    public partial class Atas : System.Web.UI.Page
    {
        AtaRegraNegocios ataRegraNegocios;

        DataTable dadosTabela;

        public int idEmpresa = 0;

        StringBuilder sb;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlAno.Text = DateTime.Now.Year.ToString();
            }

            Listar();
        }

        public void Listar()
        {
            try
            {
                HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
                idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);

                dadosTabela = new DataTable();
                ataRegraNegocios = new AtaRegraNegocios();
                dadosTabela = ataRegraNegocios.Listar(idEmpresa, ddlAno.SelectedValue);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvAtas.DataSource = null;
                    gdvAtas.DataSource = dadosTabela;
                    gdvAtas.DataBind();
                }
                else
                {
                    gdvAtas.DataSource = null;
                    gdvAtas.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;

                Response.Redirect("~/Error.aspx");
            }
        }

        protected void gdvAtas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("SelecionarAtas"))
            {
                int index = Convert.ToInt32(e.CommandArgument);


                int id = Convert.ToInt32(gdvAtas.DataKeys[index].Values["Id"].ToString().Trim());

                sb = new StringBuilder(index);

                string url = sb.ToString();
                string path = Server.MapPath(url);

                FileInfo flarquivo = new FileInfo(path);

                string extensao = System.IO.Path.GetExtension(path);

                Response.Redirect("~/Views/Atas.aspx?id=" + idEmpresa, false);
            }

            if (e.CommandName.Equals("Deletar"))
            {
                int id = Convert.ToInt32(e.CommandArgument);
            }
        }
    }
}