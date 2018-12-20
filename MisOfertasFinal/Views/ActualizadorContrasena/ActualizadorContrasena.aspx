<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ActualizadorContrasena.aspx.cs" Inherits="MisOfertasFinal.Views.ActualizadorContrasena.ActualizadorContrasena" %>

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
<body class="bg-dark">
    <form id="form1" runat="server">
        
         <div class="container">
            <div class="card card-login mx-auto mt-5">
                <div class="card-header">Restrablecer contraseña</div>
                <div class="card-body">

                    <div class="text-center mt-4 mb-5">
                        <h4>Aqui podras restablecer tu contraseña.</h4>
                        <p>
                        </p>
                   <div>
                                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" placeholder="Password"
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="VldRequierepass1" runat="server" ErrorMessage="Indique su clave"
                                    ControlToValidate="TxtPassword" CssClass="mensaje-validacion" ForeColor="Red">Ingrese su clave</asp:RequiredFieldValidator>
                                <asp:CustomValidator ID="VldCustom1" runat="server"
                                    ErrorMessage="La contraseña debe tener como minimo 6 chars" ClientValidationFunction="validarLargoClave"
                                    ControlToValidate="TxtPassword" CssClass="mensaje-validacion" Display="Dynamic" ForeColor="Red">La contraseña es muy corta</asp:CustomValidator>
                              </div>  <br />
                            <div>    <asp:TextBox runat="server" ID="TxtPassword2" CssClass="form-control" placeholder="Repita su Password" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="validador3" runat="server" ErrorMessage="Repita su clave"
                                    ControlToValidate="TxtPassword2" CssClass="mensaje-validacion" ForeColor="Red">Repita su contraseña</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="Validador2" runat="server" ErrorMessage="Clave no coinciden"
                                    ControlToCompare="TxtPassword" ControlToValidate="TxtPassword2" CssClass="mensaje-validacion"
                                    Display="Dynamic" ForeColor="Red">Las contraseña no coinciden</asp:CompareValidator>
                           </div>  

                    <asp:Button runat="server" ID="btnAceptar" CssClass="btn btn-danger btn-block" Text="Restablecer contraseña" OnClick="btnAceptar_Click" />
                        
                    <asp:Button runat="server" ID="btnIniciarSesion" CssClass="btn btn-danger btn-block" Text="Iniciar Sesión" OnClick="btnIniciarSesion_Click"  />
                    
                    <div class="text-center">
                        <a class="d-block small mt-3" href="../Login/Login.aspx">Iniciar sesión</a>
                    </div>
                </div>
            </div>
                    </div>
        </div>    
    </form>
</body>
</html>
