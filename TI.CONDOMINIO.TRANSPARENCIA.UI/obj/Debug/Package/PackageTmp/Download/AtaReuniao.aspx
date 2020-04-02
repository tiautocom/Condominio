<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AtaReuniao.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Download.AtaReuniao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <h2>Transparências</h2>
                <h3>
                    <asp:Label ID="lblTitulo" runat="server" Text="..."></asp:Label>
                </h3>

                <div class="row">
                    <div>
                        <asp:TextBox ID="Pesquisar" runat="server" Style="height: 34px; padding: 6px 12px; font-size: 14px; line-height: 1.428571429; color: #555555; vertical-align: middle; background-color: #ffffff; background-image: none; border: 1px solid #cccccc; border-radius: 4px; -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); box-shadow: inset 0 1px 1px rgba(0, 0, 0, 0.075); -webkit-transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; transition: border-color ease-in-out 0.15s, box-shadow ease-in-out 0.15s; margin-right: 0px;" Width="100%" AutoPostBack="true" placeholder="Pesquisar Transparência"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Enter" class="btn btn-primary" />
                    </div>
                    <br />

                    <div class="table-responsive">
                 
                    </div>

                    <div class="table-responsive">
                        <asp:GridView ID="gdvNotLog" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" ShowHeader="False" OnRowCommand="gdvNotLog_RowCommand">
                            <Columns>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="Nomes" DataKeyNames="Descricao" CommandName="ViewTransparencias" CommandArgument='<%# Eval("Id") %>' DataField="Nomes" runat="server" Text='<%# Eval("Descricao") %>'></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                    <div>
                        <asp:Label ID="lblQtde" runat="server" Visible="False"></asp:Label>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="btnNovo" runat="server" Text="Nova Transparência" CssClass="btn btn-default" ToolTip="Salvar Nova Transparência" Visible="False" />
                    </div>

                    <div class="form-group">
                        <div class="col-lg-10 ">
                            <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server">Voltar Página</asp:LinkButton>
                        </div>
                    </div>

                    <br />
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                        </div>
                    </div>
                </div>

            </div>
        </div>

    </div>
</asp:Content>
