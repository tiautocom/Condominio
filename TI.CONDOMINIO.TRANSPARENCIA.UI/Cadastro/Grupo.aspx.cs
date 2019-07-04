using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class Grupo : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        GrupoRegraNegocios grupoRegraNegocios;
        EmpresaRegraNegocios empresaRegraNrgocios;
        Grupos grupo;
        DataTable dadosTabela = new DataTable();

        #endregion

        #region VARIAVEIS

        public int idEmpresa = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarEmpresa();
            }
        }

        public void ListarEmpresa()
        {
            try
            {
                dadosTabela = new DataTable();
                empresaRegraNrgocios = new EmpresaRegraNegocios();

                dadosTabela = empresaRegraNrgocios.ListarAll();

                if (dadosTabela.Rows.Count > 0)
                {
                    ddlEmpresa.DataSource = dadosTabela;

                    ddlEmpresa.DataValueField = "IdPessoa";
                    ddlEmpresa.DataTextField = "NomeRazao";
                    ddlEmpresa.DataBind();
                }
                else
                {
                    this.ddlEmpresa.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void Salvar(EventArgs e)
        {
            try
            {
                grupo = new Grupos();
                grupoRegraNegocios = new GrupoRegraNegocios();

                grupo.Descricao = Desc.Text.Trim().ToUpper();
                grupo.IdEmpresa = Convert.ToInt32(ddlEmpresa.SelectedValue);

                int idRet = grupoRegraNegocios.Savar(grupo);

                if (idRet > 0)
                {
                    Response.Write("<script>alert('Novo Grupo foi Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    Response.Write("<script>alert('Erro ao Inserir novo Grupo.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", true);
            }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            Salvar(e);
        }
    }
}