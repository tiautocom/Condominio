<%@ Page Title="Cadastro de Grupos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grupo.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro.Grupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>

    <div class="form-horizontal">

        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <p class="text-danger">
            <asp:Literal runat="server" ID="ErrorMessage" />
        </p>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlEmpresa" CssClass="col-md-2 control-label">Empresa:</asp:Label>
            <div class="col-md-10">
                <asp:DropDownList ID="ddlEmpresa" CssClass="form-control" runat="server" ControlToValidate="ddlEmpresa" Width="100%" AppendDataBoundItems="true" Height="34px">
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Desc" CssClass="col-md-2 control-label">Descrição:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Desc" CssClass="form-control" TextMode="Search" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Desc"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"
                    Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" OnClick="Unnamed5_Click" />
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
