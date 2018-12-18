<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmPrueba.aspx.cs" Inherits="MisOfertasFinal.Pruebas.frmPrueba" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Star Rating Widget</title>

    <link rel="stylesheet" href="../Maqueta/estrella/demo/styles.css"/>

</head>
<body>
    <h2>Califica</h2>						
				<form class="form-1">				
				<div class="form-field">
					<select id="glsr-ltr" class="star-rating">
						<option value="">Califica el producto</option>
						<option value="5">Fantastico</option>
						<option value="4">Grandioso</option>
						<option value="3">Bueno</option>
						<option value="2">Pobre</option>
						<option value="1">Terrible</option>
					</select>
				</div>			
				
			</form>	
				
		

	<script src="../Maqueta/estrella/src/star-rating.js?ver=3.1.1"></script>
	<script>
		var destroyed = false;
		var starratings = new StarRating( '.star-rating', {
			onClick: function( el ) {
				console.log( 'Selected: ' + el[el.selectedIndex].text );
			},
		});
		document.querySelector( '.toggle-star-rating' ).addEventListener( 'click', function() {
			if( !destroyed ) {
				starratings.destroy();
				destroyed = true;
			}
			else {
				starratings.rebuild();
				destroyed = false;
			}
		});
	</script>

</body>
</html>

