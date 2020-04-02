<%@ Page Title="AGENDA MENSAL DE FESTAS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarConvidado.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas.ListarConvidado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>
        function funcaoQueExibeModal() {
            $('#modalConvidado').modal();
        }

        function ShowPopupAddDates() {
            $('#addModalDates').modal('show');
        }

        function ShowPopupAddAlterarConv() {
            $('#modalConvidadoAlt').modal('show');
        }

    </script>

    <div class="page-container">
        <div class="container">
            <h3>Lista de Convidados</h3>
            <p>
                <asp:Literal ID="loginMorador" runat="server" />
            </p>
            <hr />

            <%--GRID  MORADOR--%>
            <div class="row">

                <div class="col-lg-12">
                    <div class="table-responsive">

                        <asp:GridView ID="gdvVisitantes" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." OnRowCommand="gdvVisitantes_RowCommand" DataKeyNames="Id, Nome_Visitante, id_tipo_Visitante, Tipo_M_V, Obs">
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
                                        <asp:ImageButton ID="Image1" runat="server" ImageUrl="~/Arquivos/Imagem/Imagens/trash-icon.png" Text='<%# Eval("ID") %>' OnClick="Display" CommandArgument='<%# Container.DataItemIndex%>' CommandName="DeletarConvidado" />
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:ImageButton ID="Image2" runat="server" ImageUrl="~/Arquivos/Imagem/Imagens/edit-icon.png" Text='<%# Eval("ID") %>' OnClick="DisplayAlterar" CommandArgument='<%# Container.DataItemIndex%>' CommandName="AlterarConvidado" />
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Nome Conviddo">
                                    <ItemTemplate>
                                        <asp:Label ID="lblDescricao" runat="server" Width="100%" Text='<%# Eval("Nome_Visitante") %>' CommandName="SelecionarTitular"></asp:Label>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="40%" HorizontalAlign="Left" Height="20px" />
                                </asp:TemplateField>

                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Tipo Convidado">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTipo" runat="server" Width="100%" Text='<%# Eval("Tipo_M_V") %>'></asp:Label>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="30%" HorizontalAlign="left" Height="20px" />
                                </asp:TemplateField>

                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Id Convidado" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="lblTipoVisitante" Width="300px" runat="server" Text='<%# Eval("id_tipo_Visitante") %>'></asp:Label>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="100%" HorizontalAlign="left" Height="20px" />
                                </asp:TemplateField>

                                <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Observação">
                                    <ItemTemplate>
                                        <asp:Label ID="lblObs" Width="100%" runat="server" Text='<%# Eval("Obs") %>'></asp:Label>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle Width="30%" HorizontalAlign="left" Height="20px" />
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

            <!-- Modal ADD -->
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
                            <asp:Button ID="btnSalvarDepedente" runat="server" Text="Salvar" class="btn btn-primary" Style="background-color: mediumseagreen; border-color: mediumseagreen" OnClick="SalvaVisitante_Click" />

                        </div>

                    </div>
                </div>
            </div>


            <div class="modal fade" id="addModalDatesS" tabindex="-1" role="dialog" aria-labelledby="addModalDates">
                <div class="modal-dialog" role="document" style="width: 600px;">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        </div>
                        <div class="modal-body">
                            <div style="margin-top: 10px;">
                                <label style="font-weight: bold; display: block;">First Name <span style="color: red;">*</span></label>
                                <asp:TextBox runat="server" ID="txtFname"></asp:TextBox>
                            </div>
                            <div style="margin-top: 10px;">
                                <label style="font-weight: bold; display: block;">Last Name <span style="color: red;">*</span></label>
                                <asp:TextBox runat="server" ID="txtLName"></asp:TextBox>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
                            <asp:Button runat="server" ID="Button1" class="btn btn-success" Text="Save"></asp:Button>
                        </div>
                    </div>
                </div>
            </div>


            <!-- Modal DELETE CONVIDADO-->
            <div class="modal fade" id="addModalDates" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalCenterTitle">Deletar Convidado</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            Realmente Deseja Deletar Convidado Selecionado?
                                  <h3>
                                      <asp:Literal ID="ltrNome" runat="server" />
                                  </h3>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                            <asp:Button ID="Button2" runat="server" Text="Deletar" CssClass="btn btn-primary" OnClick="DeletarConvidado_Click" />
                        </div>
                    </div>
                </div>
            </div>

            <!-- Modal UPDATE -->
            <div class="modal fade" id="modalConvidadoAlt" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title">Alterar Convidados</h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="txtNomeAlt" CssClass="col-md-4 control-label">Nome Convidado(a)</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtNomeAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>


                                <asp:Label runat="server" AssociatedControlID="ddTipoAlt" CssClass="col-md-4 control-label">Tipo de Convidado</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddTipoAlt" CssClass="form-control" runat="server" ControlToValidate="ddTipoAlt" Width="100%" AppendDataBoundItems="false" Height="34px">
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtObsAlt" CssClass="col-md-2 control-label">Observação</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtObsAlt" CssClass="form-control" TextMode="MultiLine" Rows="5" Width="100%" />
                                </div>

                            </div>

                        </div>

                        <br />

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" style="background-color: #428bca; border-color: #428bca; color: white;">Fechar</button>
                            <asp:Button ID="Button3" runat="server" Text="Salvar" class="btn btn-primary" Style="background-color: mediumseagreen; border-color: mediumseagreen" OnClick="AlterarVisitante_Click" />

                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
