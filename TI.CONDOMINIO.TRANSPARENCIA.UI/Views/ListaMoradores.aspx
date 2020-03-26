<%@ Page Title="LISTA DE MORADORES" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaMoradores.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.ListaMoradores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-container">
        <div class="container">
            <hr />
            <h3>Lista de Moradores</h3>
            <hr />

            <div class="form-group">

                <div class="col-md-3" style="padding:10px">
                    <asp:DropDownList ID="ddlTorre" CssClass="form-control" runat="server" ControlToValidate="ddlTorre" Width="100%" AppendDataBoundItems="true" Height="34px">
                        <asp:ListItem Value="0">FILTRO DE PESQUISA</asp:ListItem>
                        <asp:ListItem Value="1">NOME TITULAR</asp:ListItem>
                        <asp:ListItem Value="2">CPF</asp:ListItem>
                        <asp:ListItem Value="3">RG</asp:ListItem>
                        <asp:ListItem Value="4">TELEFONE</asp:ListItem>
                        <asp:ListItem Value="5">PLACA</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="col-md-7">

                    <asp:TextBox ID="txtPesquisar" runat="server" Style="height: 34px; padding: 6px 12px; font-size: 14px; line-height: 1.428571429; color: #555555; vertical-align: middle; background-color: #ffffff; background-image: none; border: 1px solid #cccccc; border-radius: 4px; -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); -webkit-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; margin-right: 0px;" Width="100%" AutoPostBack="true" placeholder="Filtro de Pesquisas" TextMode="SingleLine"></asp:TextBox>

                    <br />
                    <br />
                </div>
                    <asp:Button ID="Button1" runat="server" Text="Pesquisar" class="btn btn-primary" OnClick="Button1_Click" />

            </div>

            <%--GRID  MORADOR--%>
            <div class="row">
                

                <div class="col-lg-12">
                    <div class="table-responsive">
                        <asp:GridView ID="gdvMorador" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False"  DataKeyNames="Id, Titular, Rg, Cpf, Torre, Bloco, Apto, Telefone, Celular" OnRowCommand="gdvMorador_RowCommand">
                            <Columns>

                                <asp:TemplateField HeaderText="Nome Titular">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="HyperLink" runat="server" Text='<%# Eval("Titular") %>' CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelecionarMorador" Width="70%" CssClass="btn btn-dark"></asp:LinkButton>
                                    </ItemTemplate>
                                    <FooterStyle CssClass="table" />
                                    <ItemStyle HorizontalAlign="Left" Height="30px" />
                                </asp:TemplateField>

                                <asp:TemplateField FooterText="Nome Titular" HeaderText="Torre">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink3" runat="server" NavigateUrl="" Text='<%# Eval("Torre") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField FooterText="Nome Titular" HeaderText="Bloco">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink4" runat="server" NavigateUrl="" Text='<%# Eval("Bloco") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>


                                <asp:TemplateField FooterText="Nome Titular" HeaderText="Apto">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink5" runat="server" NavigateUrl="" Text='<%# Eval("Apto") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField FooterText="Nome Titular" HeaderText="Celular">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink7" runat="server" NavigateUrl="" Text='<%# Eval("Celular") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField FooterText="Nome Titular" HeaderText="R.G">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink1" runat="server" NavigateUrl="" Text='<%# Eval("Rg") %>' ReadOnly="true" Width="120px"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField FooterText="Nome Titular" HeaderText="C.P.F">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink2" runat="server" NavigateUrl="" Text='<%# Eval("Cpf") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField FooterText="Nome Titular" HeaderText="Telefone" Visible="false">
                                    <ItemTemplate>
                                        <asp:Label ID="HyperLink6" runat="server" NavigateUrl="" Text='<%# Eval("Telefone") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField FooterText="Nome Titular" HeaderText="Status" Visible="false">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="HyperLink13" runat="server" NavigateUrl="" Text='<%# Eval("Ativo") %>'></asp:CheckBox>
                                    </ItemTemplate>
                                </asp:TemplateField>

                            </Columns>
                        </asp:GridView>
                    </div>
                </div>

                <%--            <div class="col-md-10">
                        <p>
                            <asp:Button ID="btnSair" runat="server" Text="Sair" Width="100px" class="btn btn-default" />
                        </p>
                    </div>--%>
            </div>

            <div class="col-lg-10 ">
                <b>
                    <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                </b>
            </div>
        </div>

    </div>


</asp:Content>
