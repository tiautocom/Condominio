<%@ Page Title="Login" Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TI.CONDOMINIO.TRANSPARENCIA.UI.Login" %>

<!DOCTYPE html>


<%--<link href="Content/Login.css" rel="stylesheet" />--%>
<link href="login2.css" rel="stylesheet" />
<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
<link href="css/modern-business.css" rel="stylesheet" />
<meta name="viewport" content="user-scalable=no,initial-scale=1,maximum-scale=1">
<link rel="shortcut icon" type="image/x-icon" href="icon%20vanessa/z%20condomínio%20png%201%20(1).png" />



<script src="vendor/jquery/jquery.min.js"></script>
<script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

<form runat="server">
    <section style="height: 100vh;">
        <div style="background-image: url(images/arka.jpg); background-attachment: fixed; background-size: cover; width: 100%; height: 100vh; position: relative;">
            <div class="baslik">
                <b style="font-size: 101px; text-align: center; margin-bottom: -21px; display: block;"></b>
                <span style="font-size: 19px; text-align: center; display: block; margin-bottom: 25px;">Triade Admininstradora</span>
            </div>

            <div class="arkalogin">
                <div class="loginbaslik">Admin Login</div>
                <hr style="border: 1px solid #ccc;">
                <asp:textbox runat="server" id="txtLogin" cssclass="giris" placeholder="Celular" textmode="Phone"></asp:textbox>
                <asp:textbox runat="server" id="txtPassword" cssclass="giris" placeholder="Senha" textmode="Password"></asp:textbox>

                <asp:button runat="server" cssclass="butonlogin" text="Login" ta onclick="Unnamed1_Click" />
                <br />
                <p class="text-danger">
                    <asp:literal id="FailureText" runat="server" />
                </p>

                         <span style="font-size: 17px; text-align: center; display: block; color: #fff;">
                <a href="PrimeiroAcesso.aspx" target="_blank">Cadastre-se</a>
            </span>
            </div>

            <br>
            <span style="font-size: 23px; text-align: center; display: block; color: #E6E6E6;">Bem Vindo ao Sistema Z-Condominio</span>
            <span style="font-size: 24px; text-align: center; display: block; color: #fff; font-weight: bold; margin-bottom: 34px;">LOGİN</span>
            <span style="font-size: 17px; text-align: center; display: block; color: #fff;">
                <a href="http://zcondominio.com.br/" target="_blank">www.zcondominio.com.br</a>
            </span>


        

        </div>
    </section>

    <div id="mymodal" class="modal fade" role="dialog">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">&times;</button>
                    <h5 class="modal-title"></h5>
                </div>
                <div class="modal-body">
                    <h5>Bem vindo ao Sistema de Gerencimento</h5>
                    <h5>Z-Condominios.</h5>
                    <p>Informe o Numero do Token de Segurança com 6 Digitos.</p>
                    <asp:textbox id="txtToken" runat="server" cssclass="giris" textmode="Password"></asp:textbox>

                    <p class="text-danger">
                        <asp:literal id="Literal1" runat="server" />
                    </p>
                    <a href="#">Esqueceu o Token?</a>
                </div>
                <div class="modal-footer">
                    <asp:button id="btnSalvarToken" runat="server" text="Salvar" class="btn btn-primary" onclick="btnSalvarToken_Click" />
                </div>
            </div>
        </div>
    </div>

</form>
