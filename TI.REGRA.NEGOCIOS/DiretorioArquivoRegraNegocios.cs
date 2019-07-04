using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web.Services;
using System.IO;

namespace TI.REGRA.NEGOCIOS
{
    public class DiretorioArquivoRegraNegocios
    {
        [WebMethod]
        private void GerarDiretorio(int idRet, string url)
        {
            //try
            //{
            //    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\"));
            //    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\"));
            //    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\"));
            //    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\"));
            //    Directory.CreateDirectory(Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idRet));

            //    //street = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + hfId.Value + "\\" + url);
            //    //diretorio = this.Server.MapPath("~\\Arquivos\\Imagem\\Galeria\\IpeAmarelo\\" + idRet);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception(ex.Message);
            //}
        }
    }
}
