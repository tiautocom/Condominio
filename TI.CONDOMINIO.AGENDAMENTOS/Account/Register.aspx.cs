using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using TI.CONDOMINIO.AGENDAMENTOS.Models;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.AGENDAMENTOS.Account
{
    public partial class Register : Page
    {
        Usuarios usuario;
        UsuarioRegraNegocios usuarioRegraNegocios;

        public int IdUsuario = 0;
        public string NomeLogin = "";

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        public void Salvar()
        {
            try
            {
                usuario = new Usuarios();

                usuario.Nome = Nome.Text.Trim();
                usuario.Telefone = Telefone.Text.Trim();
                usuario.Senha = Senha.Text.Trim();

                string ret = "";

                usuarioRegraNegocios = new UsuarioRegraNegocios();

                try
                {
                    ret = usuarioRegraNegocios.Salvar(usuario);

                    if (Convert.ToInt32(ret) > 0)
                    {
                        IdUsuario = Convert.ToInt32(ret);
                        NomeLogin = Nome.Text.Trim();

                        GerarCookies();

                        Response.Redirect("~/Default.aspx", false);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Substring(0, 10).Trim() == "Violation")
                    {
                        Response.Write("<script>alert('Usuário Já Cadastrado Base de Dados.'); window.location.href = window.location.href;</script>");
                    }
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
                cookieIdUsuario.Value = IdUsuario.ToString();

                cookieIdUsuario.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieIdUsuario);

                #endregion

                #region LOGIN

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieLogin = new HttpCookie("Login");
                cookieLogin.Value = NomeLogin.ToString();

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
                cookieTipoUsuario.Value = "3";

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