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
            <div class="card-header">Ofertas vigentes</div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-4">
                            <div class="col-md-4">
                                <asp:Label ID="lblCategoria" Text="Categoria:" runat="server"></asp:Label>
                                <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-control"
                                    OnSelectedIndexChanged="ddlCategoria_SelectedIndexChanged" AutoPostBack="true">
                                </asp:DropDownList>
                            </div>
                            <asp:Label ID="lblRubro" Text="Rubro:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlRubro" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblMarca" Text="Marca:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlMarca" CssClass="form-control">
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- SECCION -->
    <div class="section">
        <!-- CONTENEDOR -->
        <div class="container">
            <!-- FILA -->
            <div class="row">
                <!-- SECCIÓN DEL TÍTULO -->
                <div class="col-md-12">
                    <div class="section-title">
                        <h3 class="title">Ofertas</h3>
                    </div>
                </div>
                <!-- /SECCIÓN DEL TÍTULO -->

                <!-- Products tab & slick -->
                <div class="col-md-4">
                    <div class="row">
                        <div class="products-tabs">
                            <!-- tab -->
                            <div id="tab2" class="tab-pane fade in active">
                                <div class="products-slick" data-nav="#slick-nav-2">
                                    <!-- PRODUCTO -->
                                    <div class="product">
                                        <div class="product-img">
                                            <img src="./img/product06.png" alt="">
                                            <div class="product-label">
                                                <span class="sale">-30%</span>
                                                <span class="new">NUEVO</span>
                                            </div>
                                        </div>
                                        <div class="product-body">
                                            <p class="product-category">CATEGORÍA</p>
                                            <h3 class="product-name"><a href="#">AQUÍ DEBE IR EL PRODUCTO</a></h3>
                                            <h4 class="product-price">$980.00 <del class="product-old-price">$990.00</del></h4>
                                            <div class="product-rating">
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                                <i class="fa fa-star"></i>
                                            </div>
                                            <div class="product-btns">
                                                <button class="add-to-wishlist"><i class="fa fa-heart-o"></i><span class="tooltipp">add to wishlist</span></button>
                                                <button class="add-to-compare"><i class="fa fa-exchange"></i><span class="tooltipp">add to compare</span></button>
                                                <button class="quick-view"><i class="fa fa-eye"></i><span class="tooltipp">quick view</span></button>
                                            </div>
                                        </div>
                                        <div class="add-to-cart">
                                            <button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i>VALORAR OFERTA</button>
                                        </div>
                                    </div>
                                    <!-- /PRODUCTO -->
                                </div>
                                <div id="slick-nav-2" class="products-slick-nav"></div>
                            </div>
                            <!-- /tab -->
                        </div>
                    </div>
                </div>
                <!-- /Products tab & slick -->
            </div>
            <!-- /FILA -->
        </div>
        <!-- /CONTENEDOR -->
    </div>
    <!-- /SECCIÓN -->


</asp:Content>
