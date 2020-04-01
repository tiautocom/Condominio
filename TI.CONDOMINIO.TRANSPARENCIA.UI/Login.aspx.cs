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
    public partial class Login : System.Web.UI.Page
    {
        #region VARIAVEIS

        public int idUsuario, idMorador = 0;
        public string login, senha, token, fantasia, nomeMorador, aptoMorador, blocoMorador, torreMorador = "";

        #endregion

        #region CLASSES E OBJETOS

        PessoaRegraNegocios pessoaRegraNegocios;
        DataTable dadosTabela;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            LerCookie();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Session["Login"] = login = txtLogin.Text.Trim();
            Session["Senha"] = senha = txtPassword.Text.Trim();
            Session["Token"] = senha.Trim();

            token = senha;

            Logar();
        }

        public void Logar()
        {
            try
            {
                if (login.Trim() == "")
                {
                    FailureText.Text = "Atenção, Campo Login não Pode ser Nulo ou Vázio.";
                }
                else if (senha.Trim() == "")
                {
                    FailureText.Text = "Atenção, Campo Senha não Pode ser Nulo ou Vázio.";
                }
                //else if (token == null)
                //{
                //    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "myModal", "$('#mymodal').modal();", true);
                //}
                else
                {
                    pessoaRegraNegocios = new PessoaRegraNegocios();
                    dadosTabela = new DataTable();

                    //dadosTabela = pessoaRegraNegocios.PesquisarEmpresa(login, senha);

                    dadosTabela = pessoaRegraNegocios.LoginMorador(login, senha);

                    if (dadosTabela.Rows.Count > 0)
                    {
                        idUsuario = Convert.ToInt32(dadosTabela.Rows[0]["Id"].ToString().Trim());

                        fantasia = dadosTabela.Rows[0]["NomeFantasia"].ToString().Trim();
                        nomeMorador = dadosTabela.Rows[0]["Titular"].ToString().Trim();
                        torreMorador = dadosTabela.Rows[0]["Torre"].ToString().Trim();
                        blocoMorador = dadosTabela.Rows[0]["Bloco"].ToString().Trim();
                        aptoMorador = dadosTabela.Rows[0]["Apto"].ToString().Trim();

                        GerarCookies();

                        LerCookie();

                        Session.Clear();

                        Session.Abandon();

                        Response.Redirect("~/Default.aspx", false);
                    }
                    else
                    {
                        FailureText.Text = "Login ou Senha está Incorreto";
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnSalvarToken_Click(object sender, EventArgs e)
        {
            if (txtToken.Text.Trim().Equals(""))
            {
                FailureText.Text = "Atenção, Campo Token não Pode ser Nulo ou Vázio.";
            }
            else if (txtToken.Text.Trim().Length < 6)
            {
                FailureText.Text = "Atenção, Campo Token não Pode ser Menor que Seis Digitos.";
            }
            else
            {
                login = Session["Login"].ToString();
                senha = Session["Senha"].ToString();
                token = txtToken.Text.Trim();

                Logar();
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
                    Response.Redirect("~/Default.aspx", false);
                }
            }
            catch
            {
                idUsuario = 0;
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
                HttpCookie cookieIdUsuario = new HttpCookie("idUsuario");
                cookieIdUsuario.Value = idUsuario.ToString();

                cookieIdUsuario.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieIdUsuario);

                #endregion

                #region LOGIN

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieLogin = new HttpCookie("Login");
                cookieLogin.Value = login.ToString();

                //Time para expiração (1min)
                dtNow = DateTime.Now;
                tsMinute = new TimeSpan(1, 0, 0, 0);

                cookieLogin.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieLogin);

                #endregion

                #region SENHA

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieSenha = new HttpCookie("Senha");
                cookieSenha.Value = senha.ToString();

                //Time para expiração (1min)
                dtNow = DateTime.Now;
                tsMinute = new TimeSpan(1, 0, 0, 0);

                cookieSenha.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieSenha);

                #endregion

                #region TOKEN

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieToken = new HttpCookie("Token");
                cookieToken.Value = token.ToString();

                //Time para expiração (1min)
                dtNow = DateTime.Now;
                tsMinute = new TimeSpan(1, 0, 0, 0);

                cookieToken.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieToken);

                #endregion

                #region NOME FANTASIA

                //Cria a estancia do obj HttpCookie passando o nome do mesmo
                HttpCookie cookieFantasia = new HttpCookie("Fantasia");
                cookieFantasia.Value = fantasia.ToString();

                //Time para expiração (1min)
                dtNow = DateTime.Now;
                tsMinute = new TimeSpan(1, 0, 0, 0);

                cookieFantasia.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieFantasia);

                #endregion

                #region MORADOR

                HttpCookie cookieIdMorador = new HttpCookie("IdMorador");
                cookieIdMorador.Value = idUsuario.ToString();

                cookieIdMorador.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieIdMorador);

                //NOME MORADOR
                HttpCookie cookieNomeMorador = new HttpCookie("NomeMorador");
                cookieNomeMorador.Value = nomeMorador.ToString();

                cookieNomeMorador.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieNomeMorador);

                //TORRE MORADOR
                HttpCookie cookieTorreMorador = new HttpCookie("TorreMorador");
                cookieTorreMorador.Value = torreMorador.ToString();

                cookieTorreMorador.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieTorreMorador);

                //BLOCO MORADOR
                HttpCookie cookieBlocoMorador = new HttpCookie("BlocoMorador");
                cookieBlocoMorador.Value = blocoMorador.ToString();

                cookieBlocoMorador.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieBlocoMorador);

                //APTO MORADOR
                HttpCookie cookieAptoMorador = new HttpCookie("AptoMorador");
                cookieAptoMorador.Value = aptoMorador.ToString();

                cookieAptoMorador.Expires = (dtNow + tsMinute);

                //Adiciona o cookie
                Response.Cookies.Add(cookieAptoMorador);

                #endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}