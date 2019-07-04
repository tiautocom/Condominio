using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI
{
    public partial class _Default : Page
    {
        EmpresaRegraNegocios empresaRegraNegocios;
        DataTable dadosTabela;

        public string cnpjEmpresa, senhaCmp, senha, login, token = "";
        public int idUsuario, idEmpresa = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                senha = this.Server.MapPath("~\\Arquivos\\CNPJ\\PATH_CNPJ.xml");

                LerCookie();
            }
        }

        public void PesquisarEmpresa()
        {
            try
            {
                empresaRegraNegocios = new EmpresaRegraNegocios();
                dadosTabela = new DataTable();

                dadosTabela = empresaRegraNegocios.PesquisaEmpresaCnpjSenha(cnpjEmpresa, senha);

                if (dadosTabela.Rows.Count > 0)
                {
                    Response.Redirect("~/Default.aspx", true);
                }
            }
            catch (Exception ex)
            {
                throw;
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

                //Cria o obj cookie e recebe o Login
                HttpCookie cookieLogin = new HttpCookie("Login");
                cookieLogin = Request.Cookies["Login"];
                login = cookieLogin.Value.ToString().Trim();

                //Cria o obj cookie e recebe o Senha
                HttpCookie cookieSenha = new HttpCookie("Senha");
                cookieSenha = Request.Cookies["Senha"];
                senha = cookieSenha.Value.ToString().Trim();

                //Cria o obj cookie e recebe o SenhaSeg
                HttpCookie cookieSenhaSeg = new HttpCookie("Token");
                cookieSenhaSeg = Request.Cookies["Token"];
                token = cookieSenhaSeg.Value.ToString().Trim();

                if (idUsuario > 0)
                {
                }
                else
                {
                    Response.Redirect("~/Login.aspx", false);
                }
            }
            catch
            {
                idUsuario = 0;
                Response.Redirect("~/Login.aspx", false);
            }
        }
    }
}