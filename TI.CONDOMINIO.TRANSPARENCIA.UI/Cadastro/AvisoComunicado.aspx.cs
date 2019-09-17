using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class AvisoComunicado : System.Web.UI.Page
    {
        Comunicado comunicado;
        ComunicaoRegraNegocios comunicaoRegraNegocios;

        public int idUsuario, id, idRet = 0;
        public string fantasia = "";
        public string pathEndereco = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
            idUsuario = Convert.ToInt32(CookieIdEmpresa.Value);

            HttpCookie CookieFantasia = Request.Cookies.Get("fantasia");
            fantasia = CookieFantasia.Value;
        }

        protected void btnupLoad_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                string filename = Path.GetFileName(flUpFile.PostedFile.FileName);

                pathEndereco = ("~/Arquivos/Imagem/Galeria/" + fantasia + "/" + "Comunicado/" + idRet + "/" + flUpFile.FileName.ToString());

                comunicado = new Comunicado();

                comunicado.Id = 0;
                comunicado.IdUsuario = idUsuario;
                comunicado.Descricao = txtDesc.Text.Trim();
                comunicado.Url = (pathEndereco.Replace("~", "").Trim());
                comunicado.Data = DateTime.Now;

                comunicaoRegraNegocios = new ComunicaoRegraNegocios();

                idRet = comunicaoRegraNegocios.Salvar(comunicado);

                if (idRet > 0)
                {
                    GerarDiretorio();

                    flUpFile.SaveAs(Server.MapPath("~/Arquivos/Imagem/Galeria/" + fantasia + "/Comunicado/" + idRet + "/" + filename));
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void GerarDiretorio()
        {
            try
            {
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\" + fantasia));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\Comunicado\\" + fantasia + "\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\Comunicado\\" + fantasia + "\\" + idRet));
            }
            catch (IndexOutOfRangeException ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }
    }
}