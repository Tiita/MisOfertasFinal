<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="VerOferta.aspx.cs" Inherits="MisOfertasFinal.Views.VerOferta.VerOferta" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <!-- Sección -->
    <div class="section">
        <!-- Contenedor -->
        <div class="container">
            <!-- Fila -->
            <div class="row">
                <asp:DataList ID="dtlOferta" DataKeyField="id_producto" runat="server" RepeatColumns="1">
                    <ItemTemplate>
                        <!--Imagen producto principal lado central-->
                        <div class="col-md-7 col-md-push-2">
                            <div id="product-main-img">
                                <div class="product-preview">
                                    <asp:Image ID="imgOferta" Width="300px" Height="300px"
                                        runat="server" ImageUrl='<%#"data:Image/jpg;base64," + Convert.ToBase64String((byte[])Eval("imagen_producto"))%>' />
                                    <br />
                                </div>
                            </div>
                        </div>
                        <!-- /Imagen producto principal -->
                        <!-- Detalle de producto -->
                        <div class="col-md-5">
                            <div class="product-details">
                                <ul class="product-links">
                                    <li>Categoría:</li>
                                    <li>
                                        <asp:Label ID="lblCategoriaProducto" runat="server" Text='<%# Eval("nombre_categoria") %> '></asp:Label></li>
                                </ul>
                                </br>
                                <h2 class="product-name">
                                    <asp:Label ID="lblNombreProducto" runat="server" Text='<%# Eval("nombre_producto") %> '></asp:Label></h2>
                                <div>
                                    <p>Valoración oferta: </p>
                                    <div class="product-rating">
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star"></i>
                                        <i class="fa fa-star-o"></i>
                                    </div>
                                </div>
                                <div>
                                    <h3 class="product-price">$<asp:Label ID="lblPrecioFinal" runat="server" Text='<%# Eval("precio_final") %>'></asp:Label>
                                        <del class="product-old-price">$<asp:Label ID="lblPrecioViejo" runat="server" Text='<%# Eval("precio_producto") %>'></asp:Label></del></h3>
                                    <span class="product-available">En Stock
                                        <asp:Label ID="lblStockProducto" runat="server" Text='<%# Eval("stock_producto") %>'></asp:Label></span>
                                </div>
                                
                                <div class="product-options">
                                    <p class="product-name">
                                    Descripción:
                                    <asp:Label ID="lblDescripcionProducto" runat="server" Text='<%# Eval("descripcion_producto") %>'></asp:Label></p>
                                     </br>
                                    <p>Se debe considerar que el precio oferta es respetado dentro de las cantidades permitidas, 
                                    en caso contrario debe pagar el precio normal del producto.</p>

                                    Cantidad mínima a comprar:
                                    <asp:Label ID="lblMinimoOferta" runat="server" Text='<%# Eval("minimo_pro") %>'></asp:Label>
                                    <br />
                                    Cantidad máxima a comprar:
                                    <asp:Label ID="lblMaximoOferta" runat="server" Text='<%# Eval("maximo_pro") %>'></asp:Label>
                                </div>                                
                                <br />
                                <div class="add-to-cart">
                                    <asp:Button ID="btnVerTiendas" runat="server" CssClass="add-to-cart-btn" Text="VER TIENDAS" />
                                </div>
                                <ul class="product-links">
                                    <li>Compartir:</li>
                                    <li><a href="https://es-la.facebook.com/"><i class="fa fa-facebook"></i></a></li>
                                    <li><a href="https://twitter.com/?lang=es"><i class="fa fa-twitter"></i></a></li>
                                    <li><a href="https://www.google.com/intl/es/gmail/about/#"><i class="fa fa-google-plus"></i></a></li>
                                </ul>
                            </div>
                        </div>
                        <!-- /Detalle producto -->
                        <!-- Product tab -->
                        <div class="col-md-12">
                            <div id="product-tab">
                                <!-- product tab nav -->
                                <ul class="tab-nav">
                                    <li class="active"><a data-toggle="tab" href="#tab1">VALORAR OFERTA</a></li>
                                    <li><a data-toggle="tab" href="#tab3">RESUMEN VALORACIONES</a></li>
                                </ul>
                                <!-- /product tab nav -->

                                <!-- product tab content -->
                                <div class="tab-content">
                                    <!-- tab1  -->
                                    <div id="tab1" class="tab-pane fade in active">
                                        <div class="row">
                                            <div class="col-md-12">
                                                <p>Danos tu opinión acerca de este producto.</p>
                                                <!-- Review Form -->
                                                <div class="col-md-3">
                                                    <div id="review-form">                                                 
                                                            <asp:Image Width="150px" Height="150px" ImageUrl="~/Imagenes/Nohay.png" runat="server"></asp:Image>
                                                            </br>
                                                            </br>
                                                            <span>Adjuntar boleta: </span>
                                                            <br></br>
                                                            <asp:FileUpload CssClass="form-control" ID="flSubir" accept=".jpg" runat="server" />
                                                            <br></br>
                                                            <asp:TextBox runat="server" ID="txtNumeroBoleta" CssClass="form-control" Width="370px"
                                                                placeholder="Ingrese código de boleta "></asp:TextBox>
                                                            </br>
                                                            <div class="input-rating">
                                                                <span>Realiza tu valoración: </span>
                                                                </br>
                                                                </br>
                                                                <asp:DropDownList ID="ddlValoracion" runat="server" CssClass="form-control" Width="370px" AutoPostBack="true">
                                                                    <asp:ListItem Text="Califica el producto" />
                                                                    <asp:ListItem Text="5. Fantastico" />
                                                                    <asp:ListItem Text="4. Grandioso" />
                                                                    <asp:ListItem Text="3. Bueno" />
                                                                    <asp:ListItem Text="2. Pobre" />
                                                                    <asp:ListItem Text="1. Terrible" />
                                                                </asp:DropDownList>                                                   
                                                            </div>
                                                            </br>
                                                            <asp:Button ID="btnValorar" runat="server" CssClass="primary-btn" Text="VALORAR OFERTA" />
                                                         </div>                                         
                                                </div>
                                                <!-- /Review Form -->
                                            </div>
                                        </div>
                                    </div>
                                    <!-- /tab1  -->

                                    <!-- tab3  -->
                                    <div id="tab3" class="tab-pane fade in">
                                        <div class="row">
                                            <!-- Rating -->
                                            <div class="col-md-3">
                                                <div id="rating">
                                                    <div class="rating-avg">
                                                        <span>4.5</span>
                                                        <div class="rating-stars">
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star"></i>
                                                            <i class="fa fa-star-o"></i>
                                                        </div>
                                                    </div>
                                                    <ul class="rating">
                                                        <li>
                                                            <div class="rating-stars">
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                            </div>
                                                            <div class="rating-progress">
                                                                <div style="width: 80%;"></div>
                                                            </div>
                                                            <span class="sum">3</span>
                                                        </li>
                                                        <li>
                                                            <div class="rating-stars">
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star-o"></i>
                                                            </div>
                                                            <div class="rating-progress">
                                                                <div style="width: 60%;"></div>
                                                            </div>
                                                            <span class="sum">2</span>
                                                        </li>
                                                        <li>
                                                            <div class="rating-stars">
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star-o"></i>
                                                                <i class="fa fa-star-o"></i>
                                                            </div>
                                                            <div class="rating-progress">
                                                                <div></div>
                                                            </div>
                                                            <span class="sum">0</span>
                                                        </li>
                                                        <li>
                                                            <div class="rating-stars">
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star-o"></i>
                                                                <i class="fa fa-star-o"></i>
                                                                <i class="fa fa-star-o"></i>
                                                            </div>
                                                            <div class="rating-progress">
                                                                <div></div>
                                                            </div>
                                                            <span class="sum">0</span>
                                                        </li>
                                                        <li>
                                                            <div class="rating-stars">
                                                                <i class="fa fa-star"></i>
                                                                <i class="fa fa-star-o"></i>
                                                                <i class="fa fa-star-o"></i>
                                                                <i class="fa fa-star-o"></i>
                                                                <i class="fa fa-star-o"></i>
                                                            </div>
                                                            <div class="rating-progress">
                                                                <div></div>
                                                            </div>
                                                            <span class="sum">0</span>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <!-- /Rating -->

                                            <!-- Reviews -->
                                            <div class="col-md-6">
                                                <div id="reviews">
                                                    <ul class="reviews">
                                                        <li>
                                                            <div class="review-heading">
                                                                <h5 class="name">John</h5>
                                                                <p class="date">27 DEC 2018, 8:0 PM</p>
                                                                <div class="review-rating">
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star-o empty"></i>
                                                                </div>
                                                            </div>
                                                            <div class="review-body">
                                                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</p>
                                                            </div>
                                                        </li>
                                                        <li>
                                                            <div class="review-heading">
                                                                <h5 class="name">John</h5>
                                                                <p class="date">27 DEC 2018, 8:0 PM</p>
                                                                <div class="review-rating">
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star-o empty"></i>
                                                                </div>
                                                            </div>
                                                            <div class="review-body">
                                                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</p>
                                                            </div>
                                                        </li>
                                                        <li>
                                                            <div class="review-heading">
                                                                <h5 class="name">John</h5>
                                                                <p class="date">27 DEC 2018, 8:0 PM</p>
                                                                <div class="review-rating">
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star"></i>
                                                                    <i class="fa fa-star-o empty"></i>
                                                                </div>
                                                            </div>
                                                            <div class="review-body">
                                                                <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua</p>
                                                            </div>
                                                        </li>
                                                    </ul>
                                                    <ul class="reviews-pagination">
                                                        <li class="active">1</li>
                                                        <li><a href="#">2</a></li>
                                                        <li><a href="#">3</a></li>
                                                        <li><a href="#">4</a></li>
                                                        <li><a href="#"><i class="fa fa-angle-right"></i></a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <!-- /Reviews -->


                                        </div>
                                    </div>
                                    <!-- /tab3  -->
                                </div>
                                <!-- /product tab content  -->
                            </div>
                        </div>
                        <!-- /product tab -->
                    </ItemTemplate>
                </asp:DataList>
                <!-- /product tab -->
            </div>
            <!-- /Fila -->
        </div>
        <!-- /Contenedor -->
    </div>
    <!-- /Sección -->

    <!--PARTE QUE MOSTRARÁ PRODUCTOS RELACIONADOS-->
    <!-- Seccion -->
    <div class="section">
        <!-- Contenedor -->
        <div class="container">
            <!-- Fila -->
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title text-center">
                        <h3 class="title">PRODUCTOS RELACIONADOS</h3>
                    </div>
                </div>

                <!-- tab -->
                <asp:DataList ID="dtlProRelacionados" DataKeyField="id_producto" runat="server" RepeatColumns="4" OnItemCommand="dtlProRelacionados_ItemCommand">
                    <ItemTemplate>

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
                                <asp:Button ID="btnVerOfertas" runat="server" CssClass="add-to-cart-btn" CommandName="Seleccionar" Text="VER OFERTAS" />
                            </div>
                            <!-- /PRODUCTO -->
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
            <!-- /Fila -->
        </div>
        <!-- /Contenedor -->
    </div>
    <!-- /Seccion -->

</asp:Content>
