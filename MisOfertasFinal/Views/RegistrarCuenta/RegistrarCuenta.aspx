﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCuenta.aspx.cs" Inherits="MisOfertasFinal.Views.RegistrarCuenta.RegistrarCuenta" %>

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
            if (args.Value.length >= 9 ||args.Value.length >= 10) {
                args.IsValid = true;
            } else {
                args.IsValid = false;
            }
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="mx-auto mt-5">
            <%--PRIMER GRUPO DE CONTROLES--%>

            <div class="card">
                <div class="card-header">
                    Bienvenido Mis Ofertas
                    <!-- Repositorio de los validadores-->
                    <div class="row">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="mensaje-validacion" HeaderText="Por favor solucione los siguientes problemas:" />
                    </div>
                </div>
                <div class="card-body">
                    <h5 class="card-title">Crear cuenta cliente</h5>                    
                        <div class="form-group">
                            <div class="form-row">
                                <div class="col-md-2">
                                    <p class="card-text">
                                    <asp:Label runat="server" ID="lblNombreCliente" Text="Nombre:"></asp:Label>
                                    <asp:TextBox runat="server" ID="txtNombreCliente" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Indique su nombre" ControlToValidate="TxtNombreCliente" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                    </p>
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblApePaterno" Text="Apellido Paterno:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtApePaterno" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Indique su apellido paterno" ControlToValidate="TxtApePaterno" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblApeMaterno" Text="Apellido Materno:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtApeMaterno" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Indique su apellido materno" ControlToValidate="TxtApeMaterno" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblDireccion" Text="Dirección:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Indique su dirección" ControlToValidate="TxtDireccion" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="list-group list-group-flush">
                                        <asp:Label runat="server" ID="LblRegion" Text="Región:"></asp:Label>
                                        <asp:DropDownList ID="DropDownListRegion" runat="server" DataSourceID="LinqDataSource1" DataTextField="NOMBRE_REGION" DataValueField="ID_REGION" AutoPostBack="True"></asp:DropDownList>
                                        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="MisOfertasFinal.Entidades.EntitiesOfertas" EntityTypeName="" Select="new (NOMBRE_CATEGORIAPROD)" TableName="CATGORIAPRODUCTO">
                                        </asp:LinqDataSource>
                                    </p>
                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="list-group list-group-flush">
                                        <asp:Label runat="server" ID="LblComuna" Text="Comuna:"></asp:Label>
                                        <asp:DropDownList ID="DropDownListComuna" runat="server" AutoPostBack="True" DataSourceID="LinqDataSource2" DataTextField="NOMBRE_COMUNA" DataValueField="ID_COMUNA"></asp:DropDownList>
                                        <asp:LinqDataSource ID="LinqDataSource2" runat="server" ContextTypeName="MisOfertasFinal.Entidades.EntitiesOfertas" EntityTypeName="" Select="new (NOMBRE_CATEGORIAPROD)" TableName="CATGORIAPRODUCTO" Where="REGION_ID_REGION == @REGION_ID_REGION" OrderBy="ID_COMUNA">
                                        <WhereParameters>
                                        <asp:ControlParameter ControlID="DropDownListRegion" DefaultValue="1" Name="REGION_ID_REGION" PropertyName="SelectedValue" Type="Decimal" />
                                        </WhereParameters>
                                        </asp:LinqDataSource>
                                    </p>
                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblRut" Text="Rut Cliente:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtRut" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Indique su rut" ControlToValidate="TxtRut" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                        <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="Ingrese" ClientValidationFunction="validarLargoRut" ControlToValidate="TxtRut" CssClass="mensaje-validacion" Display="Dynamic">*</asp:CustomValidator>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblFono" Text="Teléfono:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtFono" CssClass="form-control"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="Indique su Telefono" ControlToValidate="TxtFono" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblCorreo" Text="Email:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" placeholder="name@example.com" type="email"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Indique su correo" ControlToValidate="TxtCorreo" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                    </p>                                    
                                </div>
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="lblPassword" Text="Password:"></asp:Label>
                                        <asp:TextBox runat="server" ID="txtPassword" CssClass="form-control" placeholder="Password" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Indique su clave" ControlToValidate="TxtPassword" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                        <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="La contraseña debe tener como minimo 6 chars" ClientValidationFunction="validarLargoClave" ControlToValidate="TxtPassword" CssClass="mensaje-validacion" Display="Dynamic">*</asp:CustomValidator>
                                    </p>                                    
                                </div> 
                                <div class="col-md-2">
                                    <p class="card-text">
                                        <asp:Label runat="server" ID="LblPassword2" Text="Repetir Password:"></asp:Label>
                                        <asp:TextBox runat="server" ID="TxtPassword2" CssClass="form-control" placeholder="Repita su Password" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Repita su clave" ControlToValidate="TxtPassword2" CssClass="mensaje-validacion">*</asp:RequiredFieldValidator>
                                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Clave no coinciden" ControlToCompare="TxtPassword" ControlToValidate="TxtPassword2" CssClass="mensaje-validacion" Display="Dynamic">*</asp:CompareValidator>
                                    </p>                                    
                                </div> 
                                <div class="col-md-2">
                                    <p class="card-link">
                                        <asp:CheckBox ID="CbNotificacion" runat="server" /> Acepto recibir ofertas en mi correo
                                    </p>                                    
                                </div>
                                
                                                        
                            </div>
                        </div>
                    
                     <%--SEGUNDO GRUPO DE CONTROLES--%>
                    <div class="form-group">
                        <div class="form-row">
                            <p class="card-text">
                                <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" />                                
                            </p>                            
                        </div>
                    </div>                            
                </div>
            </div>
        </div>
    </form>
</body>
</html>