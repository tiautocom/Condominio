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
    public partial class Galeria : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        GaleriaRegraNegocios galeriaRegraNegocios;
        DataTable dadosTabela = new DataTable();

        #endregion

        #region VARIAVEIS

        public int idGaleria = 0;
        public int idEmpresa = 1;
        public string xmlGaleria = "";
        public string titulo, url = "";
        public DateTime data;
        public int id = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarGaleria();
            }
        }

        public void ListarGaleria()
        {
            try
            {
                dadosTabela = new DataTable();
                galeriaRegraNegocios = new GaleriaRegraNegocios();

                dadosTabela = galeriaRegraNegocios.ListarGaleria(idEmpresa);

                if (dadosTabela.Rows.Count > 0)
                {
                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        id = Convert.ToInt32(dadosTabela.Rows[i]["Id"].ToString());
                        titulo = dadosTabela.Rows[i]["Titulo"].ToString().Trim();
                        url = dadosTabela.Rows[i]["Url"].ToString().Trim();
                        data = Convert.ToDateTime(dadosTabela.Rows[i]["Data"].ToString());

                        xmlGaleria += galeriaRegraNegocios.GerarXml(id, titulo, url, data);
                    }

                    iframeGaleria.Controls.Add(new LiteralControl(xmlGaleria));
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