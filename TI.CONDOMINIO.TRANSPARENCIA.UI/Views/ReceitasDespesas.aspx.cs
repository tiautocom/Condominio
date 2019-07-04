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
    public partial class ReceitasDespesas : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idNivel, idEmpresa = 0;

        #endregion

        #region CLASSES E OBJETOS

        GrupoRegraNegocios grupoRegraNegocios;
        DataTable dadosTabela;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idEmpresa = Convert.ToInt32(Page.Request.QueryString["id"]);
            }

            ListarGrupo();
        }

        public void ListarSession()
        {
            Session["Error"] = null;
        }

        public void ListarGrupo()
        {
            try
            {
                dadosTabela = new DataTable();
                grupoRegraNegocios = new GrupoRegraNegocios();

                dadosTabela = grupoRegraNegocios.ListarGrupo(idEmpresa);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvGrupo.DataSource = null;
                    gdvGrupo.DataSource = dadosTabela;
                    gdvGrupo.DataBind();
                }
                else
                {
                    gdvGrupo.DataSource = null;
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