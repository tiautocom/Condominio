using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro
{
    public partial class LeiAcesso : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        Leis leis;
        LeiAcessoRegraNegocios leiAcessoRegraNegocios;

        #endregion

        #region VARIAVEIS

        public int idLei, idEmpresa, idUsuario = 0;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie CookieIdEmpresa = Request.Cookies.Get("idUsuario");
            idEmpresa = Convert.ToInt32(CookieIdEmpresa.Value);
        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                leis = new Leis();

                leis.IdEmpresa = idEmpresa;
                leis.IdUsuario = idUsuario;
                leis.Data = DateTime.Now.Date;
                leis.Descricao = Desc.Text.Trim();

                leiAcessoRegraNegocios = new LeiAcessoRegraNegocios();

                int idRet = leiAcessoRegraNegocios.Salvar(leis);

                if (idRet > 0)
                {
                    Response.Write("<script>alert('Nova Lei de Acesso a Informação foi Inserido com Sucesso.'); window.location.href = window.location.href;</script>");
                }
                else
                {
                    Response.Write("<script>alert('Erro ao Inserir nova Lei de Informação.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }
    }
}