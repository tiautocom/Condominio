using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas
{
    public partial class ListarConvidado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListarConvidados();
            }
        }

        Convidado convidado;

        public int capcidade = 0;

        public void ListarConvidados()
        {
            try
            {
                List<Convidado> listaConvidado = new List<Convidado>();

                for (int i = 0; i < 40; i++)
                {
                    listaConvidado.Add(new Convidado()
                    {
                        Id = (i + 1),
                        Nome = "",
                        Obs = ""
                    });
                }

                gdvMorador.DataSource = null;
                gdvMorador.DataSource = listaConvidado;
                gdvMorador.DataBind();

            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}