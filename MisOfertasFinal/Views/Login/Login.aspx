<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MisOfertasFinal.Views.Login.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Login</title>
    <!-- Bootstrap core CSS-->
    <link href="../../Maqueta/visual/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../Maqueta/visual/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="../../Maqueta/visual/css/sb-admin.min.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src="../../Maqueta/visual/jquery/jquery.min.js"></script>
    <script src="../../Maqueta/visual/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../Maqueta/visual/jquery-easing/jquery.easing.min.js"></script>
    <link href="../../Maqueta/visual/css/sweetalert.css" rel="stylesheet" />
    <script src="../../Maqueta/visual/js/sweetalert.min.js" type="text/javascript"></script>
</head>
    <body style="background-color:#FFFFFF;">
    <div class="container">
        <div class="card card-login mx-auto mt-5">
            <div class="card-header">
                <h5>LOGIN</h5>
            </div>
            <div class="card-body">
                <form id="form1" runat="server">
                    <div class="form-group">
                        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="nombre@ejemplo.com"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <div class="form-check">
                            <label class="form-check-label" />
                            <asp:CheckBox ID="chkRecordar" runat="server" Text="Recordar Email" />
                        </div>
                    </div>
                    <asp:Button ID="btnAceptar" runat="server" CssClass="btn btn-lg btn-danger btn-block" Text="Aceptar" OnClick="btnAceptar_Click" />
                </form>
                <div class="text-center">
                    <a class="d-block small mt-3" href="../RegistrarCuenta/RegistrarCuenta.aspx">Registrar cuenta</a>
                    <a class="d-block small" href="#">Olvidaste la contraseña?</a>
                </div>
            </div>
        </div>
    </div>
</body>
</html>
