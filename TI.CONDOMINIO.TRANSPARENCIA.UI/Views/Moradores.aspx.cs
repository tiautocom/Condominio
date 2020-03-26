using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using TI.REGRA.NEGOCIOS;
using TI.OBJETO.TRANSFERENCIA;

namespace TI.CONDOMINIO.TRANSPARENCIA.UI.Views
{
    public partial class Moradores : System.Web.UI.Page
    {
        #region VARIAVEIS

        public string tipoDados = "0";
        public int idMorador, idVeiculo, idMoradorDep = 0;

        #endregion

        #region CLASSES E OBJETOS

        Veiculo veiculo;
        Morador morador;
        MoradorDepedente moradorDepedente;
        MoradorRegraNegocios moradorRegraNegocios;
        VeiculoRegraNegocios veiculoRegraNegocios;

        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            idMorador = Convert.ToInt32(Session["IdMorador"]);

            if (!IsPostBack)
            {
                ListarMorador();
                ListarDepedentes();
                ListarVeiculo();
            }
        }

        private void ListarMorador()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                //dadosTabela = moradorRegraNegocios.ListarMoradoresId(idMorador);
                dadosTabela = moradorRegraNegocios.ListarMoradoresId(idMorador);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataSource = dadosTabela;
                    gdvMorador.DataBind();
                }
                else
                {
                    gdvMorador.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }


        public void ListarUltimoMoradorCadastrado()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                dadosTabela = moradorRegraNegocios.ListarUltimoMoradorCadastrado();

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataSource = dadosTabela;
                    gdvMorador.DataBind();
                }
                else
                {
                    gdvMorador.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void SalvarDepedente()
        {
            try
            {
                moradorDepedente = new MoradorDepedente();

                moradorDepedente.IdMorador = idMorador;
                moradorDepedente.Nome = txtNome.Text.Trim().ToUpper();
                moradorDepedente.Tipo = ddTipo.Text.Trim().ToUpper();
                moradorDepedente.Genero = ddlGenero.Text.Trim().ToUpper();
                moradorDepedente.Idade = Convert.ToInt32(txtIdade.Text.Trim());

                moradorRegraNegocios = new MoradorRegraNegocios();

                try
                {
                    int idRet = Convert.ToInt32(moradorRegraNegocios.SalvarDepedente(moradorDepedente));

                    if (idRet > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Dependente foi Salvo com Sucesso')</script>");

                        ListarDepedentes();
                        LimparModalDepedente();
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro ao Salvar Depedente do Imovel')</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void SalvarVeiculo()
        {
            try
            {
                veiculo = new Veiculo();
                veiculoRegraNegocios = new VeiculoRegraNegocios();

                veiculo.IdMorador = idMorador;
                veiculo.Marca = txtMarca.Text.Trim().ToUpper();
                veiculo.Modelo = txtModelo.Text.Trim().ToUpper();
                veiculo.Cor = txtCor.Text.Trim().ToUpper();
                veiculo.Placa = txtPlaca.Text.Trim().ToUpper();
                veiculo.Tipo = ddlTipoVeiculo.Text.Trim().ToUpper();
                veiculo.NumVaga = txtNumVaga.Text.Trim();

                try
                {
                    int idRet = Convert.ToInt32(veiculoRegraNegocios.Salvar(veiculo));

                    ListarVeiculo();
                    LimparCamposVeiculo();

                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Veiculo Foi Salvo com Sucesso')</script>");
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro ao Salvar Veiculo')</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void ListarVeiculo()
        {
            try
            {
                DataTable dadosTabela = new DataTable();
                veiculoRegraNegocios = new VeiculoRegraNegocios();

                //dadosTabela = veiculoRegraNegocios.Listar(idMorador);
                dadosTabela = veiculoRegraNegocios.Listar(idMorador);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvVeiculo.DataSource = null;
                    gdvVeiculo.DataSource = dadosTabela;
                    gdvVeiculo.DataBind();
                }
                else
                {
                    gdvVeiculo.DataSource = null;
                    gdvVeiculo.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnSalvarDepedente_Click(object sender, EventArgs e)
        {
            SalvarDepedente();
        }

        public void LimparModalDepedente()
        {
            txtNome.Text = "";
            ddlGenero.Text = "MASCULINO";
            ddTipo.Text = "MARIDO";
            txtIdade.Text = "";
        }

        public void ListarDepedentes()
        {
            try
            {
                DataTable dadoTabela = new DataTable();
                moradorRegraNegocios = new MoradorRegraNegocios();

                dadoTabela = moradorRegraNegocios.ListarMoradoresDepedente(idMorador);

                if (dadoTabela.Rows.Count > 0)
                {
                    gdvDepedente.DataSource = null;
                    gdvDepedente.DataSource = dadoTabela;
                    gdvDepedente.DataBind();
                }
                else
                {
                    gdvDepedente.DataSource = null;
                    gdvDepedente.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnSalvarVeiculos_Click(object sender, EventArgs e)
        {
            SalvarVeiculo();
        }

        public void LimparCamposVeiculo()
        {
            ddlTipoVeiculo.Text = "VEICULO";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtCor.Text = "";
            txtPlaca.Text = "";
            txtNumVaga.Text = "";
        }

        public void AlterarDadosMorador()
        {
            try
            {
                morador = new Morador();
                moradorRegraNegocios = new MoradorRegraNegocios();

                morador.Id = idMorador;
                morador.Titulo = txtTitulatAlt.Text.Trim().ToUpper();
                morador.Torre = txtTorreAlt.Text.Trim().ToUpper();
                morador.Bloco = txtBlocoAlt.Text.Trim().ToUpper();
                morador.Apto = txtAptoAlt.Text.Trim().ToUpper();
                morador.TipoMorador = ddlTipoAlt.Text.Trim().ToString();
                morador.Observacao = txtObsAlt.Text.Trim().ToUpper();
                morador.Telefone = txtTelefoneAlt.Text.Trim().ToUpper();
                morador.Celular = txtCelularAlt.Text.Trim().ToUpper();
                morador.Comercial = txtComercialAlt.Text.Trim().ToUpper();
                morador.Email = txtEmailAlt.Text.Trim();
                morador.Rg = txtRgAlt.Text.Trim();
                morador.Cpf = txtCpfAlt.Text.Trim().ToUpper();
                morador.Status = cbxStatusAlt.Checked;

                try
                {
                    int idRet = Convert.ToInt32(moradorRegraNegocios.AlterarMorador(morador));

                    if (idRet > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Alteração de Morador Foi Salvo com Sucesso')</script>");

                        ListarMoradorId();
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção. Ocorreu um Erro ao Alterar Dados do Morador')</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void gdvMorador_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Trim().Equals("SelecionarTitular"))
                {
                    GridViewRow row = null;

                    int index = Convert.ToInt32(e.CommandArgument);

                    row = gdvMorador.Rows[index];


                    idMorador = Convert.ToInt32(gdvMorador.DataKeys[index].Values["Id"].ToString().Trim());

                    ltlTitular.Text = gdvMorador.DataKeys[index].Values["Titular"].ToString().Trim();
                    txtTitulatAlt.Text = gdvMorador.DataKeys[index].Values["Titular"].ToString().Trim();
                    txtTorreAlt.Text = gdvMorador.DataKeys[index].Values["Torre"].ToString().Trim();
                    txtBlocoAlt.Text = gdvMorador.DataKeys[index].Values["Bloco"].ToString().Trim();
                    txtAptoAlt.Text = gdvMorador.DataKeys[index].Values["Apto"].ToString().Trim();
                    txtEmailAlt.Text = gdvMorador.DataKeys[index].Values["Email"].ToString().Trim();
                    txtTelefoneAlt.Text = gdvMorador.DataKeys[index].Values["Telefone"].ToString().Trim();
                    txtCelularAlt.Text = gdvMorador.DataKeys[index].Values["Celular"].ToString().Trim();
                    txtComercialAlt.Text = gdvMorador.DataKeys[index].Values["Comercial"].ToString().Trim();
                    ddlTipoAlt.Text = gdvMorador.DataKeys[index].Values["TipoMorador"].ToString().Trim();
                    txtCpfAlt.Text = gdvMorador.DataKeys[index].Values["Cpf"].ToString().Trim();
                    txtRgAlt.Text = gdvMorador.DataKeys[index].Values["Rg"].ToString().Trim();
                    cbxStatusAlt.Checked = Convert.ToBoolean(gdvMorador.DataKeys[index].Values["Ativo"].ToString().Trim());

                    ScriptManager.RegisterStartupScript(this, GetType(), "LaunchServerSide", "$(function() { funcaoQueExibeModal(); });", true);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnAlterarDadosMorador_Click(object sender, EventArgs e)
        {
            AlterarDadosMorador();
        }

        public void ListarMoradorId()
        {
            try
            {
                DataTable dadosTabela = new DataTable();

                moradorRegraNegocios = new MoradorRegraNegocios();

                dadosTabela = moradorRegraNegocios.ListarMoradoresId(idMorador);

                if (dadosTabela.Rows.Count > 0)
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataSource = dadosTabela;
                    gdvMorador.DataBind();
                }
                else
                {
                    gdvMorador.DataSource = null;
                    gdvMorador.DataBind();
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        public void AlteraDadosVeiculo()
        {
            try
            {
                veiculo = new Veiculo();
                veiculoRegraNegocios = new VeiculoRegraNegocios();

                veiculo.Id = Convert.ToInt32(Session["IdVeiculo"]);
                veiculo.Marca = txtMarcaAlt.Text.Trim().ToUpper();
                veiculo.Modelo = txtModeloAlt.Text.Trim().ToUpper();
                veiculo.Cor = txtCorAlt.Text.Trim().ToUpper();
                veiculo.Placa = txtPlacaAlt.Text.Trim().ToUpper();
                veiculo.Tipo = ddlTipoVeiculoAlt.Text.Trim().ToUpper();
                veiculo.NumVaga = txtNumVagaAlt.Text.Trim();

                try
                {
                    int idRet = veiculoRegraNegocios.Alterar(veiculo);

                    if (idRet > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Dados do Veiculo Foi Alterado com Sucesso')</script>");

                        ListarVeiculo();
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro ao Alterar Veiculo')</script>");
                }

            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void gdvVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gdvVeiculo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Trim().Equals("SelecionarVeiculo"))
                {
                    GridViewRow row = null;

                    int index = Convert.ToInt32(e.CommandArgument);

                    //row = gdvMorador.Rows[index];

                    idVeiculo = Convert.ToInt32(gdvVeiculo.DataKeys[index].Values["Id"].ToString().Trim());

                    Session["IdVeiculo"] = idVeiculo;

                    ddlTipoVeiculoAlt.Text = gdvVeiculo.DataKeys[index].Values["Tipo"].ToString().Trim();
                    txtMarcaAlt.Text = gdvVeiculo.DataKeys[index].Values["Marca"].ToString().Trim();
                    txtModeloAlt.Text = gdvVeiculo.DataKeys[index].Values["Modelo"].ToString().Trim();
                    txtCorAlt.Text = gdvVeiculo.DataKeys[index].Values["Cor"].ToString().Trim();
                    txtPlacaAlt.Text = gdvVeiculo.DataKeys[index].Values["Placa"].ToString().Trim();

                    ScriptManager.RegisterStartupScript(this, GetType(), "LaunchServerSide", "$(function() { funcaoQueExibeVeixulo(); });", true);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void gdvDepedente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gdvDepedente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Trim().Equals("SelecionarMoradorDep"))
                {
                    GridViewRow row = null;

                    int index = Convert.ToInt32(e.CommandArgument);

                    row = gdvDepedente.Rows[index];

                    idMoradorDep = Convert.ToInt32(gdvDepedente.DataKeys[index].Values["Id"].ToString().Trim());

                    Session["IdMoradorDep"] = idMoradorDep;

                    ddlGeneroDepAlt.Text = gdvDepedente.DataKeys[index].Values["Genero"].ToString().Trim();
                    txtNomeDepAlt.Text = gdvDepedente.DataKeys[index].Values["Nome"].ToString().Trim();
                    ddlTipoDepAlt.Text = gdvDepedente.DataKeys[index].Values["Tipo"].ToString().Trim();
                    txtIdadeDepAlt.Text = gdvDepedente.DataKeys[index].Values["Idade"].ToString().Trim();

                    ScriptManager.RegisterStartupScript(this, GetType(), "LaunchServerSide", "$(function() { funcaoQueExibemoradorDepedente(); });", true);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnAlterarVeiculos_Click(object sender, EventArgs e)
        {
            AlteraDadosVeiculo();
        }

        protected void btnAlterarDepedentes_Click(object sender, EventArgs e)
        {
            AlterarDadosDepedente();
        }

        public void AlterarDadosDepedente()
        {
            try
            {
                moradorDepedente = new MoradorDepedente();
                moradorRegraNegocios = new MoradorRegraNegocios();

                moradorDepedente.Id = Convert.ToInt32(Session["IdMoradorDep"]);
                moradorDepedente.Nome = txtNomeDepAlt.Text.Trim().ToUpper();
                moradorDepedente.Genero = ddlGeneroDepAlt.Text.Trim().ToUpper();
                moradorDepedente.Tipo = ddlTipoDepAlt.Text.Trim().ToUpper();
                moradorDepedente.Idade = Convert.ToInt32(txtIdadeDepAlt.Text.Trim());

                try
                {
                    int idRet = moradorRegraNegocios.AlterarMoradorDepedente(moradorDepedente);

                    if (idRet > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Dados do Depedente Foi Alterado com Sucesso')</script>");

                        ListarDepedentes();
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro ao Alterar Veiculo')</script>");
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }

        protected void btnDeletarVeiculo_Click(object sender, EventArgs e)
        {
            DeletarVeiculo();
        }

        private void DeletarVeiculo()
        {
            try
            {
                veiculo = new Veiculo();
                veiculoRegraNegocios = new VeiculoRegraNegocios();

                veiculo.Id = Convert.ToInt32(Session["IdVeiculo"]);

                try
                {
                    int idRet = veiculoRegraNegocios.Deletar(veiculo);

                    if (idRet > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Dados do Veiculo Foi Alterado com Sucesso')</script>");

                        ListarVeiculo();
                    }
                }
                catch
                {
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Atenção Erro ao Alterar Veiculo')</script>");
                }

            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message;
                Response.Redirect("~/Error.aspx", false);
            }
        }
        public void DeletarDependente()
        {
            try
            {
                moradorDepedente = new MoradorDepedente();
                moradorRegraNegocios = new MoradorRegraNegocios();

                moradorDepedente.Id = Convert.ToInt32(Session["IdMoradorDep"]);

                try
                {
                    int idretMoradorDependente = moradorRegraNegocios.Deletar(moradorDepedente);

                    if (idretMoradorDependente > 0)
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Dependente morador foi deletado com sucesso')</script>");

                        ListarDepedentes();
                        LimparModalDepedente();

                        Session["RetIdMorador"] = idretMoradorDependente.ToString();

                      
                    }
                    else
                    {
                        Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Erro ao deletar morador dependente')</script>");
                    }
                }
                catch (global::System.Exception)
                {

                    throw;
                }
            }
            catch (global::System.Exception)
            {
                throw;
            }

        

        }

        public void btnDeletarDepedente_Click(object sender, EventArgs e)
        {
            DeletarDependente();
        }
    }
}