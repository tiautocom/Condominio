<%@ Page Title="Controle de Receitas e Despesas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReceitasDespesas.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.ReceitasDespesas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">

            <h3>Controle de Receitas e Despesas</h3>

            <hr />

            <div class="row">
                <div class="col-md-12">
                    <ul typeof="circle">
                        <li>Controle de Despesas/Receitas do Condominio</li>
                    </ul>

                </div>

            </div>
            <hr />

            <div class="row">
                <div class="col-md-12">
                    <asp:GridView ID="gdvGrupo" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" ShowHeader="False">
                        <Columns>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:LinkButton ID="Grupos" DataKeyNames="Descricao" CommandName="ViewTransparencias" CommandArgument='<%# Eval("Id") %>' DataField="Grupos" runat="server" Text='<%# Eval("Descricao") %>'></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

            <div class="table-responsive">
            </div>

            <div class="form-group">
                <asp:Button ID="btnNovo" runat="server" Text="Nova Transparência" CssClass="btn btn-default" ToolTip="Salvar Nova Transparência" Visible="False" />
            </div>

            <div class="form-group">
                <div class="col-lg-10 ">
                    <%--<asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server">Voltar Página</asp:LinkButton>--%>
                    <input type="button" value="« voltar pagina" onclick="goBack()" style="display: inline-block; padding: 6px 12px; margin-bottom: 0; font-size: 14px; font-weight: normal; line-height: 1.428571429 text-align: center; white-space: nowrap; vertical-align: middle; cursor: pointer; border: 1px solid transparent; border-radius: 4px; -webkit-user-select: none; -moz-user-select: none; -ms-user-select: none; -o-user-select: none; user-select: none;" />

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

    
     <script>
         function goBack() {
             window.history.back()
         }
    </script>
</asp:Content>
