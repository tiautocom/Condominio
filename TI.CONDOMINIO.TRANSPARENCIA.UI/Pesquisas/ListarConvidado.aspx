<%@ Page Title="AGENDA MENSAL DE FESTAS" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListarConvidado.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Pesquisas.ListarConvidado" %>

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
                        <asp:GridView ID="gdvMorador" runat="server" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id,Nome,Obs">
                            <Columns>
                                <asp:BoundField DataField="Id" HeaderText="Id" />

                                <asp:TemplateField HeaderText="Nome">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox1" runat="server" Width="100%" Text='<%# Bind("Nome") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:TextBox ID="TextBox4" runat="server" Width="100%"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>

                                <asp:TemplateField HeaderText="Observação">
                                    <EditItemTemplate>
                                        <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Obs") %>'></asp:TextBox>
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:TextBox ID="TextBox3" runat="server" Width="100%"></asp:TextBox>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <FooterStyle BackColor="#CCCC99" />
                            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="Black" />
                            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                            <RowStyle BackColor="#F7F7DE" />
                            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#FBFBF2" />
                            <SortedAscendingHeaderStyle BackColor="#848384" />
                            <SortedDescendingCellStyle BackColor="#EAEAD3" />
                            <SortedDescendingHeaderStyle BackColor="#575357" />

                        </asp:GridView>
                    </div>
                </div>

                <div class="form-group">
                    <div class="col-md-10">
                        <asp:Button runat="server"
                            Text="Salvar" CssClass="btn btn-default" ToolTip="Salvar Dados Usuário" />
                    </div>

                </div>


<%--                <div class="col-lg-10 ">
                    <b>
                        <asp:Label ID="lblLogin" CssClass="text-success" runat="server" Text="OPERADOR(A): ..."></asp:Label>
                    </b>
                </div>--%>
            </div>

        </div>
    </div>

</asp:Content>
