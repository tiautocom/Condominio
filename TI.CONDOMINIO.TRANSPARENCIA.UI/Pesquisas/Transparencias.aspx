<%@ Page Title="Lista de Transparências" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Transparencias.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas.Transparencias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <hr />
                <h3>Transparências</h3>
                <h5>
                    <asp:Literal ID="DesLai" runat="server" />
                </h5>
                <hr />
                <div class="row">

                    <div class="col-lg-10 ">
                        <div class="table-responsive">
                            <asp:GridView ID="gdvTransparencia" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False" EnableModelValidation="False" DataKeyNames="Id, Descricao" OnRowCommand="gdvTransparencia_RowCommand">
                                <Columns>

                                    <asp:TemplateField>
                                        <ItemStyle Width="80%" />
                                        <ItemTemplate>
                                            <asp:HiddenField ID="hfId" runat="server" Value='<%# Eval("Id") %>' />
                                            <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecionarLai"><%# Eval("Descricao")%></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="5%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklDele" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="Deletar">Delete</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="5%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklUpdate" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="Alterar">Alterar</asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField>
                                        <ItemStyle Width="10%" />
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lklUpLoad" runat="server" CommandArgument='<%# Container.DataItemIndex%>' CommandName="UpLoad">Up-Load</asp:LinkButton>
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


        <%-- MODAL UPDATE--%>
        <div class="modal fade" id="modalAlterar" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">

                <div class="modal-content">
                    <div class="modal-header">

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <h3 class="modal-title" id="exampleModalLabelAlt">Alterar Nome da Transparências</h3>
                        <h5>
                            <asp:Literal runat="server" ID="DescLai" />
                        </h5>

                        <hr />

                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Nome Transparência:</label>
                            <asp:TextBox ID="txtTransparencia" CssClass="form-control" runat="server" TextMode="Search" Width="100%"></asp:TextBox>
                        </div>

                        <%--         <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Arquivos:</label>
                            <asp:FileUpload ID="flUpFile" runat="server" CssClass="form-control" AllowMultiple="True" Multiple="Multiple" />
                        </div>--%>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="SalvarArquivos" runat="server" class="btn btn-primary" Text="Salvar Transparência" EnableEventValidation="false" />
                    </div>
                </div>

            </div>
        </div>

        <%-- MODAL DELETAR--%>
        <div id="modalDeletar" class="modal" tabindex="-1" role="dialog">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">
                        <h3 class="modal-title">Confirmação para Exclusão</h3>
                        <h4>Realmente Deseja Excluir Transparência: </h4>
                        <h5>
                            <asp:Literal ID="desLaiAlt" runat="server" />
                        </h5>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnSalvar" runat="server" class="btn btn-primary" Text="Salvar" OnClick="DeltarArquivos_Click" />
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>

        <%-- MODAL UPLOAD--%>
        <div class="modal fade" id="modalUpload" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            <div class="modal-dialog" role="document">

                <div class="modal-content">
                    <div class="modal-header">

                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span>
                        </button>
                    </div>
                    <div class="modal-body">

                        <h3 class="modal-title" id="exampleModalLabelUpload">Up-Load de Arquivo para Transparência</h3>
                        <h5>
                            <asp:Literal runat="server" ID="Literal1" />
                        </h5>

                        <hr />

                        <div class="form-group">
                            <label for="recipient-name" class="col-form-label">Arquivos:</label>
                            <asp:FileUpload ID="flUpFile" runat="server" CssClass="form-control" AllowMultiple="True" Multiple="Multiple" />
                        </div>
                    </div>
                    <div class="modal-footer">
                        <asp:Button ID="btnsalvarUpload" runat="server" class="btn btn-primary" Text="Salvar Arquivos" EnableEventValidation="false" OnClick="btnsalvarUpload_Click" />
                    </div>
                </div>

            </div>
        </div>

    </div>

</asp:Content>
