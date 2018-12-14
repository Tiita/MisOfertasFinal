<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="VerOferta.aspx.cs" Inherits="MisOfertasFinal.Views.VerOferta.VerOferta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">

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
                                            
                                        </div>
                                        <div class="product-body">
                                            <p class="product-category"><asp:label id="nombreCategoria" runat="server" text="Label"></asp:label></p>
                                            <h3 class="product-name"><a href="#"><asp:label id="nombreproducto" runat="server" text="Label"></asp:label></a></h3>
                                            <h4 class="product-price"><asp:label id="preciofinal" runat="server" text="Label"></asp:label>
                                                <del class="product-old-price"><asp:label id="precioviejo" runat="server" text="Label"></asp:label></del></h4>
                                            <div class="product-label">
                                                <span class="sale"><asp:label id="porcentajeDescuento" runat="server" text="Label"></asp:label></span>
                                                <span class="new">De descuento</span>
                                            </div>
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
                                            <button class="add-to-cart-btn"><i class="fa fa-shopping-cart"></i>VER OFERTAS</button>
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
    <div class="col-md-12">
                    <div class="section-title">
                        <h3 class="title">Otras ofertas</h3>
                        <div id="pruebadiv" runat="server">
                </div>
                    </div>
                </div>

                

</asp:Content>
