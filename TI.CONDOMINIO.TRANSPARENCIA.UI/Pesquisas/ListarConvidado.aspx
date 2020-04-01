<%@ Page Title="AGENDA MENSAL DE FESTAS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarConvidado.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas.ListarConvidado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        function funcaoQueExibeModal() {
            $('#modalConvidado').modal();
        }
    </script>

    <div class="page-container">
        <div class="container">
            <hr />
            <h3>Lista de Convidados</h3>
            <p>
                <asp:Literal ID="loginMorador" runat="server" />
            </p>
            <hr />

            <%--GRID  MORADOR--%>
            <div class="row">

                <div class="col-lg-12">
                    <div class="table-responsive">

                        <asp:GridView ID="gdvVisitantes" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir.">
                            <Columns>

                                <asp:TemplateField Visible="false" HeaderText="ID">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink1" runat="server" Text='<%# Eval("ID") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Nome Titular">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lblDescricao" Width="300px" runat="server" Text='<%# Eval("Nome_Visitante") %>' CommandName="SelecionarTitular"></asp:LinkButton>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="100%" HorizontalAlign="Center" Height="30px" />
                                </asp:TemplateField>

                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Tipo Convidado">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTipo" Width="300px" runat="server" Text='<%# Eval("Tipo_M_V") %>'></asp:Label>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="100%" HorizontalAlign="Center" Height="30px" />
                                </asp:TemplateField>

                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Observação">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lblObs" Width="300px" runat="server" Text='<%# Eval("Obs") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="100%" HorizontalAlign="Center" Height="30px" />
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>

                    </div>

                    <div class="form-group">
                        <asp:Button runat="server"
                            Text="Novo de Convidados" CssClass="btn btn-default" ToolTip="Cadastro de Convidados" data-toggle="modal" data-target="#modalConvidado" OnClick="Unnamed1_Click" />
                    </div>

                </div>

            </div>

            <!-- Modal DEPEDENTE -->
            <div class="modal fade" id="modalConvidado" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="exampleModalLabel">Adicionar Convidados</h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="txtNome" CssClass="col-md-4 control-label">Nome Convidado(a)</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>


                                <asp:Label runat="server" AssociatedControlID="ddTipo" CssClass="col-md-4 control-label">Tipo de Convidado</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddTipo" CssClass="form-control" runat="server" ControlToValidate="ddTipo" Width="100%" AppendDataBoundItems="true" Height="34px">
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtObs" CssClass="col-md-2 control-label">Observação</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtObs" CssClass="form-control" TextMode="MultiLine" Rows="5" Width="100%" />
                                </div>

                            </div>

                        </div>

                        <br />

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" style="background-color: #428bca; border-color: #428bca; color: white;">Fechar</button>
                            <asp:Button ID="btnSalvarDepedente" runat="server" Text="Salvar" class="btn btn-primary" Style="background-color: mediumseagreen; border-color: mediumseagreen" OnClick="SalvaVisitante_Click"/>

                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
