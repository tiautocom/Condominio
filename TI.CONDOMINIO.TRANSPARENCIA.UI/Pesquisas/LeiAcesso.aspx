<%@ Page Title="Lista de LAC" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeiAcesso.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas.LeiAcesso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <hr />
                <h3>LAC - Lei de Acesso Condominio</h3>
                <h5>
                    <asp:Literal ID="DesLai" runat="server" />
                </h5>
                <hr />
                <div class="row">

                    <div class="col-lg-10 ">
                        <div class="table-responsive">
                            <asp:GridView ID="gdvLei" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" EnableModelValidation="False" OnRowCommand="gdvLei_RowCommand" DataKeyNames="Id, Descricao">
                                <Columns>

                                    <asp:TemplateField>
                                        <ItemStyle Width="80%" />
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecionarLai"><%# Eval("Descricao")%></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="15%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklAdd" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="Novo">Cad. transparência</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="5%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklDele" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="Deletar">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="5%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklUpdate" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="Deletar">Alterar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class="modal fade" id="modalCadTranp" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">

                <div class="modal-content">
                    <div class="modal-header">

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <h3>
                            <asp:Literal runat="server" ID="DescLai" />

                        </h3>
                        <h5 class="modal-title" id="exampleModalLabel">Cadastro de Transparências</h5>

                        <hr />

                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Nome Transparência:</label>
                            <asp:TextBox ID="txtTransparencia" CssClass="form-control" runat="server" TextMode="Search" Width="100%"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <asp:LinkButton ID="lbList" runat="server" PostBackUrl="~/Pesquisas/Transparencias.aspx">Listar Transparência</asp:LinkButton>
                        </div>

                    </div>

                    <div class="modal-footer">
                        <asp:Button ID="SalvarArquivos" runat="server" class="btn btn-primary" Text="Salvar Arquivos" OnClick="SalvarArquivos_Click" EnableEventValidation="false" />
                    </div>

                </div>

            </div>
        </div>

    </div>

</asp:Content>
