using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class Atas : System.Web.UI.Page
    {
        Ata ata;
        AtaRegraNegocios ataRegraNegocios;

        protected void Page_Load(object sender, EventArgs e)
        {

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


                ata.Descricao = Titulo.Text.Trim().ToUpper();
                ata.TipoAssembleia = ddlTipoAssembleia.Text.Trim());
                ata.Sindico = Sindico.Text.Trim();
                ata.SubSindico = subSindico.Text.Trim();
                ata.Data = Convert.ToDateTime(DataAssembleia.Text.Trim());
                ata.EndArquivo = flUpFile.FileName;


                ataRegraNegocios = new AtaRegraNegocios();

                int idRet = ataRegraNegocios.Salvar(ata);

                if (idRet > 0)
                {

                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}