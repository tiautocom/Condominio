<%@ Page Title="Cadastro de Moradores" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Moradores.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro.Moradores" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2><%: Title %></h2>

    <div class="form-horizontal">

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlTorre" CssClass="col-md-2 control-label">Torre:</asp:Label>
            <div class="col-md-2">
                <asp:DropDownList ID="ddlTorre" CssClass="form-control" runat="server" ControlToValidate="ddlTorre" Width="100%" AppendDataBoundItems="true" Height="34px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Label runat="server" AssociatedControlID="ddlBlco" CssClass="col-md-2 control-label">Bloco:</asp:Label>
            <div class="col-md-2">
                <asp:DropDownList ID="ddlBlco" CssClass="form-control" runat="server" ControlToValidate="ddlBlco" Width="100%" AppendDataBoundItems="true" Height="34px">
                    <asp:ListItem>A</asp:ListItem>
                    <asp:ListItem>B</asp:ListItem>
                    <asp:ListItem>C</asp:ListItem>
                    <asp:ListItem>D</asp:ListItem>
                    <asp:ListItem>E</asp:ListItem>
                    <asp:ListItem>F</asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Label runat="server" AssociatedControlID="ddlApto" CssClass="col-md-2 control-label">Apartamento:</asp:Label>
            <div class="col-md-2">
                <asp:DropDownList ID="ddlApto" CssClass="form-control" runat="server" ControlToValidate="ddlApto" Width="100%" AppendDataBoundItems="true" Height="34px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                    <asp:ListItem>32</asp:ListItem>
                    <asp:ListItem>33</asp:ListItem>
                    <asp:ListItem>34</asp:ListItem>
                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlBlco" CssClass="col-md-2 control-label">Tipo Morador:</asp:Label>
            <div class="col-md-6">
                <asp:DropDownList ID="ddTipoMorador" CssClass="form-control" runat="server" ControlToValidate="ddlBlco" Width="100%" AppendDataBoundItems="true" Height="34px">
                    <asp:ListItem>PROPRIETÁRIO</asp:ListItem>
                    <asp:ListItem>INQUILINO</asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Label runat="server" AssociatedControlID="DataNiver" CssClass="col-md-2 control-label">Data Nascimento:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="DataNiver" CssClass="form-control" TextMode="Date" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="DataNiver"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>


            <asp:Label runat="server" AssociatedControlID="Titular" CssClass="col-md-2 control-label">Titular:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Titular" CssClass="form-control" TextMode="Search" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Titular"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>

            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">E-Mail:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" Width="200%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>

            <asp:Label runat="server" AssociatedControlID="Cpf" CssClass="col-md-2 control-label">CPF:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Cpf" CssClass="form-control" TextMode="Search" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Cpf"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>

            <asp:Label runat="server" AssociatedControlID="Rg" CssClass="col-md-2 control-label">R.G:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Rg" CssClass="form-control" TextMode="Search" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Rg"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>


            <asp:Label runat="server" AssociatedControlID="Telefone" CssClass="col-md-2 control-label">Telefone:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Telefone" CssClass="form-control" TextMode="Phone" Width="100%" />
                <%--<asp:RequiredFieldValidator runat="server" ControlToValidate="Telefone"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />--%>
            </div>

            <asp:Label runat="server" AssociatedControlID="Celular" CssClass="col-md-2 control-label">Celular:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Celular" CssClass="form-control" TextMode="Phone" Width="100%" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Celular"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
            </div>

            <asp:Label runat="server" AssociatedControlID="Celular" CssClass="col-md-2 control-label">Comercial:</asp:Label>
            <div class="col-md-2">
                <asp:TextBox runat="server" ID="Comercial" CssClass="form-control" TextMode="Phone" Width="100%" />
          <%--      <asp:RequiredFieldValidator runat="server" ControlToValidate="Comercial"
                    CssClass="text-danger" ErrorMessage="Campo Obrigatório." />--%>
            </div>
        </div>


        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Obs" CssClass="col-md-2 control-label">Observação:</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Obs" CssClass="form-control" TextMode="MultiLine" Width="100%" />
            </div>

        </div>

        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ddlAtivo" CssClass="col-md-2 control-label">Status:</asp:Label>
            <div class="col-md-2">
                <asp:DropDownList ID="ddlAtivo" CssClass="form-control" runat="server" ControlToValidate="ddlAtivo" Width="100%" AppendDataBoundItems="true" Height="34px">
                    <asp:ListItem Value="1">ATIVO</asp:ListItem>
                    <asp:ListItem Value="0">INATIVO</asp:ListItem>
                </asp:DropDownList>
            </div>

        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server"
                    Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" OnClick="Unnamed23_Click" />
            </div>

        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
            </div>
        </div>
    </div>

</asp:Content>
