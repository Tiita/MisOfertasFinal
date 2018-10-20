<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCuenta.aspx.cs" Inherits="MisOfertasFinal.Views.RegistrarCuenta.RegistrarCuenta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <title>Crear cuenta cliente</title>
    <!-- Bootstrap core CSS-->
    <link href="../../vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom fonts for this template-->
    <link href="../../vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <!-- Custom styles for this template-->
    <link href="../../css/sb-admin.css" rel="stylesheet" />
    <!-- Bootstrap core JavaScript-->
    <script src="../../vendor/jquery/jquery.min.js"></script>
    <script src="../../vendor/bootstrap/js/bootstrap.bundle.min.js"></script>
    <!-- Core plugin JavaScript-->
    <script src="../../vendor/jquery-easing/jquery.easing.min.js"></script>

    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mx-auto mt-5">
            <%--PRIMER GRUPO DE CONTROLES--%>

            <div class="card">
                <div class="card-header">
                    Bienvenido Mis Ofertas
                </div>
                <div class="card-body">
                    <h5 class="card-title">Crear cuenta cliente</h5>                    
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-2">
                                    <p class="card-text">
                                    <asp:Label runat="server" ID="lblNombreCliente" Text="Nombre:"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNombreCliente" CssClass="form-control"></asp:TextBox>
                                    </p>
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblApePaterno" Text="Apellido Paterno:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtApePaterno" CssClass="form-control"></asp:TextBox>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblApeMaterno" Text="Apellido Materno:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtApeMaterno" CssClass="form-control"></asp:TextBox>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblCorreo" Text="Email:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" placeholder="name@example.com"></asp:TextBox>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblRut" Text="Rut cliente:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtRut" CssClass="form-control"></asp:TextBox>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblDireccion" Text="Dirección:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblFono" Text="Teléfono:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtFono" CssClass="form-control"></asp:TextBox>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblPassword" Text="Password:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                                    </p>                                    
                                </div>                                
                            </div>
                        </div>
                    </p>
                     <%--SEGUNDO GRUPO DE CONTROLES--%>
                    <div class="form-group">
                        <div class="form-row">
                            <p class="card-text">
                                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" />                                
                            </p>                            
                        </div>
                    </div>                            
                </div>
            </div>
        </div>
    </form>
</body>
</html>
