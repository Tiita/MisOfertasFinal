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
                <asp:DataList ID="dtlOferta" DataKeyField="id_producto" runat="server" RepeatColumns="1" OnItemCommand="dtlOferta_ItemCommand">
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
                                        <asp:Label ID="lblCategoriaProducto" runat="server" Text='<%# Eval("nombre_categoria") %> '></asp:Label>
                                    </li>
                                </ul>
                                <br></br>
                                <h2 class="product-name">
                                    <asp:Label ID="lblNombreProducto" runat="server"  Text='<%# Eval("nombre_producto") %> '></asp:Label></h2>
                                <div>        
                                    <p>Calificación : <asp:Label ID="lblCalificacion" runat="server"  Text='<%# Eval("calificacion") %> '></asp:Label></p>                                                                    
                                </div>
                                <div>
                                    <h3 class="product-price">Oferta $<asp:Label ID="lblPrecioFinal" runat="server" Text='<%# Eval("precio_final") %>'></asp:Label>
                                        <del class="product-old-price">Normal $<asp:Label ID="lblPrecioViejo" runat="server" Text='<%# Eval("precio_producto") %>'></asp:Label></del></h3>
                                    <span class="product-available">En Stock
                                        <asp:Label ID="lblStockProducto" runat="server" Text='<%# Eval("stock_producto") %>'></asp:Label></span>
                                </div>

                                <div class="product-options">
                                    <p class="product-name">
                                        Descripción:
                                    <asp:Label ID="lblDescripcionProducto" runat="server" Text='<%# Eval("descripcion_producto") %>'></asp:Label>
                                    </p>
                                    <br></br>
                                    <p>
                                        Se debe considerar que el precio oferta es respetado dentro de las cantidades permitidas, 
                                    en caso contrario debe pagar el precio normal del producto.
                                    </p>

                                    Cantidad mínima a comprar:
                                    <asp:Label ID="lblMinimoOferta" runat="server" Text='<%# Eval("minimo_pro") %>'></asp:Label>
                                    <br />
                                    Cantidad máxima a comprar:
                                    <asp:Label ID="lblMaximoOferta" runat="server" Text='<%# Eval("maximo_pro") %>'></asp:Label>
                                </div>
                                <br />                                
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
                                                <span>Adjuntar boleta: </span>
                                                <br></>
                                                <asp:FileUpload CssClass="form-control" ID="flSubir" accept=".jpg" runat="server" />                                                
                                                <br></>
                                                <br></>
                                                <asp:TextBox runat="server" ID="txtNumeroBoleta" CssClass="form-control" Width="370px"
                                                     placeholder="Ingrese código de boleta "></asp:TextBox>
                                                <br></>
                                                <div class="input-rating">
                                                <span>Realiza tu valoración: </span>
                                                <br></>
                                                    <asp:DropDownList ID="ddlValoracion" runat="server" CssClass="form-control" Width="370px" AutoPostBack="false">
                                                        <asp:ListItem Text="Califica el producto" />
                                                        <asp:ListItem Text="5. Muy bueno" Value="5" />
                                                        <asp:ListItem Text="4. Bueno" Value="4" />
                                                        <asp:ListItem Text="3. Normal" Value="3" />
                                                        <asp:ListItem Text="2. Malo" Value="2" />
                                                        <asp:ListItem Text="1. Muy malo" Value="1" />
                                                    </asp:DropDownList>
                                                </div>
                                                <br></>
                                                <asp:Button ID="btnValorar" runat="server" CssClass="primary-btn" Text="VALORAR OFERTA" CommandName="RegistrarValoracion" />
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
                                                <span>Promedio calificaciones 4.5</span>                                                
                                            </div>                                            
                                        </div>
                                    </div>
                                    <!-- /Rating -->

                                    <!-- Reviews -->
                                    <div class="col-md-6">
                                        <div id="reviews">
                                            <ul class="reviews">
                                                <li>
                                                    <div class="review-heading">
                                                        <h5 class="name"><asp:Label ID="lblNombreUsuario" runat="server" Text='<%# Eval("rut_usuario") %>'></asp:Label></h5>
                                                        <p class="date"><asp:Label ID="lblCalificacionOferta" runat="server" Text='<%# Eval("calificacion") %>'></asp:Label></p>                                                        
                                                    </div>
                                                    <div class="review-body">
                                                        <p></p>
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
                                    </div> <!-- /Reviews -->
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
