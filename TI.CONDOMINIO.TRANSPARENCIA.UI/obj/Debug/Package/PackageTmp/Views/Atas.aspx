<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Atas.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.Atas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">

        <div class="col-md-12">
            <asp:Label runat="server" AssociatedControlID="ddlAno" CssClass="col-md-4 control-label">Selecione Ano Desejado:</asp:Label>
            <asp:Label ID="lblDescricao" runat="server" AssociatedControlID="ddlAno">
            </asp:Label>
        </div>
        <div class="col-md-10">
            <asp:DropDownList ID="ddlAno" CssClass="form-control" Width="100%" runat="server" AutoPostBack="true" ControlToValidate="ddlAno" AppendDataBoundItems="true" ErrorMessage="Campo Obrigatório.">
                <asp:ListItem Value="2019">2019</asp:ListItem>
                <asp:ListItem Value="2020">2020</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="table-responsive">

        <asp:GridView ID="gdvAtas" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" ShowHeader="False">
            <Columns>
                <asp:TemplateField>
                    <ItemStyle Width="90%" />
                    <ItemTemplate>
                        <%--<asp:LinkButton ID="LinkButton2" runat="server" CommandName="Downloads" Text='<%# Eval("FileName").ToString() %>' ToolTip="Dowload de Documentos" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>' OnClientClick="window.document.forms[0].target='_blank';"></asp:LinkButton>--%>
                        <asp:LinkButton ID="btnView" runat="server" CommandName="View" Text='<%# Eval("FileName").ToString() %>' ToolTip="Dowload de Documentos" CommandArgument='<%# "~/Arquivos/Documentos/Atas/2019/"  + Eval("FileName").ToString() %>'></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemStyle Width="5%" />
                    <ItemTemplate>
                        <asp:LinkButton ID="bntDows" runat="server" CommandName="Downloads" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>' ImageUrl="~/Content/assets/img/Icon/view-icon.png" ToolTip="Visualização de Documentos">Baixar</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

        <asp:Label ID="lblQtde" runat="server"></asp:Label>
    </div>
</asp:Content>
