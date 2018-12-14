<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MisOfertasFinal.Views.Index.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cabecera" runat="server">
    <link href="../../Maqueta/visual/css/sweetalert.css" rel="stylesheet" />
    <script src="../../Maqueta/visual/js/sweetalert.min.js" type="text/javascript"></script>
    <!-- Google font -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet">
    <!-- Bootstrap -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/bootstrap.min.css" />
    <!-- Slick -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/slick.css" />
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/slick-theme.css" />
    <!-- nouislider -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/nouislider.min.css" />
    <!-- Font Awesome Icon -->
    <link rel="stylesheet" href="../../Maqueta/css/font-awesome.min.css">
    <!-- Custom stlylesheet -->
    <link type="text/css" rel="stylesheet" href="../../Maqueta/css/style.css" />
    <!-- jQuery Plugins -->
    <script src="../../Maqueta/js/jquery.min.js"></script>
    <script src="../../Maqueta/js/bootstrap.min.js"></script>
    <script src="../../Maqueta/js/nouislider.min.js"></script>
    <script src="../../Maqueta/js/nouislider.min.js"></script>
    <script src="../../Maqueta/js/jquery.zoom.min.js"></script>
    <script src="../../Maqueta/js/main.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <div class="container">
        <div class="card mx-auto mt-5">
            <!--<div class="card-header">Ofertas vigentes</div>-->
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-4">
                            <asp:Label ID="lblRubro" Text="Rubro:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlRubro" CssClass="form-control" OnSelectedIndexChanged="ddlRubro_SelectedIndexChanged"
                                AutoPostBack="true" Width="313px">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblCategoria" Text="Categoria:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-control" AutoPostBack="false" Width="311px">
                            </asp:DropDownList>    
                        </div>                       
                        <div class="col-md-4">
                            <asp:Label ID="lblMarca" Text="Marca:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlMarca" CssClass="form-control" Width="311px">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
   
                <div class="col-md-12">
                    <div class="section-title">
                        <h3 class="title">Ofertas</h3>
                    </div>
                </div>

                <div id="pruebadiv" runat="server">

                </div>


            
</asp:Content>
