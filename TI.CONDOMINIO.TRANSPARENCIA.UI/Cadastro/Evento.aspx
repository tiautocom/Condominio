<%@ Page Title="Cadastro de Agenda de Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro.Evento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">

        <div class="page-container">

            <div class="form-horizontal">

                <h2><%: Title %></h2>
                <hr />

                <div class="form-group">

                    <asp:Label runat="server" AssociatedControlID="dataGaleria" CssClass="col-md-2 control-label">Data:</asp:Label>
                    <div class='col-sm-2'>
                        <div class='input-group date' id='datetimepicker1'>
                            <asp:TextBox ID="dataGaleria" runat="server" CssClass="form-control" data-date-format="DD/MM/YYYY"></asp:TextBox>
                            <span class="input-group-addon">
                                <span class="glyphicon glyphicon-calendar"></span>
                            </span>
                        </div>
                    </div>


                    <asp:Label runat="server" AssociatedControlID="ddlLocal" CssClass="col-md-2 control-label">Local:</asp:Label>
                    <div class="col-md-2">
                        <asp:DropDownList ID="ddlLocal" CssClass="form-control" runat="server" ControlToValidate="ddlLocal" Width="100%" AppendDataBoundItems="true" Height="34px">
                            <asp:ListItem Value="1">SALÃO DE FESTA</asp:ListItem>
                            <asp:ListItem Value="2">CHURRASQUEIRA</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>


                <div class="form-group">

                    <asp:Label runat="server" AssociatedControlID="horaInicio" CssClass="col-md-2 control-label">Hora Inicio:</asp:Label>
                    <div class="col-md-2">
                        <asp:TextBox runat="server" ID="horaInicio" CssClass="form-control" Width="100%" TextMode="Time" />
                    </div>

                    <asp:Label runat="server" AssociatedControlID="horaFim" CssClass="col-md-2 control-label">Hora Fim:</asp:Label>
                    <div class="col-md-2">
                        <asp:TextBox runat="server" ID="horaFim" CssClass="form-control" Width="100%" TextMode="Time" />
                    </div>

                </div>

                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Obs" CssClass="col-md-2 control-label">Observação:</asp:Label>
                    <div class="col-md-6">
                        <asp:TextBox runat="server" ID="Obs" CssClass="form-control" TextMode="MultiLine" Rows="10" Width="100%" />
                    </div>

                </div>


                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Button runat="server"
                            Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" OnClick="Unnamed6_Click" />
                    </div>

                </div>

                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                    </div>
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

</asp:Content>
