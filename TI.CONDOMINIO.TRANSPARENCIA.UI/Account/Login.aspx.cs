using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using TI.CONDOMINIO.TRANSPARENCIA.UI.Models;
using TI.REGRA.NEGOCIOS;
using System.Data;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Account
{
    public partial class Login : Page
    {
        UsuarioRegraNegocios usuarioRegraNegocios;
        DataTable dadosTabela;

        public int tipoUsuario, idUsuario = 0;
        public string nomeUsuario = "";

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void LogIn(object sender, EventArgs e)
        {
            Logar();
        }

        public void Logar()
        {
            try
            {
                dadosTabela = new DataTable();

                usuarioRegraNegocios = new UsuarioRegraNegocios();

                dadosTabela = usuarioRegraNegocios.Logar(Telefone.Text.Trim(), Senha.Text.Trim());

                if (dadosTabela.Rows.Count > 0)
                {
                    tipoUsuario = Convert.ToInt32(dadosTabela.Rows[0]["IdTipoUsuario"].ToString());
                    idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["Id"].ToString());

                    GerarCookies();

                    Response.Redirect("~/Default.aspx", false);
                }
                else
                {
                    Response.Write("<script>alert('Telefone ou Senha está Incorreto.'); window.location.href = window.location.href;</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void GerarCookies()
        {
            try
            {
                //Time para expiração (1min)
                DateTime dtNow = DateTime.Now;
                TimeSpan tsMinute = new TimeSpan(1, 0, 0, 0);

                #region ID USUSARIO

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieIdUsuario = new HttpCookie("IdUsuario");
                cookieIdUsuario.Value = idUsuario.ToString();

                cookieIdUsuario.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieIdUsuario);

                #endregion

                #region LOGIN

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieLogin = new HttpCookie("Login");
                cookieLogin.Value = nomeUsuario.ToString();

                //Time para expiração (1min)
                dtNow = DateTime.Now;
                tsMinute = new TimeSpan(1, 0, 0, 0);

                cookieLogin.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieLogin);

                #endregion

                #region TIPO USUSARIO

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieTipoUsuario = new HttpCookie("TipoUsuario");
                cookieTipoUsuario.Value = tipoUsuario.ToString();

                //Time para expiração (1min)
                dtNow = DateTime.Now;
                tsMinute = new TimeSpan(1, 0, 0, 0);

                cookieTipoUsuario.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieTipoUsuario);

                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}