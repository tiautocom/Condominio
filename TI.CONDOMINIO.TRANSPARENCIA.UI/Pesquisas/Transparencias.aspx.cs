using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas
{
    public partial class Transparencias : System.Web.UI.Page
    {
        public int idEmpresa = 0;
        public int idLai = 0;
        public int idTransp = 0;
        public string fantasia = "";

        DataTable dadosTabela;

        TransparenciaRegraNegocios transparenciaRegraNegocios;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
            idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);

            HttpCookie CookieFantasia = Request.Cookies.Get("fantasia");
            fantasia = CookieFantasia.Value;

            idLai = Convert.ToInt32(Session["IdLai"]);
            // DesLai.Text = Session["DescLai"].ToString();

            Listar();
        }

        public void Listar()
        {
            try
            {
                HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
                idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);

                dadosTabela = new DataTable();
                transparenciaRegraNegocios = new TransparenciaRegraNegocios();
                dadosTabela = transparenciaRegraNegocios.ListarAll(idEmpresa, idLai);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvTransparencia.DataSource = null;
                    gdvTransparencia.DataSource = dadosTabela;
                    gdvTransparencia.DataBind();
                }
                else
                {
                    gdvTransparencia.DataSource = null;
                    gdvTransparencia.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void DeltarArquivos_Click(object sender, EventArgs e)
        {
            try
            {
                idTransp = Convert.ToInt32(Session["IdTransp"]);

                transparenciaRegraNegocios = new TransparenciaRegraNegocios();

                int idRet = transparenciaRegraNegocios.Deletar(idEmpresa, idTransp);

                if (idRet > 0)
                {
                    Response.Write("<script>alert('Tranparência foi Deletado com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    Response.Write("<script>alert('Erro ao Deletar Tranparência.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        public void btnsalvarUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (flUpFile.HasFile)
                {
                    idTransp = Convert.ToInt32(Session["IdTransp"]);

                    string url = flUpFile.PostedFile.FileName;

                    if (flUpFile.PostedFile != null)
                    {
                        string extensao = Path.GetExtension(flUpFile.FileName);

                        url = Path.GetFileName(url);

                        url.Replace(" ", "_");

                        String pasta = "\\";

                        string[] ext_image = new string[] { ".jpg", ".jpeg", ".gif", ".png", ".JPG", ".JPEG", ".GIF", ".PNG" };//foto
                        string[] ext_video = new string[] { ".3gp", ".wmv", ".mp4", ".ogg", ".flv", ".3GP", ".WMV", ".MP4", ".OGG", ".FLV" };//video

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

                        GerarDiretorio();

                        string street = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\" + fantasia + "\\" + idTransp + "\\" + url);

                        if (!File.Exists(street))
                        {
                            flUpFile.PostedFile.SaveAs(street);

                            Response.Write("<script>alert('Arquivo Salvo com Sucesso.'); window.location.href = window.location.href;</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Existe um Arquivo com o Mesmo Nome.'); window.location.href = window.location.href;</script>");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }

        protected void gdvTransparencia_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Deletar"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);

                    idTransp = Convert.ToInt32(gdvTransparencia.DataKeys[index].Values["Id"].ToString().Trim());
                    DescLai.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();

                    desLaiAlt.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();

                    Session["IdTransp"] = idTransp;

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalDeletar", "$('#modalDeletar').modal();", true);
                }

                if (e.CommandName.Equals("Alterar"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);

                    idTransp = Convert.ToInt32(gdvTransparencia.DataKeys[index].Values["Id"].ToString().Trim());
                    DescLai.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();

                    desLaiAlt.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();
                    txtTransparencia.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();

                    Session["IdTransp"] = idTransp;

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalAlterar", "$('#modalAlterar').modal();", true);
                }
                if (e.CommandName.Equals("UpLoad"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);

                    idTransp = Convert.ToInt32(gdvTransparencia.DataKeys[index].Values["Id"].ToString().Trim());
                    DescLai.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();

                    Literal1.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();
                    txtTransparencia.Text = gdvTransparencia.DataKeys[index].Values["Descricao"].ToString().Trim();

                    Session["IdTransp"] = idTransp;

                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "modalUpload", "$('#modalUpload').modal();", true);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx");
            }
        }


        public void GerarDiretorio()
        {
            try
            {
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\" + fantasia));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\" + fantasia + "\\"));
                Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\" + fantasia + "\\" + idTransp));
            }
            catch (IndexOutOfRangeException ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }
    }
}