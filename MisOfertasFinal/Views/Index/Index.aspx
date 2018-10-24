<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="MisOfertasFinal.Views.Index.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <link href="../../css/sweetalert.css" rel="stylesheet" />
    <script src="../../js/sweetalert.min.js" type="text/javascript"></script>
    <div class="container">
        <div class="card mx-auto mt-5">
            <div class="card-header">Ofertas vigentes</div>
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-4">
                            <asp:Label ID="lblRubro" Text="Rubro:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlRubro" CssClass="form-control">
                                <asp:ListItem Text="text1" />
                                <asp:ListItem Text="text2" />
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblCategoria" Text="Categoria:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlCategoria" CssClass="form-control">
                                <asp:ListItem Text="text1" />
                                <asp:ListItem Text="text2" />
                            </asp:DropDownList>
                        </div>
                        <div class="col-md-4">
                            <asp:Label ID="lblMarca" Text="Marca:" runat="server"></asp:Label>
                            <asp:DropDownList runat="server" ID="ddlMarca" CssClass="form-control">
                                <asp:ListItem Text="text1" />
                                <asp:ListItem Text="text2" />
                            </asp:DropDownList>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="card mx-auto mt-5">
            <!--<div class="card-header">Ofertas vigentes</div>-->
            <div class="card-body">
                <div class="form-group">
                    <div class="form-row">
                        <div class="col-md-4">
                             <asp:DataList ID="dlstProductos" DataKeyField="DecIdProducto" runat="server" RepeatColumns="4">
                                <ItemTemplate>
                                    <asp:Image ID="imgGeneral" width="140" height="120" runat="server" ImageUrl='<%# "~/temporal/" +Eval("BytImagenProducto") %>' />
                                    <br />
                                    <br />
                                   <!-- Código :
                                    <asp:Label ID="lblIdProducto" runat="server" Text='<%# Eval("DecIdProducto") %>' />-->
                                    <br />
                                    Producto :
                                    <asp:Label ID="lblNombreProducto" runat="server" Text='<%# Eval("StNombreProducto") %>' />
                                    <br />
                                    Precio :
                                    <asp:Label ID="lblPrecioProducto" runat="server" Text='<%# Eval("StPrecioProducto") %>' />
                                    <br />
                                    Stock :
                                    <asp:Label ID="lblStockProducto" runat="server" Text='<%# Eval("StStockProducto") %>' />
                                    <br />
                                    Descripción :
                                    <asp:Label ID="lblDescripcionProducto" runat="server" Text='<%# Eval("StDescripcionProducto") %>' />
                                    <br />
                                    <asp:Button ID="btnVerOfertas" runat="server" CssClass="btn btn-lg btn-success btn-block" CommandName="verOfertas" Text="Ver Ofertas" />
                                    <br />
                                </ItemTemplate>
                            </asp:DataList>  
                        </div>                      
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
