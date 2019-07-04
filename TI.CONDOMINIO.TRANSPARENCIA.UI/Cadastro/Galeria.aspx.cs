using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class Galeria : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        GaleriaFoto galeria;
        EmpresaRegraNegocios empresaRegraNrgocios;
        GaleriaRegraNegocios galeriaRegraNegocios;
        FotoRegraNegocios fotoRegraNegocios;
        DataTable dadosTabela;

        #endregion

        #region VARIAVEIS

        public int IdEmpresa = 0;
        public int idUsuario = 1;
        public int idRet = 0;
        public int idEmpresa = 0;
        public int erro = 0;
        public string street, diretorio, caminhoSalvar = "";
        public string navegador = "";

        //DIRETORIO
        public string usuarioFtp, senhaFtp, enderecoDestinoFtp, fileFullName = "";
        string url = "";

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
            }
        }

        protected void Unnamed8_Click1(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Galeria.aspx", false);
        }

        //public void ListarEmpresa()
        //{
        //    try
        //    {
        //        dadosTabela = new DataTable();
        //        empresaRegraNrgocios = new EmpresaRegraNegocios();

        //        dadosTabela = empresaRegraNrgocios.ListarAll();

        //        if (dadosTabela.Rows.Count > 0)
        //        {
        //            //this.cbEmpresa.DataSource = null;
        //            this.ddlEmpresa.DataSource = dadosTabela;
        //            this.ddlEmpresa.DataTextField = "NomeRazao";
        //            this.ddlEmpresa.DataValueField = "IdPessoa";
        //            this.ddlEmpresa.DataBind();
        //        }
        //        else
        //        {
        //            this.ddlEmpresa.DataSource = null;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Session["Error"] = ex.Message;
        //        Response.Redirect("~/Error.aspx", false);
        //    }
        //}

        public void Salvar(EventArgs e)
        {
            try
            {
                HttpFileCollection uploadedFiles = Request.Files;

                for (int i = 0; i < uploadedFiles.Count; i++)
                {
                    HttpPostedFile userPostedFile = uploadedFiles[i];

                    if (idRet == 0)
                    {
                        galeria = new GaleriaFoto();

                        galeria.IdEmpresa = 1;
                        galeria.Titulo = Titulo.Text.Trim();
                        galeria.Url = "";
                        galeria.IdUsuario = idUsuario;
                        galeria.DataCadastro = null;
                        galeria.Data = Convert.ToDateTime(dataGaleria.Text).ToString("yyyy-MM-dd");

                        galeriaRegraNegocios = new GaleriaRegraNegocios();

                        idRet = galeriaRegraNegocios.Salvar(galeria);

                        Session["IdRet"] = idRet;

                        url = flUpFile.PostedFile.FileName;

                        GerarDiretorio(idRet, url);
                    }

                    if (userPostedFile.ContentLength > 0)
                    {
                        navegador = Request.Url.Host;

                        if (navegador == "localhost")
                        {
                            navegador = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idRet);
                        }
                        else
                        {
                            navegador = ("http://zcondominio.com.br\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idRet);
                        }

                        userPostedFile.SaveAs(diretorio + "\\" + Path.GetFileName(userPostedFile.FileName));

                        SalvarFotoGaleria(galeria.Titulo, (navegador + "\\" + Path.GetFileName(userPostedFile.FileName)), idUsuario, idRet);
                    }
                }

                if (erro == 0)
                {
                    Response.Write("<script>alert('Arquivo salvo com sucesso.'); window.location.href = window.location.href;</script>");

                    this.OnLoad(e);
                }
                else
                {
                    Response.Write("<script>alert('Ocorreu um Erro ao Salvar Arquivo(s) Selecionado.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        private void SalvarFotoGaleria(string titulo, string caminho, int idUsuario, int idRet)
        {
            try
            {
                fotoRegraNegocios = new FotoRegraNegocios();

                int idRetorno = fotoRegraNegocios.SalvarFotoGaleria(titulo, caminho, idUsuario, idRet);

                if (idRetorno == 0)
                {
                    erro = +1;
                }
            }
            catch (Exception ex)
            {
                Session["Erro"] = ex.Message;
                Response.Redirect("~/Error.aspx", true);
            }
        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            Salvar(e);
        }

        public void SalvarImagem()
        {
            try
            {
                if (flUpFile.HasFile)
                {
                    url = flUpFile.PostedFile.FileName;

                    if (flUpFile.PostedFile != null)
                    {
                        string extensao = Path.GetExtension(flUpFile.FileName);

                        url = Path.GetFileName(url);
                        url.Replace(" ", "_");
                        String pasta = "\\";

                        string[] ext_image = new string[] { ".jpg", ".jpeg", ".gif", ".png", ".JPG", ".JPEG", ".GIF", ".PNG", "" };//foto
                        string[] ext_video = new string[] { ".3gp", ".wmv", ".mp4", ".ogg", ".flv", ".3GP", ".WMV", ".MP4", ".OGG", ".FLV", "" };//video

                        //Verifica a pasta onde será salvo o arquivo
                        foreach (string s in ext_image)
                        {
                            if (s == extensao)
                            {
                                pasta += "Imagens\\";
                            }
                        }
                        foreach (string s in ext_video)
                        {
                            if (s == extensao)
                            {
                                pasta += "Videos\\";
                            }
                        }

                        hfId.Value = idRet.ToString();

                        string urlArquivoEnviar = flUpFile + Path.GetFileName(url);

                        if (!File.Exists(urlArquivoEnviar))
                        {
                            string filepath = Server.MapPath(urlArquivoEnviar);
                            HttpFileCollection uploadedFiles = Request.Files;

                            for (int i = 0; i < uploadedFiles.Count; i++)
                            {
                                HttpPostedFile userPostedFile = uploadedFiles[i];

                                try
                                {
                                    if (userPostedFile.ContentLength > 0)
                                    {
                                        //string caminho = Path.Combine(diretorio + "\\" + Path.GetFileName(userPostedFile.FileName));

                                        //userPostedFile.SaveAs(filepath + "\\" + Path.GetFileName(userPostedFile.FileName));
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Response.Write("<script>alert('" + ex.Message + "'); window.location.href = window.location.href;</script>");
                                }
                            }

                            flUpFile.PostedFile.SaveAs(street);

                            Response.Write("<script>alert('Arquivo salvo com sucesso.'); window.location.href = window.location.href;</script>");
                        }
                        else
                        {
                            lblResponse.Text = "Existe um arquivo com o mesmo nome.";

                            Response.Write("<script>alert('Existe um arquivo com o mesmo nome.'); window.location.href = window.location.href;</script>");
                        }
                    }
                }
            }
            catch
            {
            }
            finally
            {
            }
        }

        [WebMethod]
        private void GerarDiretorio(int idRet, string url)
        {
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\"));
            Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idRet));

            street = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + hfId.Value + "\\" + url);
            diretorio = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idRet);
        }
    }
}