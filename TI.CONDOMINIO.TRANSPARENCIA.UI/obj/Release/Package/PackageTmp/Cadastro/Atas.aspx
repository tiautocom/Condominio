<%@ Page Title="Cadastro de Atas" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atas.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro.Atas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">

            <h2><%: Title %></h2>

            <div class="form-horizontal">
                <asp:HiddenField ID="hfId" runat="server" />

                <hr />
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <p class="text-danger">
                    <asp:Literal runat="server" ID="ErrorMessage" />
                </p>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="ddlTipoAssembleia" CssClass="col-md-2 control-label">Tipo de Assembléia:</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList ID="ddlTipoAssembleia" CssClass="form-control" runat="server" ControlToValidate="ddlTipoAssembleia" Width="100%" AppendDataBoundItems="true" Height="34px">
                            <asp:ListItem>Ordinária</asp:ListItem>
                            <asp:ListItem>Extraordinária</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Titulo" CssClass="col-md-2 control-label">Titulo:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Titulo" CssClass="form-control" TextMode="Search" Width="100%" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Titulo" CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>

                    <asp:Label runat="server" AssociatedControlID="Sindico" CssClass="col-md-2 control-label">Sindico:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Sindico" CssClass="form-control" TextMode="Search" Width="100%" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Sindico" CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>

                    <asp:Label runat="server" AssociatedControlID="subSindico" CssClass="col-md-2 control-label">Sub-Sindico:</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="subSindico" CssClass="form-control" TextMode="Search" Width="100%" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="subSindico" CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>

                    <asp:Label runat="server" AssociatedControlID="flUpFile" CssClass="col-md-2 control-label">Arquivo:</asp:Label>
                    <div class="col-md-10">
                        <asp:FileUpload ID="flUpFile" runat="server" CssClass="form-control" AllowMultiple="True" Multiple="Multiple" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="flUpFile" CssClass="text-danger" ErrorMessage="Campo Obrigatório." />
                    </div>

                    <asp:Label runat="server" AssociatedControlID="dataGaleria" CssClass="col-md-2 control-label">Data Evento:</asp:Label>
                    <div class='col-sm-3'>
                        <div class='input-group date' id='datetimepicker1'>
                            <asp:TextBox ID="dataGaleria" runat="server" CssClass="form-control" data-date-format="DD/MM/YYYY"></asp:TextBox>
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>

                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-4">
                        <asp:Button runat="server" Text="Salvar" CssClass="btn btn-default" Width="130px" ToolTip="Salvar Dados Usuário" />
                    </div>
                </div>


                <div class="form-group">
                    <div class="col-md-offset-12 col-md-10">
                        <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                    </div>
                </div>

            </div>
        </div>

        <script type="text/javascript">
            $(function () {
                $('#datetimepicker1').datetimepicker();
            });
        </script>

        <link rel="stylesheet" href="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/build/css/bootstrap-datetimepicker.css" />
        <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.9.0/moment-with-locales.js"></script>
        <script type="text/javascript" src="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/src/js/bootstrap-datetimepicker.js"></script>
    </div>

</asp:Content>
