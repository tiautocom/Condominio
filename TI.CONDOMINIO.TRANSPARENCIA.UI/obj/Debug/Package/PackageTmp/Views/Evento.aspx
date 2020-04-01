<%@ Page Title="Agenda e Eventos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Evento.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.Evento" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <link href="../Scripts/Eventos.css" rel="stylesheet" />

    <div class="container">
        <asp:Panel ID="Panel1" runat="server">
            <div class="row">
                <h3>Agenda de Eventos</h3>
                <p>Todos Eventos</p>
            </div>


            <div class="row">
                <div class="col-md-7 col-lg-7">
                    <ul class="media-list main-list">

                        <li class="media">
                            <a class="pull-left" href="Album.aspx?Tipo=1">
                                <img class="media-object" src="../Arquivos/Imagem/Default/evento.png" style='height: 150px; width: 150px;' alt="...">
                            </a>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                <h4 class="media-heading">Galeria de Eventos</h4>
                                <p class="by-author">31/06/2019</p>
                            </div>
                        </li>

                        <li class="media">
                            <a class="pull-left" href="Album.aspx?Tipo2">
                                <img class="media-object" src="../Arquivos/Imagem/Default/construcao.png" style='height: 150px; width: 150px;' alt="...">
                            </a>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                <h4 class="media-heading">Galeria de Obras</h4>
                                <p class="by-author">20/10/2019</p>
                            </div>
                        </li>

                               <li class="media">
                            <a class="pull-left" href="Mudanca.aspx">
                                <img class="media-object" src="../Arquivos/Imagem/Default/mudanca.png" style='height: 150px; width: 150px;' alt="...">
                            </a>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                <h4 class="media-heading">Mudanças</h4>
                                <p class="by-author">20/10/2019</p>
                            </div>
                        </li>

                    </ul>
                </div>
            </div>

        </asp:Panel>

    </div>

    <div class="container">

        <div class="row">

            <div class="col-lg-9">
                <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">
                </div>
                <div class="container">
                    <div class="row">
                        <asp:PlaceHolder ID="iframe" runat="server" />
                    </div>
                </div>
                <br>
            </div>
        </div>

    </div>


</asp:Content>
