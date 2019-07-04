﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TI.CONDOMINIO.WEBSITE.UI.Index" %>

<!DOCTYPE html>

<html lang="en">

<head>
    <meta charset="utf-8">
    <link rel="icon" href="~\Content\assents\img\logo.jpg">

    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Vitta Residencial Ipê Amarelo</title>

    <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/modern-business.css" rel="stylesheet" />
    <link href="css/modern-business.css" rel="stylesheet" />

    <link href="css/Detalhes.css" rel="stylesheet" />
</head>

<body>
    <script>
        function myFunction() {
            document.getElementById("mp4_src").src = "http://moradaturismo.gproj.com.br/Image/drone.mp4";
            document.getElementById("ogg_src").src = "movie.ogg";
            document.getElementById("myVideo").load();
        }
    </script>

    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">

        <div class="container">
            <a class="navbar-brand" href="../Index.aspx">Vitta - Ipê Amarelo</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
        </div>
    </nav>

    <header>
        <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
            <ol class="carousel-indicators">
                <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
                <%--                <li data-target="#carouselExampleIndicators" data-slide-to="3"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="4"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="5"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="6"></li>
                <li data-target="#carouselExampleIndicators" data-slide-to="7"></li>--%>
                <%--     <li data-target="#carouselExampleIndicators" data-slide-to="7"></li>--%>
            </ol>

            <div class="carousel-inner" role="listbox">

                <!-- Slide One - Set the background image for this slide in the line below -->
                <%-- 1--%>
                <div class="carousel-item active" style="background-image: url('http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/default0.jpg')">
                    <div class="carousel-caption d-none d-md-block">
                        <h3>PORTARIA</h3>
                        <p>Entrada Principal com Monitoramento de Segurança e porteiro 24Hs.</p>
                    </div>
                </div>

                <%--2--%>
                <!-- Slide Two - Set the background image for this slide in the line below -->
                <div class="carousel-item" style="background-image: url('http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/default3.jpg')">
                    <div class="carousel-caption d-none d-md-block">
                        <h3>Área de Lazer.</h3>
                        <p>Piscina Adulta e Infantil</p>
                    </div>
                </div>

                <%--3--%>
                <!-- Slide Three - Set the background image for this slide in the line below -->
                <div class="carousel-item" style="background-image: url('http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/default4.jpg')">
                    <div class="carousel-caption d-none d-md-block">
                        <h3>CHURRASQUEIRA</h3>
                        <p>Grande Área Coberta para Realização de Encontros e Festas.</p>
                    </div>
                </div>

            </div>

            <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Previous</span>
            </a>
            <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Next</span>
            </a>
        </div>
    </header>

    <hr />

    <!-- Page Content -->
    <div class="container">


        <h2>Empreendimentos Vitta Ipê Amarelo</h2>

        <div class="row">
            <hr />
            <%-- VIDEOS--%>
            <%--            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">

                <div class="card h-100">
                    <a href="Galeria/Videos.aspx">
                        <img class="card-img-top" src="http://transparencia.moradaturismoeventos.com.br/Arquivos/Imagem/Default/Videos.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="Galeria/Videos.aspx">Videos</a>
                        </h4>
                        <p class="card-text">Postagem de Videos de Show, eventos, Cobertura de Congreços Realizados Morado com acesso Youtube.</p>
                    </div>
                </div>
            </div>--%>

            <hr />
            <%-- OBRAS--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a href="Galeria/Portifolio.aspx?IdTipo=1&Galeria=Obras">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/service.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="Galeria/Portifolio.aspx?IdTipo=1&Galeria=Obras">Fotos de Obras</a>
                        </h4>
                        <p class="card-text">Portifolio de Galeria de Obras. Obras realizadas, consertos e melhorias no conjunto do Ipê.</p>
                    </div>
                </div>
            </div>

            <%--EVENTOS--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a href="Galeria/Portifolio.aspx?IdTipo=2&Galeria=Eventos">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/eventos.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="Galeria/Portifolio.aspx?IdTipo=2&Galeria=Eventos">Fotos de Eventos</a>
                        </h4>
                        <p class="card-text">Portifolio de Galeria de Fotos de Eventos. Eventos Sediados nas Assembléias e Reuniões.</p>
                    </div>
                </div>
            </div>

            <%--AGENDA--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a href="Galeria/Agenda.aspx">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/agenda3.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="Galeria/Agenda.aspx">Agenda de Programação.</a>
                        </h4>
                        <p class="card-text">Divulgação da Agenda de Serviços, Manutenções, Agenda e Reuniões.</p>
                    </div>
                </div>
            </div>

            <%--CONTATO--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a href="#" data-toggle="modal" data-target="#myModal2">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/caderno.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="#" data-toggle="modal" data-target="#myModal2">Contatos</a>
                        </h4>
                        <p class="card-text">Entre em contato conosco, tire suas dúvidas, dê suas sugestões, que retornaremos o mais rápido possível. Se preferir, entre em contato conosco pelo telefone ou preencha o formulário no Icone Fale Conosco.</p>
                    </div>
                </div>
            </div>

            <%--COMISSAO--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a href="Galeria/Diretoria.aspx">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/agenda2.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="Galeria/Diretoria.aspx">Comissão de Sindicos</a>
                        </h4>
                        <p class="card-text">Conheça os integrantes da nosso Quadro de Sindico.</p>
                    </div>
                </div>
            </div>

            <%-- FALE CONOSCO--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a href="#" data-toggle="modal" data-target="#myModal">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/email.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="#" data-toggle="modal" data-target="#myModal">Fale Conosco</a>
                        </h4>

                        <p class="card-text">Envie sua mensagem no formulário abaixo e entraremos em contato o mais breve possível. Para enviar uma mensagem, você não precisa estar cadastrado.</p>
                    </div>
                </div>
            </div>

            <%--TRANSPAENCIA--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/transpar.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="http://transparencia.moradaturismoeventos.com.br/" target="_blank">Transparência</a>
                        </h4>
                        <p class="card-text">Informações sobre nossas licitações, contratos, Constituição e Órgãos Diretivos, Execução Orçamentária e Controle Financeiro, Controle de Pessoal e Controle de Atividade.</p>
                    </div>
                </div>
            </div>

            <%--MONITORAMENTO COM CAMERA--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/monitoramento.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="http://transparencia.moradaturismoeventos.com.br/" target="_blank">Monitoramento onLine</a>
                        </h4>
                        <p class="card-text">Informações sobre nossas licitações, contratos, Constituição e Órgãos Diretivos, Execução Orçamentária e Controle Financeiro, Controle de Pessoal e Controle de Atividade.</p>
                    </div>
                </div>
            </div>

                    <%--MONITORAMENTO COM CAMERA--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/telefone.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="http://transparencia.moradaturismoeventos.com.br/" target="_blank">Telefone Uteis</a>
                        </h4>
                        <p class="card-text">Todos Prestadores de Serviço Cadastrado.</p>
                    </div>
                </div>
            </div>

                    <%--MONITORAMENTO COM CAMERA--%>
            <div class="col-lg-3 col-md-4 col-sm-6 portfolio-item">
                <div class="card h-100">
                    <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/">
                        <img class="card-img-top" src="http://imob.gproj.com.br/Arquivos/IpeAmarelo/Index/adm.png" alt=""></a>
                    <div class="card-body">
                        <h4 class="card-title">
                            <a href="http://transparencia.moradaturismoeventos.com.br/" target="_blank">Empresa Administradora</a>
                        </h4>
                        <p class="card-text">Site da Adminitradora.</p>
                    </div>
                </div>
            </div>

        </div>

        <%--FOR--%>
        <div class="row">
            <div id="root" class="row">
                <asp:PlaceHolder ID="iframeDiv" runat="server" />
            </div>
        </div>

        <div class="row">
            <div id="root" class="row">
                <asp:PlaceHolder ID="iframeDiv2" runat="server" />
            </div>
        </div>

        <hr />
        <h3>Painel de Dados</h3>
        <h5>Econômia de Consumo de Água M3</h5>
        <div class="progress">
            <div class="progress-bar" role="progressbar" style="width: 55%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">55%</div>
        </div>


        <h5>Econômia de Consumo de Energia M3</h5>
        <div class="progress">
            <div class="progress-bar" role="progressbar" style="width: 33%;" aria-valuenow="25" aria-valuemin="0" aria-valuemax="100">33%</div>
        </div>

    </div>

    <hr />

    <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2242.816448238932!2d-48.19417334687495!3d-21.764040134316534!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x94b8f10edd0192f7%3A0xdb16be5c34bb131a!2sAv.+Prof.+Gustavo+Fleury+Chamillot%2C+95+-+Jardim+Res.+Paraiso%2C+Araraquara+-+SP!5e1!3m2!1spt-BR!2sbr!4v1556571573957!5m2!1spt-BR!2sbr" style="border: 0; width: 100%; height: 450px;" frameborder="0" allowfullscreen></iframe>
    <%--    <iframe src="https://www.google.com/maps/embed?pb=!1m17!1m11!1m3!1d3123.6745366686955!2d-48.16336047415522!3d-21.77280655744522!2m2!1f180!2f0!3m2!1i1024!2i768!4f35!3m3!1m2!1s0x94b8f14ff3712fe9%3A0x1e493114c5d57f08!2sCeat!5e1!3m2!1spt-BR!2sbr!4v1517505079973" style="border: 0; width: 100%; height: 450px;" frameborder="0" allowfullscreen></iframe>
    <iframe src="https://www.google.com/maps/embed?pb=!4v1517493000766!6m8!1m7!1sPfY3x5W2utAPZRIXzdxS-A!2m2!1d-21.77277536764968!2d-48.17028167214782!3f130.99658976557862!4f-1.2081096141474745!5f0.7820865974627469" style="border: 0; width: 100%; height: 450px;" frameborder="0" allowfullscreen></iframe>--%>

    <footer class="py-5 bg-dark">
        <div class="container">
            <p class="m-0 text-center text-white">Copyright © TI Solutions Commerce 2019</p>
            <%--          <div align="center">
                <div id="sfckcxqheuu9k4g2a7875g51ax3jzkm7p27"></div>
                <script type="text/javascript" src="https://counter4.whocame.ovh/private/counter.js?c=kcxqheuu9k4g2a7875g51ax3jzkm7p27&down=async" async>
                </script>
                <br>
                <a href="https://www.webcontadores.com">contador de visitas no Site</a>
                <noscript>
                    <a href="https://www.webcontadores.com" title="contador de visitas no blog">
                        <img src="https://counter4.whocame.ovh/private/webcontadores.php?c=kcxqheuu9k4g2a7875g51ax3jzkm7p27" border="0" title="contador de visitas no blog" alt="contador de visitas no blog">
                    </a>
                </noscript>
            </div>--%>
        </div>
    </footer>

    <!-- Bootstrap core JavaScript -->
    <script src="vendor/jquery/jquery.min.js"></script>
    <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

    <%-- MODAL FALE CONOSCO--%>
    <div class="container">

        <div id="myModal" class="modal fade" role="dialog">
            <div class="modal-dialog">
                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title"></h4>
                    </div>
                    <div class="modal-body">
                        <form role="form" method="post" id="reused_form" runat="server">

                            <p>Envie sua mensagem no formulário abaixo e entraremos em contato o mais breve possível.</p>

                            <div class="form-group">
                                <label for="name">Name:</label>
                                <input type="text" class="form-control" id="name" name="name" required maxlength="50">
                            </div>

                            <div class="form-group">
                                <label for="email">Email:</label>
                                <input type="email" class="form-control" id="email" name="email" required maxlength="50">
                            </div>

                            <div class="form-group">
                                <label for="assunto">Assunto:</label>
                                <input type="search" class="form-control" id="assunto" name="assunto" required maxlength="50">
                            </div>

                            <div class="form-group">
                                <label for="name">Mensagem:</label>
                                <textarea class="form-control" type="textarea" name="message" id="message" placeholder="Sua mensagem aqui" maxlength="2000" rows="4"></textarea>
                            </div>

                            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" class="btn btn-lg btn-success btn-block" OnClick="btnEnviar_Click1" />

                        </form>
                        <div id="success_message" style="width: 100%; height: 100%; display: none;">
                            <h3>Sent your message successfully!</h3>
                        </div>
                        <div id="error_message" style="width: 100%; height: 100%; display: none;">
                            <h3>Error</h3>
                            Sorry there was an error sending your form.
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <%--MODAL CONTATO--%>
    <div class="container">
        <!-- Modal -->
        <div class="modal fade" id="myModal2" role="dialog">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">
                    <div class="modal-header">
                        <%--       <button type="button" class="close" data-dismiss="modal">&times;</button>--%>
                        <h4 class="modal-title">Contato Morada do Sol</h4>
                    </div>
                    <div class="modal-body">

                        <div>
                            <address>
                                &nbsp;Localização:<br />
                                &nbsp;Rua Ivo Antonio Magnani, 200<br />
                                &nbsp;Araraquara-SP - CEP-14802-634
                                     <br />
                                &nbsp;Bairro: Fonte Luminosa 
                                    <br />
                                <abbr title="Telefones">&nbsp;Fone:</abbr>
                                (16)3335-8526.
                            </address>

                            <address>
                                <strong>&nbsp;Site:</strong>
                                <a href="http://transparencia.moradaturismoeventos.com.br" target="_blank">transparencia.moradaturismoeventos.com.br</a><br />
                                <strong>&nbsp;E-Mail:</strong> <a href="mailto:moradadosoleventos@hotmail.com">contato@moradaturismoeventos.com.br</a>
                            </address>
                        </div>

                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-info" data-dismiss="modal">Fechar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <%-- MODAL QUEM SOMOS--%>
    <div class="container">

        <!-- The Modal -->
        <div class="modal fade" id="myModalQuemSomos">
            <div class="modal-dialog modal-lg">
                <div class="modal-content">

                    <!-- Modal Header -->
                    <%--           <div class="modal-header">
                        <h4 class="modal-title">Quem Somos:</h4>
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                    </div>--%>

                    <!-- Modal body -->
                    <div class="modal-body">
                        <b contenteditable>

                            <h2>A Empresa Morada do Sol Turismo, Eventos e Participações S/A</h2>
                        </b>
                        <h4>
                            <p>
                                A Empresa Morada do Sol Turismo, Eventos e Participações S/A é uma empresa Sociedade Anonima de Economia Mista, empresa publica de direito privado. Somos regidos pela Lei das Sociedades Anônimas (Lei nº 6.404/1976)</a> , Lei Municipal 1319 de 20 de Fevereiro de 1964, Lei 13.303/2016 e pelo nosso Estatuto Social, onde estão descritas nossa finalidade, resposabilidades e nossas atribuições.<br />
                                A Prefeitura do município de Araraquara é detentora de 50,72% das ações sendo que as demais 49,28% das ações estão distribuídas entre diversos outros acionistas privados.
                            </p>
                            <p>
                                Leis das Sociedades Anônimas:<a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Lei/13303.pdf"> LEI: 13.303/2016</a>, <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/Lei/1319.pdf">LEI: 1319/64</a><%-- e <a target="_blank" href="http://transparencia.moradaturismoeventos.com.br/Arquivos/PDFs/1319.pdf">LEI: 8814/16--%>.
                            </p>
                        </h4>
                        <div class="navbar fixed-top navbar-expand-lg navbar-dark bg-dark fixe"></div>
                        <hr />
                    </div>

                    <!-- Modal footer -->
                    <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Fechar</button>
                    </div>

                </div>
            </div>
        </div>

    </div>

</body>
</html>
