using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI
{
    public partial class SiteMaster : MasterPage
    {
        private const string AntiXsrfTokenKey = "__AntiXsrfToken";
        private const string AntiXsrfUserNameKey = "__AntiXsrfUserName";
        private string _antiXsrfTokenValue;
        public int idUsuario = 0;
        public string login, senha, token, fantasia = "";

        protected void Page_Init(object sender, EventArgs e)
        {
            // The code below helps to protect against XSRF attacks
            var requestCookie = Request.Cookies[AntiXsrfTokenKey];
            Guid requestCookieGuidValue;

            if (requestCookie != null && Guid.TryParse(requestCookie.Value, out requestCookieGuidValue))
            {
                // Use the Anti-XSRF token from the cookie
                _antiXsrfTokenValue = requestCookie.Value;

                Page.ViewStateUserKey = _antiXsrfTokenValue;
            }
            else
            {
                // Generate a new Anti-XSRF token and save to the cookie
                _antiXsrfTokenValue = Guid.NewGuid().ToString("N");
                Page.ViewStateUserKey = _antiXsrfTokenValue;

                var responseCookie = new HttpCookie(AntiXsrfTokenKey)
                {
                    HttpOnly = true,
                    Value = _antiXsrfTokenValue
                };
                if (FormsAuthentication.RequireSSL && Request.IsSecureConnection)
                {
                    responseCookie.Secure = true;
                }

                Response.Cookies.Set(responseCookie);
            }

            Page.PreLoad += master_Page_PreLoad;
        }

        protected void master_Page_PreLoad(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Set Anti-XSRF token
                ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
                ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
            }
            else
            {
                // Validate the Anti-XSRF token
                if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
                    || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
                {
                    throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
                }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LerCookie();
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
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

                //Cria o obj cookie e recebe o SenhaSeg
                HttpCookie cookieFantasia = new HttpCookie("Fantasia");
                cookieFantasia = Request.Cookies["Fantasia"];
                fantasia = cookieFantasia.Value.ToString().Trim();

                if (idUsuario > 0)
                {
                    loginEmpresa.Text = fantasia;
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