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
    public partial class Moradores : System.Web.UI.Page
    {
        Morador morador;
        MoradorRegraNegocios moradorRegraNegocios;

        public int idUsuario = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LerCookie();
            }
        }

        private void LerCookie()
        {
            try
            {
                //Cria o obj cookie e recebe o IdUsuario
                HttpCookie cookieU = new HttpCookie("idUsuario");
                cookieU = Request.Cookies["idUsuario"];
                idUsuario = Convert.ToInt32(cookieU.Value.ToString());
            }
            catch
            {
                idUsuario = 0;
            }
        }

        protected void Unnamed23_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                morador = new Morador();

                morador.Torre = ddlTorre.Text.Trim().ToUpper();
                morador.Bloco = ddlBlco.Text.Trim().ToUpper();
                morador.Apto = ddlApto.Text.Trim().ToUpper();
                morador.TipoMorador = ddTipoMorador.Text.ToUpper();
                morador.DataNascimento = Convert.ToDateTime(DataNiver.Text.Trim().ToUpper()).ToString("dd-MM-yyyy");
                morador.Observacao = Obs.Text.Trim().ToUpper();
                morador.Titulo = Titular.Text.Trim().ToUpper();
                morador.Email = Email.Text.Trim().ToLower();
                morador.Cpf = Cpf.Text.Trim();
                morador.Rg = Rg.Text.Trim();
                morador.Telefone = Telefone.Text.Trim();
                morador.Celular = Celular.Text.Trim();
                morador.Comercial = Comercial.Text.Trim();
                morador.IdEmpresa = idUsuario;

                if (ddlAtivo.SelectedValue == "1")
                    morador.Status = true;
                else
                    morador.Status = false;

                moradorRegraNegocios = new MoradorRegraNegocios();

                int idRet = moradorRegraNegocios.Salvar(morador);

                if (idRet > 0)
                {
                    Session["DadosCad"] = 1;
                    Session["IdMorador"] = idRet;

                    Response.Redirect("~/Views/Moradores.aspx", false);
                }
                else
                {

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