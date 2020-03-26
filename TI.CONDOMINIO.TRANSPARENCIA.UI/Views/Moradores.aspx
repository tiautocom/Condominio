<%@ Page Title="DETALHES DO MORADOR" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Moradores.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.Moradores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script>

        function funcaoQueExibeModal() {
            $('#modaltitular').modal();
        }

        function funcaoQueExibeObservacao() {
            $('#modalObsItem').modal();
        }

        function funcaoQueExibeVeixulo() {
            $('#exampleModalVeiculoAlt').modal();
        }

        function funcaoQueExibemoradorDepedente() {
            $('#exampploModalAlterarDepedente').modal();
        }

        function changeBgColor(element) {
            if (element.className === 'row-clicked') {
                element.className = '';
            } else {
                element.className = 'row-clicked';
            }
        }

    </script>

    <div class="shadowBox">

        <div class="page-container">

            <div class="container">

                <div class="row">

                    <div class="col-lg-12">
                        <h3>Detalhes do Morador</h3>

                        <div class="table-responsive">
                            <asp:GridView ID="gdvMorador" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." OnRowCommand="gdvMorador_RowCommand" DataKeyNames="Id, Titular, Torre, Bloco, Apto, Email, Telefone, Celular, Comercial, TipoMorador, Rg, Cpf, Ativo">
                                <Columns>

                                    <asp:TemplateField Visible="false" HeaderText="ID">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink1" runat="server" NavigateUrl="" Text='<%# Eval("Id") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField FooterStyle-CssClass="table" HeaderText="Nome Titular">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="lblDescricao" Width="300px" runat="server" Text='<%# Eval("Titular") %>' CommandName="SelecionarTitular" CommandArgument='<%# Container.DataItemIndex%>'></asp:LinkButton>
                                        </ItemTemplate>
                                        <FooterStyle CssClass="table" />
                                        <ItemStyle Width="100%" HorizontalAlign="Center" Height="30px" />
                                    </asp:TemplateField>

                                    <%--        <asp:BoundField DataField="TITULAR" HeaderText="NOME DO TITULAR" />--%>
                                    <asp:BoundField DataField="TORRE" HeaderText="Torre" />
                                    <asp:BoundField DataField="BLOCO" HeaderText="Bloco" />
                                    <asp:BoundField DataField="APTO" HeaderText="Apartamento" />
                                    <asp:BoundField DataField="EMAIL" HeaderText="E-Mail" Visible="false" />
                                    <asp:BoundField DataField="CELULAR" HeaderText="Celular" />
                                    <asp:BoundField DataField="COMERCIAL" HeaderText="Comercial" Visible="false" />
                                    <asp:BoundField DataField="TIPO" HeaderText="TipoMorador" Visible="false" />
                                    <asp:BoundField DataField="RG" HeaderText="R.G" Visible="false" />
                                    <asp:BoundField DataField="CPF" HeaderText="C.P.F" Visible="false" />

                                </Columns>
                            </asp:GridView>
                        </div>

                    </div>

                </div>

                <%--GRID DEPEDENTE--%>
                <div class="row">

                    <div class="col-lg-12">

                        <div class="table-responsive">
                            <asp:GridView ID="gdvDepedente" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" Width="100%" EmptyDataText="Não há registros de dados para exibir." DataKeyNames="Id, Nome, Tipo, Genero, Idade" OnRowCommand="gdvDepedente_RowCommand" OnSelectedIndexChanged="gdvDepedente_SelectedIndexChanged">
                                <Columns>

                                    <asp:TemplateField HeaderText="Nome Depedente" Visible="false">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="HyperLink20" runat="server" Text='<%# Eval("Id") %>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Nome Depedente">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="HyperLink21" Width="300px" runat="server" Text='<%# Eval("Nome") %>' CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecionarMoradorDep"></asp:LinkButton>
                                        </ItemTemplate>
                                        <FooterStyle CssClass="table" />
                                        <ItemStyle Width="100%" HorizontalAlign="Center" Height="20px" />
                                    </asp:TemplateField>

                                    <asp:TemplateField FooterText="Tipo" HeaderText="Tipo">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink22" runat="server" NavigateUrl="" Text='<%# Eval("Tipo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField FooterText="Genero" HeaderText="Genero">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink23" runat="server" NavigateUrl="" Text='<%# Eval("Genero") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField FooterText="Nome Titular" HeaderText="Idade">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink24" runat="server" NavigateUrl="" Text='<%# Eval("Idade") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                </div>


                <%--GRID VEICULO--%>
                <div class="row">

                    <div class="col-lg-12">


                        <div class="table-responsive">
                            <asp:GridView ID="gdvVeiculo" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" Width="100%" EmptyDataText="Não há registros de dados para exibir." DataKeyNames="Id, Tipo, Marca, Modelo, Cor, Placa, NumVaga" OnRowCommand="gdvVeiculo_RowCommand" OnSelectedIndexChanged="gdvVeiculo_SelectedIndexChanged">
                                <Columns>

                                    <asp:TemplateField FooterText="Tipo Veiculo" HeaderText="Tipo Veiculo" Visible="false">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="HyperLink19" runat="server" NavigateUrl="" Text='<%# Eval("Id") %>' CommandArgument='<%# Container.DataItemIndex%>'></asp:LinkButton>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField FooterText="Tipo Veiculo" HeaderText="Tipo Veiculo">
                                        <ItemTemplate>
                                            <asp:LinkButton ID="HyperLink8" Width="300px" runat="server" NavigateUrl="" Text='<%# Eval("Tipo") %>' CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecionarVeiculo"></asp:LinkButton>
                                        </ItemTemplate>
                                        <FooterStyle CssClass="table" />
                                        <ItemStyle Width="60%" HorizontalAlign="Center" Height="30px" />
                                    </asp:TemplateField>

                                    <asp:TemplateField HeaderText="Marca">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink9" runat="server" Text='<%# Eval("Marca") %>' CommandArgument='<%# Container.DataItemIndex%>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField FooterText="Modelo" HeaderText="Modelo">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink10" runat="server" NavigateUrl="" Text='<%# Eval("Modelo") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField FooterText="Cor" HeaderText="Cor">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink11" runat="server" NavigateUrl="" Text='<%# Eval("Cor") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>


                                    <asp:TemplateField FooterText="Placa" HeaderText="Placa">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink12" runat="server" NavigateUrl="" Text='<%# Eval("Placa") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                    <asp:TemplateField FooterText="Placa" HeaderText="Nº Vaga">
                                        <ItemTemplate>
                                            <asp:Label ID="HyperLink23" runat="server" NavigateUrl="" Text='<%# Eval("NumVaga") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>

                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                </div>

                <hr />

                <div class="col-md-4 col-sm-2">
                    <asp:Button ID="btnBroto" runat="server" Text="ADICIONAR DEPEDENTE" class="btn btn-warning btn-lg active" ria-pressed="true" Width="100%" ToolTip="Adicione um morador dependente" TabIndex="1" data-toggle="modal" data-target="#exampleModal" />
                    <br />
                    <br />
                </div>

                <div class="col-md-4 col-sm-8">
                    <asp:Button ID="btnMedia" runat="server" Text="ADICINAR VEICULO" class="btn btn-success btn-lg active" ria-pressed="true" Width="100%" TabIndex="2" data-toggle="modal" data-target="#exampleModalVeiculo" />
                    <br />
                    <br />

                </div>

                <hr />
            </div>

            <!-- Modal DEPEDENTE -->
            <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="exampleModalLabel">Adicionar Depedente(s)</h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="txtNome" CssClass="col-md-2 control-label">Nome</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtNome" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="ddlGenero" CssClass="col-md-4 control-label">Genero</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlGenero" CssClass="form-control" runat="server" ControlToValidate="ddlGenero" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>MASCULINO</asp:ListItem>
                                        <asp:ListItem>FEMENINO</asp:ListItem>
                                    </asp:DropDownList>
                                </div>


                                <asp:Label runat="server" AssociatedControlID="ddTipo" CssClass="col-md-4 control-label">Tipo de Morador</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddTipo" CssClass="form-control" runat="server" ControlToValidate="ddlBlco" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>MARIDO</asp:ListItem>
                                        <asp:ListItem>ESPOSA</asp:ListItem>
                                        <asp:ListItem>FILHO(A)</asp:ListItem>
                                        <asp:ListItem>MÃE</asp:ListItem>
                                        <asp:ListItem>IRMÃO(Ã)</asp:ListItem>
                                        <asp:ListItem>OUTROS</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtIdade" CssClass="col-md-2 control-label">Idade</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtIdade" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                            </div>

                        </div>

                        <br />

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" style="background-color: #428bca; border-color: #428bca; color:white;">Fechar</button>
                            <asp:Button ID="btnSalvarDepedente" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnSalvarDepedente_Click" Style="background-color: mediumseagreen; border-color: mediumseagreen" />

                        </div>

                    </div>
                </div>
            </div>

            <!-- Modal VEICULO -->
            <div class="modal fade" id="exampleModalVeiculo" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="exampleModalLabel">Adicionar Veiculos(s)</h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="ddlTipoVeiculo" CssClass="col-md-4 control-label">Veiculo</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlTipoVeiculo" CssClass="form-control" runat="server" ControlToValidate="ddlTipoVeiculo" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>CARRO</asp:ListItem>
                                        <asp:ListItem>MOTOCICLETA</asp:ListItem>
                                        <asp:ListItem>BICICLETA</asp:ListItem>
                                        <asp:ListItem>TRICICULO</asp:ListItem>
                                        <asp:ListItem>CAMINHOTE</asp:ListItem>
                                        <asp:ListItem>PICK-UP</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtMarca" CssClass="col-md-2 control-label">Marca</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtMarca" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtModelo" CssClass="col-md-2 control-label">Modelo</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtModelo" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtCor" CssClass="col-md-2 control-label">Cor</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtCor" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtPlaca" CssClass="col-md-2 control-label">Placa</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtPlaca" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtNumVaga" CssClass="col-md-2 control-label">Nº Vaga</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtNumVaga" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>


                            </div>

                        </div>

                        <br />

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" style="background-color: #428bca; border-color: #428bca; color:white;">Fechar</button>
                            <asp:Button ID="btnSalvarVeiculos" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnSalvarVeiculos_Click" Style="background-color: mediumseagreen; border-color: mediumseagreen" />
                        </div>
                    </div>
                </div>
            </div>

            <%-- MODAL TITULAR--%>
            <div class="modal fade" id="modaltitular" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h6 class="modal-title" id="exampleModalLabel">Alterar dos do Titular</h6>
                             <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                            <h3>
                                <asp:Literal ID="ltlTitular" runat="server"></asp:Literal>
                            </h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="ddlTipoAlt" CssClass="col-md-4 control-label">Tipo de Morador</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlTipoAlt" CssClass="form-control" runat="server" ControlToValidate="ddlTipoAlt" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>PROPRIETÁRIO</asp:ListItem>
                                        <asp:ListItem>INQUILINO</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtTitulatAlt" CssClass="col-md-6 control-label">Nome Titular</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtTitulatAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtRgAlt" CssClass="col-md-6 control-label">RG</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtRgAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtCpfAlt" CssClass="col-md-4 control-label">C.P.F</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtCpfAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtTorreAlt" CssClass="col-md-6 control-label">Torre</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtTorreAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtBlocoAlt" CssClass="col-md-4 control-label">Bloco</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtBlocoAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtAptoAlt" CssClass="col-md-4 control-label">Apartamento</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtAptoAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtEmailAlt" CssClass="col-md-4 control-label">E-Mail</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtEmailAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtTelefoneAlt" CssClass="col-md-4 control-label">Telefone</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtTelefoneAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtCelularAlt" CssClass="col-md-4 control-label">Celular</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtCelularAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtComercialAlt" CssClass="col-md-4 control-label">Tel.Comercial</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtComercialAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtObsAlt" CssClass="col-md-4 control-label">Observação</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtObsAlt" CssClass="form-control" TextMode="MultiLine" Width="100%" Rows="4" />
                                </div>

                                <div class="col-md-4">
                                    <asp:CheckBox runat="server" ID="cbxStatusAlt" Text="ATIVO" Checked="true" />
                                </div>

                            </div>

                        </div>

                        <div class="modal-footer">
                            <button type="button" class="btn btn-danger" data-dismiss="modal" style="background-color: #428bca; border-color: #428bca;">Fechar</button>
                            <asp:Button ID="btnAlterarDadosMorador" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnAlterarDadosMorador_Click" TabIndex="1" Style="background-color: mediumseagreen; border-color: mediumseagreen" />
                        </div>
                    </div>

                </div>
            </div>


            <%-- MODAL ALTERAR VEICULO--%>
            <div class="modal fade" id="exampleModalVeiculoAlt" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="exampleModalLabel">Alterar Dados Veiculo</h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="ddlTipoVeiculoAlt" CssClass="col-md-4 control-label">Veiculo</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlTipoVeiculoAlt" CssClass="form-control" runat="server" ControlToValidate="ddlTipoVeiculoAlt" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>CARRO</asp:ListItem>
                                        <asp:ListItem>MOTOCICLETA</asp:ListItem>
                                        <asp:ListItem>BICICLETA</asp:ListItem>
                                        <asp:ListItem>TRICICULO</asp:ListItem>
                                        <asp:ListItem>CAMINHOTE</asp:ListItem>
                                        <asp:ListItem>PICK-UP</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtMarcaAlt" CssClass="col-md-2 control-label">Marca</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtMarcaAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtModeloAlt" CssClass="col-md-2 control-label">Modelo</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtModeloAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtCorAlt" CssClass="col-md-2 control-label">Cor</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtCorAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtPlacaAlt" CssClass="col-md-2 control-label">Placa</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtPlacaAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtNumVagaAlt" CssClass="col-md-2 control-label">Nº Vaga</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtNumVagaAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>


                            </div>

                        </div>

                        <br />

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" style="background-color: #428bca; color: white; border-color: #428bca">Fechar</button>
                            <asp:Button ID="btnAlterarVeiculo" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnAlterarVeiculos_Click" Style="background-color: MediumSeaGreen; border-color: MediumSeaGreen" />
                            <asp:Button ID="btnDelete" runat="server" Text="Deletar" class="´btn btn-primary" OnClick="btnDeletarVeiculo_Click" Style="cursor: pointer; display: inline-block; -webkit-appearance: button; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429; text-align: center; white-space: nowrap; vertical-align: middle; border: 1px solid transparent; border-radius: 4px; background-color: #b22727; border-color: #b22727;" />

                        </div>
                    </div>
                </div>
            </div>


            <!-- Modal DEPEDENTE ALTERAR -->
            <div class="modal fade" id="exampploModalAlterarDepedente" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h3 class="modal-title" id="exampleModalLabel">Alterar Dados Depedente</h3>
                        </div>

                        <div class="modal-body">

                            <div class="form-group">

                                <asp:Label runat="server" AssociatedControlID="txtNomeDepAlt" CssClass="col-md-2 control-label">Nome</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtNomeDepAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                                <asp:Label runat="server" AssociatedControlID="ddlGeneroDepAlt" CssClass="col-md-4 control-label">Genero</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlGeneroDepAlt" CssClass="form-control" runat="server" ControlToValidate="ddlGeneroDepAlt" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>MASCULINO</asp:ListItem>
                                        <asp:ListItem>FEMENINO</asp:ListItem>
                                    </asp:DropDownList>
                                </div>


                                <asp:Label runat="server" AssociatedControlID="ddlTipoDepAlt" CssClass="col-md-4 control-label">Tipo de Morador</asp:Label>
                                <div class="col-md-12">
                                    <asp:DropDownList ID="ddlTipoDepAlt" CssClass="form-control" runat="server" ControlToValidate="ddlTipoDepAlt" Width="100%" AppendDataBoundItems="true" Height="34px">
                                        <asp:ListItem>MARIDO</asp:ListItem>
                                        <asp:ListItem>ESPOSA</asp:ListItem>
                                        <asp:ListItem>FILHO(A)</asp:ListItem>
                                        <asp:ListItem>MÃE</asp:ListItem>
                                        <asp:ListItem>IRMÃO(Ã)</asp:ListItem>
                                        <asp:ListItem>OUTROS</asp:ListItem>
                                    </asp:DropDownList>
                                </div>

                                <asp:Label runat="server" AssociatedControlID="txtIdadeDepAlt" CssClass="col-md-2 control-label">Idade</asp:Label>
                                <div class="col-md-12">
                                    <asp:TextBox runat="server" ID="txtIdadeDepAlt" CssClass="form-control" TextMode="Search" Width="100%" />
                                </div>

                            </div>

                        </div>

                        <br />

                        <div class="modal-footer">
                            <button type="button" class="btn btn-secondary" data-dismiss="modal" style="background-color: #428bca; border-color: #428bca; color: white">Fechar</button>
                            <asp:Button ID="btnAlterarDadosDepedente" runat="server" Text="Salvar" class="btn btn-primary" OnClick="btnAlterarDepedentes_Click" Style="background-color: MediumSeaGreen; border-color: MediumSeaGreen" />
                            <asp:Button ID="btnDeletarDepedente" runat="server" Text="Deletar" OnClick="btnDeletarDepedente_Click" Style="color:white; cursor: pointer; display: inline-block; -webkit-appearance: button; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429; text-align: center; white-space: nowrap; vertical-align: middle; border: 1px solid transparent; border-radius: 4px; background-color: #b22727; border-color: #b22727;" />
                        </div>
                    </div>
                </div>
            </div>

        </div>

    </div>

</asp:Content>


