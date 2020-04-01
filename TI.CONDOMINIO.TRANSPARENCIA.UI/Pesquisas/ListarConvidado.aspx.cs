using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TI.OBJETO.TRANSFERENCIA;
using TI.REGRA.NEGOCIOS;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas
{
    public partial class ListarConvidado : System.Web.UI.Page
    {
        #region CLASSES E OBJETOS

        Convidado convidado;
        Morador morador;
        MoradorRegraNegocios moradorRegraNegocios; 

        #endregion

        #region VARIAVEIS

        public int capcidade = 0;
        public int idMorador, idUsuario, Numero = 0;
        public string nomeMorador, torre, bloco, apto = ""; 
    
        #endregion

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            ListarTipoVisitante();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            LerCookie();

            if (!IsPostBack)
            {
                ListarConvidados();
                ListarTipoVisitante();

                loginMorador.Text = "NOME MORADOR: " + nomeMorador.ToString() + " - TORRE: " + torre.ToString().Trim() + " - BLOCO: " + bloco.ToString() + " - APTO: " + apto.ToString();
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

                //Cria o obj cookie e recebe o IdUsuario
                HttpCookie cookieMorador = new HttpCookie("idMorador");
                cookieMorador = Request.Cookies["idMorador"];
                idMorador = Convert.ToInt32(cookieMorador.Value.ToString());

                //Cria o obj cookie e recebe o NOME MORADOR
                HttpCookie cookieNomeMorador = new HttpCookie("NomeMorador");
                cookieNomeMorador = Request.Cookies["NomeMorador"];
                nomeMorador = cookieNomeMorador.Value.ToString();


                //Cria o obj cookie e recebe o torre MORADOR
                HttpCookie cookieTorreMorador = new HttpCookie("TorreMorador");
                cookieTorreMorador = Request.Cookies["TorreMorador"];
                torre = cookieTorreMorador.Value.ToString();

                //Cria o obj cookie e recebe o torre MORADOR
                HttpCookie cookieBlocoMorador = new HttpCookie("BlocoMorador");
                cookieBlocoMorador = Request.Cookies["BlocoMorador"];
                bloco = cookieBlocoMorador.Value.ToString();

                //Cria o obj cookie e recebe o apto MORADOR
                HttpCookie cookieAptoMorador = new HttpCookie("AptoMorador");
                cookieAptoMorador = Request.Cookies["AptoMorador"];
                apto = cookieAptoMorador.Value.ToString();
            }
            catch
            {
                idUsuario = 0;
                idMorador = 0;
            }
        }

        public void ListarConvidados()
        {
            try
            {
                moradorRegraNegocios = new MoradorRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = moradorRegraNegocios.ListarConvidados(idMorador);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvVisitantes.DataSource = null;
                    gdvVisitantes.DataSource = dadosTabela;
                    gdvVisitantes.DataBind();
                }
                else
                {
                    gdvVisitantes.DataSource = null;
                    gdvVisitantes.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void ListarTipoVisitante()
        {
            try
            {
                moradorRegraNegocios = new MoradorRegraNegocios();
                DataTable dadosTabela = new DataTable();

                dadosTabela = moradorRegraNegocios.ListarTipoVisitante();

                if (dadosTabela.Rows.Count > 0)
                {
                    ddTipo.DataSource = null;
                    ddTipo.DataSource = dadosTabela;
                    ddTipo.DataValueField = "ID";
                    ddTipo.DataTextField = "Tipo_M_V";
                    ddTipo.DataBind();
                }
                else
                {
                    ddTipo.DataSource = null;
                    ddTipo.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void Delete(int id)
        {
            try
            {
                moradorRegraNegocios = new MoradorRegraNegocios();

                try
                {
                    int idRet = moradorRegraNegocios.DeletarConvidados(id, idMorador);

                    if (idRet > 0)
                    {
                        Response.Write("<script>alert('Convidado Selecionado foi Deletado com sucesso.'); window.location.href = window.location.href;</script>");
                        ListarConvidados();
                    }
                }
                catch
                {

                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void Salvar()
        {
            try
            {
                if (txtNome.Text.Trim().Equals(""))
                {
                    Response.Write("<script>alert('Atenção Campo Nome não Pode ser Nulo ou Vázio, Informe Nome do Convidado.'); window.location.href = window.location.href;</script>");

                    txtNome.Focus();
                }
                else if (Convert.ToInt32(ddTipo.SelectedValue) <= 0)
                {
                    Response.Write("<script>alert('Atenção Campo Tipo de Visitante não Pode ser Nulo ou Vázio, Informe Tipo de Convidado.'); window.location.href = window.location.href;</script>");

                    txtNome.Focus();
                }
                else
                {
                    morador = new Morador();

                    morador.MoradorVisitante = new MoradorVisitante();

                    morador.MoradorVisitante.IdMorador = idMorador;
                    morador.MoradorVisitante.IdTipoVisitante = Convert.ToInt32(ddTipo.SelectedValue);
                    morador.MoradorVisitante.Nome = txtNome.Text.Trim();
                    morador.MoradorVisitante.Observacao = txtObs.Text.Trim();
                    morador.MoradorVisitante.DataAutorizacao = DateTime.Now.Date;

                    moradorRegraNegocios = new MoradorRegraNegocios();

                    int idRet = moradorRegraNegocios.SalvarConvidado(morador);

                    if (idRet > 0)
                    {
                        Response.Write("<script>alert('Convidado Cadastrado com Sucesso.'); window.location.href = window.location.href;</script>");

                        ListarConvidados();
                    }
                    else
                    {
                        Response.Write("<script>alert('Atenção Erro, Erro ao Cadastrao Novo do Convidado.'); window.location.href = window.location.href;</script>");

                        txtNome.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void SalvaVisitante_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}