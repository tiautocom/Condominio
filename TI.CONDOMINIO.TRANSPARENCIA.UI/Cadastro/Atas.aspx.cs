using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;
using TI.OBJETO.TRANSFERENCIA;
using System.IO;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class Atas : System.Web.UI.Page
    {
        Ata ata;
        AtaRegraNegocios ataRegraNegocios;

        public int idUsuario, idEmpresa = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie CookieIdUsuario = Request.Cookies.Get("idUsuario");
            idUsuario = Convert.ToInt32(CookieIdUsuario.Value);

            //HttpCookie CookieIdEmpresa = Request.Cookies.Get("IdEmpresa");
            //idUsuario = Convert.ToInt32(CookieIdEmpresa.Value);
        }

        protected void Unnamed12_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {

            try
            {
                ata = new Ata();

                string diretorio, navegador = "";

                ata.Titulo = Titulo.Text.Trim().ToUpper();
                ata.Data = Convert.ToDateTime(DataAssembleia.Text.Trim());
                ata.IdUsuario = idUsuario;
                ata.Descricao = Descricao.Text;
                ata.TipoAssembleia = ddlTipoAssembleia.Text.Trim();
                ata.Sindico = Sindico.Text.Trim();
                ata.SubSindico = subSindico.Text.Trim();

                ata.Url = flUpFile.FileName;

                ataRegraNegocios = new AtaRegraNegocios();

                int idRet = ataRegraNegocios.Salvar(ata);

                if (idRet > 0)
                {
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Documentos\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Documentos\\Atas\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Documentos\\Atas" + "\\" + DateTime.Now.Date.Year));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Documentos\\Atas" + "\\" + DateTime.Now.Date.Year + "\\" + idUsuario + "\\"));
                    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Documentos\\Atas" + "\\" + DateTime.Now.Date.Year + "\\" + idUsuario + "\\" + ata.Url));

                    navegador = Request.Url.Host;

                    if (navegador == "localhost")
                    {
                        navegador = this.Server.MapPath("\\Arquivos\\Documentos\\Atas\\" + DateTime.Now.Date.Year + "\\" + idUsuario + "\\" + ata.Url);

                        try
                        {
                            flUpFile.SaveAs(navegador);
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        navegador = ("http://zcondominio.com.br\\\\Arquivos\\Documentos\\Atas\\" + DateTime.Now.Date.Year + "\\" + idUsuario + "\\" + ata.Url);

                        flUpFile.SaveAs(navegador);
                    }

                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}