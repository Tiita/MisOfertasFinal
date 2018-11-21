﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrueba.aspx.cs" Inherits="MisOfertasFinal.Pruebas.frmPrueba" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Ofertas disponibles</title>
    <!-- Google font -->
    <link href="https://fonts.googleapis.com/css?family=Montserrat:400,500,700" rel="stylesheet" />
    <!-- Bootstrap -->
    <link type="text/css" rel="stylesheet" href="../Maqueta/css/bootstrap.min.css" />
    <!-- Slick -->
    <link type="text/css" rel="stylesheet" href="../Maqueta/css/slick.css" />
    <link type="text/css" rel="stylesheet" href="../Maqueta/css/slick-theme.css" />
    <!-- nouislider -->
    <link type="text/css" rel="stylesheet" href="../Maqueta/css/nouislider.min.css" />
    <!-- Font Awesome Icon -->
    <link rel="stylesheet" href="../Maqueta/css/font-awesome.min.css" />
    <!-- Custom stlylesheet -->
    <link type="text/css" rel="stylesheet" href="../Maqueta/css/style.css" />
    <script src="../Maqueta/js/jquery.min.js"></script>
	<script src="../Maqueta/js/bootstrap.min.js"></script>
	<script src="../Maqueta/js/slick.min.js"></script>
	<script src="../Maqueta/js/nouislider.min.js"></script>
	<script src="../Maqueta/js/jquery.zoom.min.js"></script>
	<script src="../Maqueta/js/main.js"></script>
</head>
<body>
    <!--CABECERA-->
    <header>
        <!--CABECERA ARRIBA-->
        <div id="top-header">
            <div class="container">
                <!--Navegación-->
                <ul class="header-links pull-right">
                    <li class="nav-item">
                        <asp:Label ID="lblUsuario" runat="server" CssClass="nav-link active" ForeColor="White" Text="">Usuario
                                <i class="fa fa-user fa-fw"></i>
                        </asp:Label>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link" href="#">Salir
                                <i class="fa fa-sign-out fa-fw"></i>
                        </a>
                    </li>
                </ul>
                <!--Navegación-->
            </div>
        </div>
        <!--CABECERA ARRIBA-->
        <!--CABECERA PRINCIPAL-->
        <div id="header">
            <!--Contenedor-->
            <div class="container">
                <!--Fila-->
                <div class="row">
                        <!--Logo-->
                        <div class="col-md-3">
                            <div class="header-logo">
                                <a href="#" class="Logo">
                                    <img src="../Imagenes/iconocompleto.png" height="60" alt="" />
                                </a>
                            </div>
                        </div>
                        <!--Logo-->
                </div>                
                <!--Fila-->
            </div>
            <!--Contenedor-->
        </div>
        <!--CABECERA PRINCIPAL-->
    </header>
    <!-- CABECERA-->
    <!-- MENU NAVEGACION -->
    <nav id="navigation">
        <!--CONTENEDOR-->
        <div class="container">
            <!--COMPONENTE NAV RESPONSIVO-->
            <div id="responsive-nav">
					<!-- COMPONENTE NAV -->
					<ul class="main-nav nav navbar-nav">
						<li class="active"><a href="#">Inicio</a></li>
						<li><a href="#">Consultar puntos</a></li>
						<li><a href="#">Generar ticket de descuento</a></li>						
					</ul>
					<!-- COMPONENTE NAV -->
				</div>
            <!--COMPONENTE NAV RESPONSIVO-->
        </div>
        <!--CONTENEDOR-->
    </nav>
    <!-- MENU NAVEGACION -->
    <!--PIE DE PAGINA-->
		<footer id="footer">
			<!--PIE DE PAGINA ARRIBA-->
			<div class="section">
				<!--CONTENEDOR-->
				<div class="container">
					<!--FILA-->
					<div class="row">
						<div class="col-md-3 col-xs-6">
							<div class="footer">
								<h3 class="footer-title">Acerca de nosotros</h3>
								<p>Plataforma encargada de gestionar ofertas dentro de todo el país.</p>
								<ul class="footer-links">
									<li><a href="#"><i class="fa fa-map-marker"></i>Viña del Mar</a></li>
									<li><a href="#"><i class="fa fa-phone"></i>+322-55-55-55</a></li>
									<li><a href="#"><i class="fa fa-envelope-o"></i>misOfertas@email.com</a></li>
								</ul>
							</div>
						</div>

						<div class="col-md-3 col-xs-6">
							<div class="footer">
								<h3 class="footer-title">Categorias</h3>
								<ul class="footer-links">
									<li><a href="#">Inicio</a></li>
									<li><a href="#">Consultar puntos</a></li>
									<li><a href="#">Generar ticket de descuento</a></li>									
								</ul>
							</div>
						</div>
						<div class="clearfix visible-xs"></div>
					</div>
					<!-- /FILA-->
				</div>
				<!-- /CONTENEDOR -->
			</div>
			<!-- /PIE DE PAGINA ARRIBA-->

			<!-- bottom footer -->
			<div id="bottom-footer" class="section">
				<div class="container">
					<!-- FILA -->
					<div class="row">
						<div class="col-md-12 text-center">
							<span class="copyright">
								Copyright &copy;<script>document.write(new Date().getFullYear());</script> Todos los derechos reservados Mis Ofertas
							</span>
						</div>
					</div>
						<!-- /FILA -->
				</div>
				<!-- /container -->
			</div>
			<!-- /bottom footer -->
		</footer>
		<!--/PIE DE PAGINA-->
</body>
</html>