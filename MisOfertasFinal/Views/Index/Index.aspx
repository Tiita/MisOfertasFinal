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
            <h3 class="title">OFERTAS</h3>
        </div>
    </div>
    <!-- SECTION -->
    <div class="section">
        <!-- container -->
        <div class="container">
            <!-- row -->
            <div class="row">
                <div class="col-md-12">
                    <div class="row">
                        <div class="products-tabs">
                            <!-- tab -->
                            <asp:DataList ID="dtlOfertas" DataKeyField="id_producto" runat="server" RepeatColumns="4" OnItemCommand="dtlOfertas_ItemCommand">
                                <ItemTemplate>
                                    <div id="tab2" class="tab-pane fade in active">
                                        <div class="products-slick" data-nav="#slick-nav-2">
                                            <!-- PRODUCTO -->
                                            <div class="product">
                                                <div class="product-img">
                                                    <asp:Image ID="imgOferta" Width="200px" Height="200px"
                                                        runat="server" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("imagen_producto"))%>' />
                                                    <br />
                                                    <div class="product-label">
                                                        <span class="sale">-%<asp:Label ID="lblPorcentajeDescuento" runat="server" Text='<%# Eval("porcentaje_descuento") %>'></asp:Label></span>
                                                    </div>
                                                    <br />
                                                </div>
                                                <div class="product-body">
                                                    <asp:Label ID="lblCodigoProducto" Visible="false" Text='<%# Eval("id_producto") %> ' runat="server" />
                                                    <asp:Label ID="lblCodigoOferta" Visible="false" Text='<%# Eval("id_oferta") %> ' runat="server" />
                                                    <h3 class="product-name">
                                                        <a href="#">
                                                            <asp:Label ID="lblNombreProducto" runat="server" Text='<%# Eval("nombre_producto") %> ' />
                                                        </a>
                                                    </h3>
                                                    <h4 class="product-price">Precio oferta $
                                                        <asp:Label ID="lblPrecioFinal" runat="server" Text='<%# Eval("precio_final") %>'></asp:Label>
                                                        <del class="product-old-price">$
                                                            <asp:Label ID="lblPrecioViejo" runat="server" Text='<%# Eval("precio_producto") %>'></asp:Label>
                                                        </del></h4>
                                                    <div class="product-rating">
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                        <i class="fa fa-star"></i>
                                                    </div>
                                                </div>
                                                <div class="add-to-cart">
                                                    <asp:Button ID="btnVerOfertas" runat="server" CssClass="add-to-cart-btn" CommandName="Seleccionar" Text="VER OFERTAS" OnClick="btnVerOfertas_Click" />
                                                </div>
                                                <!-- /PRODUCTO -->
                                            </div>
                                            <div id="slick-nav-2" class="products-slick-nav"></div>
                                        </div>
                                        <!-- /tab -->
                                    </div>
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
                <!-- /Products tab & slick -->
            </div>
            <!-- /row -->
        </div>
        <!-- /container -->
    </div>
    <!-- /SECTION -->
</asp:Content>
