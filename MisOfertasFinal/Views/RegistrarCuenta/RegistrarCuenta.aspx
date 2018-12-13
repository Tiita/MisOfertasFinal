<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCuenta.aspx.cs" Inherits="MisOfertasFinal.Views.RegistrarCuenta.RegistrarCuenta" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>REGISTRAR CLIENTE</title>
    <!-- Google font -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet" />
    <!-- Bootstrap -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/bootstrap.min.css" />
    <!-- Slick -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/slick.css" />
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/slick-theme.css" />
    <!-- nouislider -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/nouislider.min.css" />
    <!-- Font Awesome Icon -->
    <link rel="stylesheet" href="../../Maqueta/css/font-awesome.min.css" />
    <!-- Custom stlylesheet -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/style.css" />
    <script src="../../Maqueta/js/jquery.min.js"></script>
    <script src="../../Maqueta/js/bootstrap.min.js"></script>
    <script src="../../Maqueta/js/slick.min.js"></script>
    <script src="../../Maqueta/js/nouislider.min.js"></script>
    <script src="../../Maqueta/js/jquery.zoom.min.js"></script>
    <script src="../../Maqueta/js/main.js"></script>
    <script>
        <!-- Funcion para validar el largo de la password y para validar el largo del rut-->
    function validarLargoClave(src, args) {
        if (args.Value.length >= 6) {
            args.IsValid = true;
        } else {
            args.IsValid = false;
        }
    }
    function validarLargoRut(src, args) {
        if (args.Value.length >= 9 || args.Value.length >= 10) {
            args.IsValid = true;
        } else {
            args.IsValid = false;
        }
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <!--CABECERA-->
        <header>
            <!--CABECERA PRINCIPAL-->
            <div id="header">
                <!--Contenedor-->
                <div class="container">
                    <!--Fila-->
                    <div class="row">
                        <!--Logo-->
                        <div class="col-md-3">
                            <div class="header-logo">
                                <a href="#" class="Logo">
                                    <img src="../../Imagenes/Iconocompleto.png" height="60" alt="" />
                                </a>
                            </div>
                        </div>
                        <!--Logo-->
                    </div>
                    <!--Fila-->
                </div>
                <!--Contenedor-->
            </div>
            <!--CABECERA PRINCIPAL-->
        </header>
        <!-- CABECERA-->
        <!-- SECCION -->
        <div class="section">
            <!-- CONTENEDOR -->
            <div class="container">
                <!-- FILA -->
                <div class="row">
                    <div class="col-md-7">
                        <!-- DETALLE DE REGISTRO -->
                        <div class="billing-details">
                            <div class="section-title">
                                <h3 class="title">Registro de cuenta</h3>
                                <div class="row">
                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server"
                                        CssClass="mensaje-validacion" HeaderText="Por favor solucione los siguientes problemas:" />
                                </div>
                            </div>
                            <div class="form-group">
                                <asp:TextBox runat="server" ID="txtRut" CssClass="form-control" placeholder="Ingrese rut sin puntos ni guión"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ErrorMessage="Indique su rut" ControlToValidate="TxtRut" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Ingrese un Rut mínimo 9 caracteres"
                                    ClientValidationFunction="validarLargoRut" ControlToValidate="TxtRut" CssClass="mensaje-validacion"
                                    Display="Dynamic" ForeColor="Red">*</asp:CustomValidator>
                                <br />

                                <asp:TextBox runat="server" ID="txtNombreCliente" CssClass="form-control" placeholder="Ingrese nombre"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Indique su nombre"
                                    ControlToValidate="TxtNombreCliente" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />
                                <asp:TextBox runat="server" ID="txtApePaterno" CssClass="form-control" placeholder="Ingrese apellido paterno"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Indique su apellido paterno"
                                    ControlToValidate="TxtApePaterno" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />

                                <asp:TextBox runat="server" ID="txtApeMaterno" CssClass="form-control" placeholder="Ingrese apellido materno"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Indique su apellido materno"
                                    ControlToValidate="TxtApeMaterno" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />
                                <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" placeholder="Ingrese dirección"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Indique su dirección"
                                    ControlToValidate="TxtDireccion" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />
                                <asp:DropDownList runat="server" ID="ddlRegion" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlRegion_SelectedIndexChanged">
                                </asp:DropDownList>
                                <br />
                                <asp:DropDownList runat="server" ID="ddlComuna" CssClass="form-control" AutoPostBack="false">
                                </asp:DropDownList>
                                <br />
                                <asp:TextBox runat="server" ID="txtFono" CssClass="form-control" placeholder="Ingrese teléfono"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server"
                                    ErrorMessage="Indique su Telefono" ControlToValidate="TxtFono"
                                    CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />
                                <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control"
                                    placeholder="name@example.com" type="email"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5"
                                    runat="server" ErrorMessage="Indique su correo" ControlToValidate="TxtCorreo"
                                    CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <br />
                                <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" placeholder="Password"
                                    TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Indique su clave"
                                    ControlToValidate="TxtPassword" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:CustomValidator ID="CustomValidator1" runat="server"
                                    ErrorMessage="La contraseña debe tener como minimo 6 chars" ClientValidationFunction="validarLargoClave"
                                    ControlToValidate="TxtPassword" CssClass="mensaje-validacion" Display="Dynamic" ForeColor="Red">*</asp:CustomValidator>
                                <br />
                                <asp:TextBox runat="server" ID="TxtPassword2" CssClass="form-control" placeholder="Repita su Password" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Repita su clave"
                                    ControlToValidate="TxtPassword2" CssClass="mensaje-validacion" ForeColor="Red">*</asp:RequiredFieldValidator>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Clave no coinciden"
                                    ControlToCompare="TxtPassword" ControlToValidate="TxtPassword2" CssClass="mensaje-validacion"
                                    Display="Dynamic" ForeColor="Red">*</asp:CompareValidator>
                                <br />
                                <div>
                                    <asp:CheckBox Text="¿Deseas recibir ofertas a su correo electrónico?" runat="server" ID="chkCorreo" />
                                </div>
                            </div>
                            <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="primary-btn order-submit" OnClick="btnGuardar_Click" />
                        </div>
                        <!-- /DETALLE DE REGISTRO -->
                    </div>
                </div>
                <!-- /FILA -->
            </div>
            <!-- /CONTENEDOR -->
        </div>
        <!-- /SECCION -->

        <!--PIE DE PAGINA-->
        <footer id="footer">
            <!-- bottom footer -->
            <div id="bottom-footer" class="section">
                <div class="container">
                    <!-- FILA -->
                    <div class="row">
                        <div class="col-md-12 text-center">
                            <span class="copyright">Copyright &copy;<script>document.write(new Date().getFullYear());</script>
                                Todos los derechos reservados Mis Ofertas
                            </span>
                        </div>
                    </div>
                    <!-- /FILA -->
                </div>
                <!-- /container -->
            </div>
            <!-- /bottom footer -->
        </footer>
        <!--/PIE DE PAGINA-->
    </form>
</body>
</html>
