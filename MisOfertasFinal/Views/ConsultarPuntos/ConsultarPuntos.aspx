<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="ConsultarPuntos.aspx.cs" Inherits="MisOfertasFinal.Views.ConsultarPuntos.ConsultarPuntos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <div class="container">
        <p style="text-align:center">Estimado Señor(a) <asp:Label ID="lblNombre" runat="server" Font-Bold="True" ></asp:Label>, usted tiene <asp:Label ID="lblPuntos" runat="server" Font-Bold="True"></asp:Label> acumalos a la fecha.</p>
        <div class="table-responsive">
            <table class="table">
                <tbody>
                    <tr>
                        <td colspan="3" style="text-align:center"><asp:Label ID="lblTituloCupon" runat="server" Text="Cupón de Descuento" Font-Bold="true"></asp:Label></td>
                    </tr>
                    <tr>
                        <td rowspan="7">
                            <asp:Image ID="imgQr" runat="server" />
                        </td>
                        <td>Nombre:</td>
                        <td><asp:Label ID="lblNombreCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>RUT:</td>
                        <td><asp:Label ID="lblRutCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Puntos:</td>
                        <td><asp:Label ID="lblPuntosCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Descuento:</td>
                        <td><asp:Label ID="lblDescuentoCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Rubro:</td>
                        <td><asp:Label ID="lblRubroCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Máximo Descuento:</td>
                        <td><asp:Label ID="lblMaxCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                    <tr>
                        <td>Fecha expiración:</td>
                        <td><asp:Label ID="lblFechaCupon" runat="server" Font-Bold="True" ></asp:Label></td>
                    </tr>
                     <tr>
                        <td colspan="3"><asp:Button ID="btnDescargar" runat="server" Text="Descargar Cupón"  CssClass="btn btn-lg btn-danger btn-block" OnClick="btnDescargar_Click"/></td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>
     
    
    
    
    
</asp:Content>
