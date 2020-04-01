<%@ Page Title="Agnda de Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgendaEventos.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.AgendaEventos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">
        <div class="page-container">
            <div class="container">
                <h2><%: Title %></h2>
                <hr />

                <link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">

                <div class="container">

                    <section style="width: 100%">
                        <asp:PlaceHolder ID="iframeObras" runat="server" />
                    </section>

                </div>

            </div>
        </div>
    </div>
</asp:Content>
