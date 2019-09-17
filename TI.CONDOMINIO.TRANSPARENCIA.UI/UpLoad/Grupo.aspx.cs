using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.UpLoad
{
    public partial class Grupo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void Salvar()
        {
            string filename = Path.GetFileName(flUpFile.PostedFile.FileName);
            flUpFile.SaveAs(Server.MapPath("~/Arquivos/Imagem/Agenda/" + filename));
        }

        protected void btnUpLoad_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}