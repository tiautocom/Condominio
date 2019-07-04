<%@ Page Title="HOME" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" EnableEventValidation="false" CodeBehind="Default.aspx.cs" Inherits="TI.CONDOMINIO.AGENDAMENTOS._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h3>Agende sua Mudança - On-Line</h3>
        <h4>
            <p class="lead">Residencial Vitta Ipê Amarelo.</p>
            <p>Estamos totalmente a disposição para melhor atende-los</p>
            <p>Regras para Agendamento On-Line Ipê Amarelo</p>

            <ul typeof="circle">
                <li>Para Agendar sua mudança, é necessário ter em mãos Numero da Torre, Bloco e Apto.</li>
            </ul>

            <ul typeof="circle">
                <li>Clique no botão Solicitação de Mudança e faça seu Cadastro.</li>
            </ul>

            <ul typeof="circle">
                <li>Aguarde Retorno da Autorização do Sindico.</li>
            </ul>

            <hr />
            <p>
                <asp:Button ID="btnSolicitarMudanca" runat="server" class="btn btn-primary btn-lg" data-toggle="modal" data-target="#exampleModal" Text="Solictação de Mudança &raquo;" Visible="False" />
            </p>
        </h4>
        <hr />

    </div>

    <div>

        <div class="row">
            <div class="table-responsive">
                <div class="col-md-12">
                    <h2>Agenda de Mudanças</h2>

                    <asp:GridView ID="gdvAgenda" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" CssClass="table" DataKeyNames="IdMudanca, numTorre, Apto">

                        <Columns>

                            <asp:BoundField DataField="IdMudanca" HeaderText="Cod" Visible="false" />
                            <asp:BoundField DataField="NumTorre" HeaderText="Torres" />
                            <asp:BoundField DataField="Data" HeaderText="Data " DataFormatString="{0:d}" />
                            <asp:BoundField DataField="Bloco" HeaderText="Bloco" />
                            <asp:BoundField DataField="Apto" HeaderText="Apto" />
                            <asp:BoundField DataField="Periodo" HeaderText="Periodo" />
                            <asp:BoundField DataField="HorarioInicio" HeaderText="Hora Inicio" />
                            <asp:BoundField DataField="HoraFim" HeaderText="Hora Término" />
                            <asp:BoundField DataField="DescStatus" HeaderText="Status" />

                        </Columns>

                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>

                    <asp:GridView ID="gdvAgendaAdm" runat="server" AutoGenerateColumns="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" CssClass="table" OnRowCommand="gdvAgendaAdm_RowCommand" DataKeyNames="IdMudanca, NumTorre, Bloco, Apto,  DescStatus">

                        <Columns>

                            <asp:BoundField DataField="IdMudanca" HeaderText="ID" Visible="false" />

                            <asp:BoundField DataField="NumTorre" HeaderText="Torres" />
                            <asp:BoundField DataField="Data" HeaderText="Data " DataFormatString="{0:d}" />
                            <asp:BoundField DataField="Bloco" HeaderText="Bloco" />
                            <asp:BoundField DataField="Apto" HeaderText="Apto" />
                            <asp:BoundField DataField="Periodo" HeaderText="Periodo" />
                            <asp:BoundField DataField="HorarioInicio" HeaderText="Hora Inicio" />
                            <asp:BoundField DataField="HoraFim" HeaderText="Hora Término" />

                            <asp:TemplateField HeaderText="Status" FooterStyle-CssClass="table">
                                <ItemTemplate>
                                    <asp:Button ID="lblDescricao" Width="100%" runat="server" CssClass="btn btn-info" Text='<%# Eval("DescStatus") %>' CommandArgument='<%# Container.DataItemIndex%>' CommandName="SelApto"></asp:Button>
                                </ItemTemplate>
                                <FooterStyle CssClass="table" />
                                <ItemStyle Width="10%" HorizontalAlign="Center" Height="15px" />
                            </asp:TemplateField>


                        </Columns>

                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F1F1F1" />
                        <SortedAscendingHeaderStyle BackColor="#808080" />
                        <SortedDescendingCellStyle BackColor="#CAC9C9" />
                        <SortedDescendingHeaderStyle BackColor="#383838" />
                    </asp:GridView>

                </div>
            </div>
        </div>

        <p><a href="#" class="btn btn-primary btn-lg">Voltar Topo &raquo;</a></p>

    </div>

    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title" id="exampleModalLabel">Dados Obrigatórios para Agendamento</h5>
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>

                <div class="modal-body">

                    <div class="container">
                        <form action="/action_page.php">

                            <div class="row">
                                <div class="col-25">
                                    <label for="fname">Data:</label>
                                </div>
                                <div class="col-25">
                                    <div class='input-group date' id='datetimepicker1'>
                                        <asp:TextBox ID="dataGaleria" runat="server" CssClass="form-control" data-date-format="DD/MM/YYYY"></asp:TextBox>
                                        <span class="input-group-addon">
                                            <span class="glyphicon glyphicon-calendar"></span>
                                        </span>
                                    </div>
                                </div>
                            </div>


                            <div class="row">
                                <div class="col-25">
                                    <label for="hIni">Hora Inicio</label>
                                </div>
                                <div class="col-75">

                                    <asp:DropDownList ID="ddlPeriodo" runat="server" AppendDataBoundItems="true">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem Value="1">08:00 - 11:30</asp:ListItem>
                                        <asp:ListItem Value="2">13:30 - 16:00</asp:ListItem>
                                    </asp:DropDownList>

                                </div>
                            </div>

                            <div class="row">
                                <div class="col-25">
                                    <label for="torre">Torre</label>
                                </div>
                                <div class="col-75">

                                    <asp:DropDownList ID="ddlTorre" runat="server" AppendDataBoundItems="true">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem Value="1">01</asp:ListItem>
                                        <asp:ListItem Value="2">02</asp:ListItem>
                                        <asp:ListItem Value="3">03</asp:ListItem>
                                        <asp:ListItem Value="4">04</asp:ListItem>
                                    </asp:DropDownList>

                                </div>
                            </div>

                            <div class="row">
                                <div class="col-25">
                                    <label for="torre">Blocos</label>
                                </div>
                                <div class="col-75">
                                    <asp:DropDownList ID="ddlBloco" runat="server" Width="100%">
                                        <asp:ListItem></asp:ListItem>
                                        <asp:ListItem Value="A">A</asp:ListItem>
                                        <asp:ListItem Value="B" Text="B">B</asp:ListItem>
                                        <asp:ListItem Value="C" Text="C">C</asp:ListItem>
                                        <asp:ListItem Value="D" Text="D">D</asp:ListItem>
                                        <asp:ListItem Value="E" Text="E">E</asp:ListItem>
                                        <asp:ListItem Value="F" Text="F">F</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>

                            <div class="row">
                                <div class="col-25">
                                    <label for="apto">Apartamentos</label>
                                </div>
                                <div class="col-100">
                                    <asp:TextBox ID="txtApto" runat="server" Width="100%"></asp:TextBox>
                                </div>
                            </div>

                        </form>
                    </div>

                </div>

                <div class="modal-footer">
                    <button type="button" class="btn btn-secondary" data-dismiss="modal">Sair</button>
                    <asp:Button ID="btnSolicitar" runat="server" Text="Solictar" class="btn btn-primary" OnClick="btnSolicitar_Click" />
                </div>
            </div>

            <style>
                * {
                    box-sizing: border-box;
                }

                input[type=text], select, textarea {
                    width: 100%;
                    padding: 12px;
                    border: 1px solid #ccc;
                    border-radius: 4px;
                    resize: vertical;
                }

                label {
                    padding: 12px 12px 12px 0;
                    display: inline-block;
                }

                input[type=submit] {
                    background-color: #4CAF50;
                    color: white;
                    padding: 12px 20px;
                    border: none;
                    border-radius: 4px;
                    cursor: pointer;
                    float: right;
                }

                    input[type=submit]:hover {
                        background-color: #45a049;
                    }

                .col-25 {
                    float: left;
                    width: 25%;
                    margin-top: 6px;
                }

                .col-75 {
                    float: left;
                    width: 75%;
                    margin-top: 6px;
                }

                /* Clear floats after the columns */
                .row:after {
                    content: "";
                    display: table;
                    clear: both;
                }

                /* Responsive layout - when the screen is less than 600px wide, make the two columns stack on top of each other instead of next to each other */
                @media screen and (max-width: 600px) {
                    .col-25, .col-75, input[type=submit] {
                        width: 100%;
                        margin-top: 0;
                    }
                }
            </style>

        </div>
    </div>

    <%-- MODAL DELETAR--%>
    <div id="modalAlterarStatus" class="modal" tabindex="-1" role="dialog">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">

                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <h3 class="modal-title">Alteração de Status</h3>

                    <h5>
                        <asp:Literal ID="descTorre" runat="server" />
                        <br />

                        <asp:Literal ID="descBlocos" runat="server" />
                        <br />

                        <asp:Literal ID="descApto" runat="server" />
                        <hr />

                        <asp:DropDownList ID="ddlStatus" runat="server" Width="100%"></asp:DropDownList>
                    </h5>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnSalvar" runat="server" class="btn btn-outline-primary" Text="Salvar" OnClick="btnSalvar_Click" />
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
