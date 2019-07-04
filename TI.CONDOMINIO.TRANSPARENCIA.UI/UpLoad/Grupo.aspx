<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Grupo.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.UpLoad.Grupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Dados Grupo</h2>

    <div class="form-horizontal">
        <h4>
            <asp:Label ID="lblDescricaLai" runat="server" Text="..."></asp:Label>
        </h4>

        <div class="fluploadLink">
            <asp:HiddenField ID="hfId" runat="server" />
        </div>
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <br />
        <asp:Label ID="lblDescricao" runat="server"></asp:Label>

        <div class="form-group">
            <div class="col-md-10">
                <asp:FileUpload ID="flUpFile" runat="server" CssClass="form-control" />
                <br />
                <asp:Button ID="btnupLoad" runat="server" CssClass="btn btn-default" Text="Salvar" />
                <br />
            </div>
        </div>

        <div class="table-responsive">
            <asp:GridView ID="gdvGrupo" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" EmptyDataText="Não há registros de dados para exibir." ShowHeader="False">
                <%--          <Columns>
                    <asp:TemplateField>
                        <ItemStyle Width="90%" />
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" CommandName="View" Text='<%# Eval("FileName").ToString() %>' ToolTip="Dowload de Documentos" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>'></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <Columns>
                    <asp:TemplateField>
                        <ItemStyle Width="5%" />
                        <ItemTemplate>
                            <asp:LinkButton ID="ImageButton2" runat="server" CommandName="Downloads" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>' ImageUrl="~/Content/assets/img/Icon/view-icon.png" ToolTip="Visualização de Documentos">Baixar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <Columns>
                    <asp:TemplateField>
                        <ItemStyle Width="5%" />
                        <ItemTemplate>
                            <asp:LinkButton ID="ImageButton3" runat="server" CommandName="Deletar" CommandArgument='<%# "~/Arquivos/Transparencias/" + Eval("FileName").ToString() %>' ImageUrl="~/Content/assets/img/Icon/delete-file-icon.png" ToolTip="Deletar de Documentos">Deletar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>--%>
            </asp:GridView>
        </div>

        <div class="form-group">
            <div class="col-lg-10 ">
                <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server">Voltar Página</asp:LinkButton>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
            </div>
        </div>

    </div>

</asp:Content>
