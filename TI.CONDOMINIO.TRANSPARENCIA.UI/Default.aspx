<%@ Page Title="Empreendimento Vitta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    <div class="shadowBox">
        <div class="page-container">

            <div class="row">
                <div class="col-md-12">

                    <div class="col-md-6">
                        <asp:Image ID="Image1" runat="server" Width="100%" src="http://zcondominio.com.br/Arquivos/Imagem/Default/default0.jpg" alt="Responsive image" Style="border-radius: 5px" /><br />
                    </div>

                    <div class="col-md-6">
                        <h4 style="font-weight:bold">Atendimento</h4>
                        <p>
                            Vitta Residencial Ipê Amarelo
                <br />
                            Localizado na Av. Prof. Gustavo Fleury Chamillot, 372 - Jardim Res. Paraiso, 
                <br />
                            Araraquara-SP CEP: 14804-012
                <br />
                            Bairro: Vila dos Ipês
                <br />
                            Fone: (16) 3357-2972
                <br />
                            Mudanças e Entregas: 08:00 as 16:00 Hs.<br />

                            <strong>E-Mail:</strong>
                            <a href="mailto:contato@ipeamarelo.com.br">contato@ipeamarelo.com.br</a><br />
                        </p>

                    </div>
                </div>

            </div>

            <hr />

            <div class="row">

                <div class="col-md-4">
                    <h3 style="font-weight:bold">ATA DE REUNIÕES</h3>
                    <p>
                        A Ata é um documento que tem como função validar as ações e tomadas de decisões de um síndico referente ao condomínio que administra. Ela serve como prova do que foi aprovado ou não durante uma assembleia e deve conter todas as informações importantes referentes à reunião de condomínio. Assim como todas as deliberações, não aprovações e todas as tarefas atribuídas a cada pessoa presente na reunião.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Views/AtaReuniao.aspx">Saber mais &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">RECEITAS E DESPESAS</h3>
                    <p style="border: 0px; margin: 0px 0px 1.5em; padding: 0px; color: rgb(58, 58, 58); font-family: Roboto, sans-serif; font-size: 17px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 300; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(251, 251, 251); text-decoration-style: initial; text-decoration-color: initial;">
                        <span style="border: 0px; margin: 0px; padding: 0px; font-weight: 400;">É através do demonstrativo de receitas e despesas que é possível apurar todas as operações financeiras realizadas pelo condomínio em um determinado período. É importante que as informações sejam destacadas de forma resumida e objetiva para evitar confusões.</span>
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Views/ReceitasDespesas.aspx?id=1">Entrar &raquo;</a>
                    </p>
                </div>

                <%--         <div class="col-md-4">
                    <h2>DEMONSTRATIVOS</h2>
                    <p>
                        You can easily find a web hosting company that offers the right mix of features and price for your applications.
                    </p>
                    <p>
                        <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301950">Saber mais &raquo;</a>
                    </p>
                </div>--%>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">AVISOS E COMUNICADOS</h3>
                    <p>
                        Notifique o responsável de uma unidade sem causar atritos pessoais. A infração fica aberta para considerações de ambos.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#">Saber mais &raquo;</a>
                    </p>
                </div>

            </div>

            <hr />

            <div class="row">

                <div class="col-md-4">
                    <h3 style="font-weight:bold">OBRAS E MELHORIAS</h3>
                    <p>
                        Toda obra deve ser aprovada em assembleia, a não ser que seja ... Se for para trocar visando modernizar o local com equipamentos mais avançados, a melhoria .... segurança e tentando sanear custos condomíniais, se enquadraria em util, .
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Views/Galeria.aspx">Fotos &raquo;</a>
                    </p>
                </div>


                <div class="col-md-4">
                    <h3 style="font-weight:bold">CONTATOS</h3>
                    <p>
                        Entre em contato conosco ("discutir texto").
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Views/Contato.aspx">Entrar &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">AGENDA & EVENTOS</h3>
                    <p>
                        Discutir texto.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Views/Evento.aspx">Saber mais &raquo;</a>
                    </p>
                </div>

            </div>

            <hr />

            <div class="row">
                <div class="col-md-4">
                    <h3 style="font-weight:bold">CAIXA DE E-MAIL</h3>
                    <p>
                        Envie mensagens para pedidos, reclamações e agradecimentos.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#" data-toggle="modal" data-target="#exampleModal">Entrar &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">COMISSÃO DE SINDICOS</h3>
                    <p>
                        Responsáveis atuais                       
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#" data-toggle="modal" data-target="#exampleModal2">Entrar &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">PORTARIA</h3>
                    <p>
                        Para Condôminos e para Guarita. Liberações de acesso de convidados, funcionários e prestadores de serviço.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#">Saber mais &raquo;</a>
                    </p>
                </div>

            </div>

            <hr />

            <div class="row">

                <div class="col-md-4">
                    <h3 style="font-weight:bold">PLANTAS/METRAGENS</h3>
                    <p>
                        You can easily find a web hosting company that offers the right mix of features and price for your applications.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#">Saber mais &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">RESERVA DE ESPAÇOS</h3>
                    <p>
                        Acesse, verifique e efetue sua reserva sem sair de casa. Exporte as datas e reservas efetuadas e consulte o histórico quando precisar.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Views/AgendaEventos.aspx">Saber mais &raquo;</a>
                    </p>
                </div>



                <div class="col-md-4">
                    <h3 style="font-weight:bold">LIVRO DE OCORRÊNCIAS</h3>
                    <p>
                        Notifique o responsável de uma unidade sem causar atritos pessoais. A infração fica aberta para considerações de ambos.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#">Saber mais &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">CHAT-MORADOR</h3>
                    <p>
                        Notifique o responsável de uma unidade sem causar atritos pessoais. A infração fica aberta para considerações de ambos.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="#">Saber mais &raquo;</a>
                    </p>
                </div>

                <div class="col-md-4">
                    <h3 style="font-weight:bold">LISTA DE CONVIDADOS</h3>
                    <p>
                        Lista de Convidados de realizado pelo morador Responsável.
                    </p>
                    <p>
                        <a style="background-color:#e0e0e0" class="btn btn-default" href="Pesquisas/ListarConvidado.aspx">Saber mais &raquo;</a>
                    </p>
                    <%--<a>+</a>--%>
                </div>

            </div>

        </div>
        <hr />

        <div class="row">
            <div class="col-md-10">

                <h3 style="font-weight:bold">Painel de Dados</h3>
                <h5>Econômia de Consumo de Água M3</h5>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style=" background-color:MediumSeaGreen; width: 55%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">55%</div>
                </div>


                <h5>Econômia de Consumo de Energia M3</h5>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="background-color:#b22727; width: 33%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">33%</div>
                </div>

                <h5>Econômia de Consumo de Gáz M3</h5>
                <div class="progress">
                    <div class="progress-bar" role="progressbar" style="width: 47.89%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">47,90%</div>
                </div>
            </div>

        </div>

        <div class="row">
            <div class="col-md-12">

                <h3 style="font-weight:bold">Planilha de Controle de Visitas</h3>

                <div class="col-md-3">
                    <label>Total de Visitas Ano</label>
                    <button type="button" class="btn btn-primary btn-lg btn-block" style="background-color: Orange;">120</button>
                </div>

                <div class="col-md-3">
                    <label>Total de Visitas Realizadas</label>
                    <button type="button" class="btn btn-primary btn-lg btn-block" style="background-color: SlateBlue;">3578</button>

                </div>

                <div class="col-md-3">
                    <label>Total de Visitas Agendada</label>
                    <button type="button" class="btn btn-primary btn-lg btn-block" style="background-color: MediumSeaGreen;">44</button>

                </div>

                <div class="col-md-3">
                    <label>Total de Visitas Não Realizadas</label>
                    <button type="button" class="btn btn-primary btn-lg btn-block" style="background-color: tomato;">90</button>

                </div>

            </div>

        </div>

    </div>
    <%--  -------------------------------------------------------------------------------------------------------------------------------------------- --%>

    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel" style="font-weight:bold;">Caixa de Mensagem</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">

                    <div class="form-group">
                        <label for="recipient-name" class="col-form-label">Nome:</label>
                        <asp:TextBox ID="txtNome" CssClass="form-control" runat="server" TextMode="Search" Width="100%"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="recipient-name" class="col-form-label">E-mail:</label>
                        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" TextMode="Search" Width="100%"></asp:TextBox>
                    </div>

                    <div class="form-group">
                        <label for="message-text" class="col-form-label">Assunto:</label>
                        <asp:TextBox ID="txtAssunto" CssClass="form-control" runat="server" TextMode="MultiLine" Rows="4" Width="100%"></asp:TextBox>
                    </div>

                    <p>
                        Enviar Numero do Bloco e Apto na Descrição do Campo Assunto do Email.
                    </p>

                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal" Style="background-color:#428bca; border-color:#428bca; color:white;">Sair</button>
                    <button type="button" class="btn btn-primary" style="background-color:mediumseagreen; border-color:mediumseagreen;">Enviar Mensagem</button>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel2">Comissão de Sindicos</h5>
                    <%--     <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>--%>
                </div>
                <div class="modal-body">

                    <link href="../Scripts/Eventos.css" rel="stylesheet" />

                    <div class="container">

                        <div class="row">

                            <div class="col-md-10 col-lg-10">

                                <ul class="media-list main-list">
                                    <li class="media">
                                        <a class="pull-left" href="#">
                                            <img class="media-object" src="http://placehold.it/150x90" alt="...">
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                            <h4 class="media-heading">Isabela Cosmos</h4>
                                            <p class="by-author">Sindica</p>
                                        </div>
                                    </li>
                                </ul>

                                <ul class="media-list main-list">
                                    <li class="media">
                                        <a class="pull-left" href="#">
                                            <img class="media-object" src="http://placehold.it/150x90" alt="...">
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                            <h4 class="media-heading">Paulo Henrique Gonzaga</h4>
                                            <p class="by-author">Sub-Sindico - 01</p>
                                        </div>
                                    </li>
                                </ul>

                                <ul class="media-list main-list">
                                    <li class="media">
                                        <a class="pull-left" href="#">
                                            <img class="media-object" src="http://placehold.it/150x90" alt="...">
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                            <h4 class="media-heading">Luiz Fernando</h4>
                                            <p class="by-author">Sub-Sindico - Torre 02</p>
                                        </div>
                                    </li>
                                </ul>

                                <ul class="media-list main-list">
                                    <li class="media">
                                        <a class="pull-left" href="#">
                                            <img class="media-object" src="http://placehold.it/150x90" alt="...">
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                            <h4 class="media-heading">Claudemir dos Santos</h4>
                                            <p class="by-author">Sub-Sindico - Torre 03</p>
                                        </div>
                                    </li>
                                </ul>

                                <ul class="media-list main-list">
                                    <li class="media">
                                        <a class="pull-left" href="#">
                                            <img class="media-object" src="http://placehold.it/150x90" alt="...">
                                        </a>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div class="media-body">
                                            <h4 class="media-heading">Richard de Oliveira</h4>
                                            <p class="by-author">Sub-Sindico - Torre 04</p>
                                        </div>
                                    </li>
                                </ul>

                            </div>

                        </div>

                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Sair</button>
                </div>
            </div>
        </div>
    </div>

    <%--<link href="vendor/bootstrap/css/booststrap1.css" rel="stylesheet" />--%>
</asp:Content>
