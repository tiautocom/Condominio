using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class AdicinarFoto : System.Web.UI.Page
    {
        FotoRegraNegocios fotoRegraNegocios;

        public string titulo, caminho, navegador, diretorio = "";
        public int erro, idGaleria = 0;
        public int idUsuario = 1;
        public int idRetorno = 0;


        protected void Page_Load(object sender, EventArgs e)
        {
            idGaleria = Convert.ToInt32(Page.Request.QueryString["Id"]);
            titulo = Page.Request.QueryString["Galeria"].Trim();
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            SalvarFotoGaleriaPlus();
        }

        private void SalvarFotoGaleriaPlus()
        {
            try
            {
                HttpFileCollection uploadedFiles = Request.Files;

                for (int i = 0; i < uploadedFiles.Count; i++)
                {
                    HttpPostedFile userPostedFile = uploadedFiles[i];

                    navegador = Request.Url.Host;

                    if (navegador == "localhost")
                    {
                        navegador = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idGaleria + "\\" + Path.GetFileName(userPostedFile.FileName));
                    }
                    else
                    {
                        navegador = ("http://zcondominio.com.br\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idGaleria + "\\" + Path.GetFileName(userPostedFile.FileName));
                    }

                    fotoRegraNegocios = new FotoRegraNegocios();

                    idRetorno = fotoRegraNegocios.SalvarFotoGaleriaPlus(titulo, navegador, idUsuario, idGaleria);

                    if (idRetorno > 0)
                    {
                        if (userPostedFile.ContentLength > 0)
                        {
                            diretorio = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idGaleria + "\\" + Path.GetFileName(userPostedFile.FileName));

                            userPostedFile.SaveAs(diretorio);
                        }
                    }
                    else
                    {
                        erro = +1;
                    }
                }

                if (erro == 0)
                {
                    Response.Redirect("~/Views/Galeria.aspx", false);
                }
                else
                {
                    Response.Write("<script>alert('Ocorreu um Erro ao Salvar Arquivo(s) Selecionado.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;

                Response.Redirect("~/Error.aspx", true);
            }
        }

        [WebMethod]
        private void GerarDiretorio()
        {
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idGaleria));

            //street = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + hfId.Value + "\\" + url);
            diretorio = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idGaleria);
        }
    }
}