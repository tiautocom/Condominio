<%@ Page Title="Atas de Reuniões" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AtaReuniao.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Views.AtaReuniao" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="shadowBox">

        <div class="page-container">

            <h3>Ata de Reuniões</h3>
            <p>
                Fonte de Pesquisa: <a target="_blank" href="https://www.sindiconet.com.br/informese/como-deve-ser-a-ata-de-assembleia-condominial-administracao-assembleias-de-condominio">https://www.sindiconet.com.br</a>
            </p>
            <hr />

            <div id="divs">

                <div class="row">
                    <div class="col-md-12">
                        <ul typeof="circle">
                            <li>Ata: Os itens discutidos devem ser especificados, bem como o que foi deliberado sobre cada um.</li>
                        </ul>

                        <ul typeof="circle">
                            <li>A ata deve estar de acordo com o que foi deliberado, sem nenhum acréscimo ou negligência. É assinada pelo Presidente da Mesa e pelo secretário.</li>
                        </ul>

                        <ul typeof="circle">
                            <li>Não é preciso alongar-se muito sobre cada assunto, nem registrar todos os comentários realizados. São suficientes o resgistro dos assuntos, do que foi resolvido e dos eventuais protestos de quem o fizer questão.</li>
                        </ul>

                        <ul typeof="circle">
                            <li>É enviada uma cópia para cada condômino.</li>
                        </ul>

                        <ul typeof="circle">
                            <li>A antiga Lei dos Condomínios (4591/64) determinava que a distribuição da cópia da Ata aos condôminos fosse feita em um prazo de até 08 dias. Entretanto, Com o advento do Novo Código Civil (atual Lei dos Condomínios), esta obrigatoriedade NÃO foi mantida. Sendo assim, prevalece o que estiver determinado na convenção do condomínio. A convenção sendo omissa, recomenda-se respeitar o prazo de oito dias previsto pela Lei 4591/64. O não atendimento da entrega da ata aos condôminos em prazo razoável, implica no comprometimento do princípio da transparência, o qual quando atingido, pode levar a insatisfação e desconfiança dos condôminos.</li>
                        </ul>

                        <ul typeof="circle">
                            <li>Não é obrigatório seu registro em cartório, a não ser que assim determine a Convenção do seu condomínio. Se as decisões que ela contém foram aprovadas com os quoruns e procedimentos corretos, ela já tem valor legal para os condôminos. (Fonte: Informe Secovi nº 64).</li>
                        </ul>

                        <ul typeof="circle">
                            <li>Deve ser mantida no Livro de Atas do condomínio, pelo menos por 5 anos, em poder da administradora ou do síndico. Como qualquer documentação do condomínio, deve estar sempre disponível a qualquer condômino.</li>
                        </ul>

                    </div>

                </div>

            </div>

            <hr />

            <div class="row">
                <div class="col-md-6">

                    <%--       <div class='col-sm-6'>
                        <label>Selecione Data de Pesquisa Desejada</label>
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker1'>
                                <input type='text' class="form-control" data-date-format="DD/MM/YYYY" style='width: 100%;' />
                                <span class="input-group-addon">
                                    <span class="glyphicon glyphicon-calendar"></span>
                                </span>
                            </div>
                        </div>
                    </div>--%>

                    <div class='col-sm-12'>
                        <label>Selecione Atas Desejada</label>
                        <div class="form-group">
                            <div class='input-group date' id='datetimepicker1'>
                                <div class="table-responsive">

                                    <asp:GridView ID="gdvTranparencia" runat="server" Width="100%" CssClass="table table-striped table-bordered table-hover" AutoGenerateColumns="False" DataKeyNames="Id" PageSize="100" ShowHeader="False">

                                        <Columns>
                                            <asp:BoundField DataField="Id" HeaderText="Id" Visible="False" />
                                            <asp:TemplateField>
                                                <ItemStyle Width="3%" />
                                                <ItemTemplate>
                                                    <%--                                                    <asp:CheckBox  ID="imgbtn" runat="server" ToolTip="UpLoad da Transparência" CommandName="UpLoad" CommandArgument='<%# Eval("Id") %>' /><br />--%>
                                                    <asp:CheckBox ID="imgbtn" runat="server" ToolTip="UpLoad da Transparência" /><br />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>

                                        <%--         <Columns>
                                            <asp:TemplateField>
                                                <ItemStyle Width="85%" />
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="Nome" DataKeyNames="Descricao" DataField="Nome" runat="server" CommandName="Views" ToolTip="Lista de Transparências" Text='<%# Eval("Descricao") %>' CommandArgument='<%# Eval("Id") %>'></asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>--%>

                                        <%--            <Columns>
                                            <asp:TemplateField>
                                                <ItemStyle Width="5%" />
                                                <ItemTemplate>
                                                    <asp:LinkButton ID="PDF" DataKeyNames="pdf" DataField="PDF" runat="server" ToolTip="Upload de PDF Receitas e Despesas" CommandName="UploadPDF" CommandArgument='<%# Eval("Id") %>'>PDF</asp:LinkButton>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>--%>

                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemStyle Width="5%" />
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="Delete" DataKeyNames="Delete" DataField="Delete" runat="server" NavigateUrl="~/Views/Transparencias.aspx" ToolTip="Deletar de Transparências">Delete</asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>

                                        <Columns>
                                            <asp:TemplateField>
                                                <ItemStyle Width="5%" />
                                                <ItemTemplate>
                                                    <asp:HyperLink ID="update" DataKeyNames="update" DataField="update" runat="server" NavigateUrl="~/Views/Transparencias.aspx" ToolTip="Deletar de Transparências">Alterar</asp:HyperLink>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>

                                    </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>

            <div class="row">
                <div class="table-responsive">
                </div>

                <div class="table-responsive">
                </div>
                <div>
                    <asp:Label ID="lblQtde" runat="server" Visible="False"></asp:Label>
                </div>
                <div class="form-group">
                    <asp:Button ID="btnNovo" runat="server" Text="Nova Transparência" CssClass="btn btn-default" ToolTip="Salvar Nova Transparência" Visible="False" />
                </div>

                <div class="form-group">
                    <div class="col-lg-10 ">
                        <asp:LinkButton ID="LinkButton1" CssClass="hotpink" runat="server">Voltar Página</asp:LinkButton>
                    </div>
                </div>

                <br />
                <div class="form-group">
                    <div class="col-md-offset-2 col-md-10">
                        <asp:Label ID="lblResponse" runat="server" CssClass="text-danger" Text=""></asp:Label>
                    </div>
                </div>
            </div>

        </div>

    </div>

    <script type="text/javascript">
        $(function () {
            $('#datetimepicker1').datetimepicker();
        });

        var big = true;

        $('#div').click(function () {
            if (big) {
                big = false;
                $(this).animate({
                    height: "50px",
                    width: "50px"
                }, 1000);
            } else {
                big = true;
                $(this).animate({
                    height: "100px",
                    width: "100px"
                }, 1000);
            }
        });
    </script>

    <link rel="stylesheet" href="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/build/css/bootstrap-datetimepicker.css" />
    <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.9.0/moment-with-locales.js"></script>
    <script type="text/javascript" src="https://cdn.rawgit.com/Eonasdan/bootstrap-datetimepicker/e8bddc60e73c1ec2475f827be36e1957af72e2ea/src/js/bootstrap-datetimepicker.js"></script>
    <link href="../vendor/bootstrap/Condominio/Cond.css" rel="stylesheet" />

</asp:Content>
