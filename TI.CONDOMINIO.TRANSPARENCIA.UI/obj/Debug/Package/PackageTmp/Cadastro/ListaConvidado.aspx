<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaConvidado.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Cadastro.ListaConvidado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="page-container">
        <div class="container">
            <hr />
            <h3>Lista de Convidados</h3>
            <hr />

            <%--GRID  MORADOR--%>
            <div class="row">


                <div class="col-lg-12">
                    <div class="table-responsive">
                        <asp:GridView ID="gdvMorador" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id,Titular,Rg,Cpf,Torre,Bloco,Apto,Telefone,Celular">
                            <Columns>
                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Image ID="Image1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField>
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:Label ID="Label1" runat="server"></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>

                <div class="col-lg-10 ">
                    <b>
                        <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                    </b>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
