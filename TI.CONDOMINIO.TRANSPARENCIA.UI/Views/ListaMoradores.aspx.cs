using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Views
{
    public partial class ListaMoradores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               // PesquisarMoradorId();
                ListarMoradores();
            }
        }

        private void ListarMoradores()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                dadosTabela = moradorRegraNegocios.ListarMoradores();


                if (dadosTabela.Rows.Count > 0)
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataSource = dadosTabela;
                    gdvMorador.DataBind();
                }
                else
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        MoradorRegraNegocios moradorRegraNegocios;

        public int idMorador = 0;

        public void ListarUltimoMoradorCadastrado()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                int tipo = Convert.ToInt32(ddlTorre.SelectedValue);

                dadosTabela = moradorRegraNegocios.ListarMoradoresLista(tipo, txtPesquisar.Text.Trim());

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataSource = dadosTabela;
                    gdvMorador.DataBind();
                }
                else
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void PesquisarMoradorId()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                dadosTabela = moradorRegraNegocios.ListarMoradoresId(Convert.ToInt32(Session["IdMorador"]));


                if (dadosTabela.Rows.Count > 0)
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataSource = dadosTabela;
                    gdvMorador.DataBind();
                }
                else
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ListarUltimoMoradorCadastrado();

            txtPesquisar.Text = "";
        }

        protected void gdvMorador_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "SelecionarMorador")
                {
                    GridViewRow row = null;
                    int index = Convert.ToInt32(e.CommandArgument);
                    row = gdvMorador.Rows[index];

                    idMorador = Convert.ToInt32(gdvMorador.DataKeys[index].Values["Id"].ToString().Trim());

                    Session["IdMorador"] = idMorador;

                    Response.Redirect("~/Views/Moradores.aspx", false);
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