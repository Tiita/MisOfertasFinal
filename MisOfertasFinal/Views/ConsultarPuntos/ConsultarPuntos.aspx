<%@ Page Title="" Language="C#" MasterPageFile="~/Resources/Template/Template.Master" AutoEventWireup="true" CodeBehind="ConsultarPuntos.aspx.cs" Inherits="MisOfertasFinal.Views.ConsultarPuntos.ConsultarPuntos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenedor" runat="server">
    <p style="text-align:center">Estimado Señor(a) <asp:Label ID="lblNombre" runat="server" Font-Bold="True" ></asp:Label>, usted tiene <asp:Label ID="lblPuntos" runat="server" Font-Bold="True"></asp:Label> acumalos a la fecha.</p>
    <asp:Button ID="btnDescargar" runat="server" Text="Descargar Cupón"  CssClass="btn btn-lg btn-danger btn-block" OnClick="btnDescargar_Click"/>
</asp:Content>
