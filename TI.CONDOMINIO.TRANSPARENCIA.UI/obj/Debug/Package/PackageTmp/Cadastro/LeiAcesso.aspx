<%@ Page Title="Cadastro de Leis" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeiAcesso.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro.LeiAcesso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>

    <div class="form-horizontal">
       
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Desc" CssClass="col-md-2 control-label">Lei:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Desc" CssClass="form-control" TextMode="Search" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Desc"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"
                    Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados" ID="btnSalvar" OnClick="btnSalvar_Click" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
