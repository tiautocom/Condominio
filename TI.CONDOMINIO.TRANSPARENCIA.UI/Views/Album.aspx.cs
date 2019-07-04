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
    public partial class Album1 : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        AlbumRegraNegocios albumRegraNegocios;
        DataTable dadosTabela = new DataTable();

        #endregion

        #region VARIAVEIS

        public int idGaleria, cont = 0;
        public string xmlFoto, titulo, urlFoto = "";
        public bool hr;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                idGaleria = Convert.ToInt32(Page.Request["Id"]);
                subTitutlo.Text = Page.Request["Galeria"];

                ListarFotoTipo();
            }
        }

        public void ListarFotoTipo()
        {
            try
            {
                dadosTabela = new DataTable();
                albumRegraNegocios = new AlbumRegraNegocios();

                dadosTabela = albumRegraNegocios.ListarFotoTipo(idGaleria);

                if (dadosTabela.Rows.Count > 0)
                {
                    xmlFoto = "";

                    for (int i = 0; i < dadosTabela.Rows.Count; i++)
                    {
                        titulo = dadosTabela.Rows[i]["Titulo"].ToString().Trim();
                        urlFoto = dadosTabela.Rows[i]["UrlFoto"].ToString().Trim();

                        if (cont == 2)
                        {
                            cont = 0;
                            hr = true;
                        }
                        else
                        {
                            hr = false;
                            cont++;
                        }

                        //string urlFotos = Server.MapPath(urlFoto);

                        xmlFoto += albumRegraNegocios.GerarXmlFotos(titulo, urlFoto, hr);
                    }

                    iframeObras.Controls.Add(new LiteralControl(xmlFoto));
                }
                else
                {
                    xmlFoto = "";
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