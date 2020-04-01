<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atas.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas.Atas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <hr />
                <h3>Atas - Documento de Assembléias</h3>
                <h5>
                    <asp:Literal ID="DesLai" runat="server" />
                </h5>
                <hr />

                <div class="row">

                    <div class="col-md-12">
                        <asp:Label runat="server" AssociatedControlID="ddlAno" CssClass="col-md-4 control-label">Selecione Ano Desejado:</asp:Label>
                        <asp:Label ID="lblDescricao" runat="server" AssociatedControlID="ddlAno">
                        </asp:Label>
                    </div>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlAno" CssClass="form-control" Width="100%" runat="server" AutoPostBack="true" ControlToValidate="ddlAno" AppendDataBoundItems="true" ErrorMessage="Campo Obrigatório.">
                            <asp:ListItem Value="2019">2019</asp:ListItem>
                            <asp:ListItem Value="2020">2020</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <br />

                <div class="row">

                    <div class="col-lg-10 ">
                        <div class="table-responsive">
                            <asp:GridView ID="gdvAtas" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" EnableModelValidation="False" OnRowCommand="gdvAtas_RowCommand" DataKeyNames="Id, Descricao">
                                <Columns>

                                    <asp:TemplateField>
                                        <ItemStyle Width="90%" />
                                        <ItemTemplate>
                                            <asp:HiddenField ID="Id" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecionarAtas"><%# Eval("Titulo")%></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="10%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklAdd" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="Novo">Up-Load</asp:LinkButton>
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
                        <asp:Button ID="SalvarArquivos" runat="server" class="btn btn-primary" Text="Salvar Arquivos" EnableEventValidation="false" />
                    </div>

                </div>

            </div>
        </div>

    </div>


</asp:Content>
