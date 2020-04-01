<%@ Page Title="Galeria" Language="C#" Debug="true" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Galeria.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.Galeria" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Scripts/Eventos.css" rel="stylesheet" />

    <div class="container">

        <asp:Panel ID="Panel1" runat="server" class="container">
            <div class="row">
                <h3>Galeria de Obras e Melhorias</h3>
                <p>Selecione Album para Visualizar as Fotos</p>
            </div>

            <div class="row">
              
                <section>
                    <asp:PlaceHolder ID="iframeGaleria" runat="server" />
                </section>

            </div>

        </asp:Panel>

    </div>

</asp:Content>
