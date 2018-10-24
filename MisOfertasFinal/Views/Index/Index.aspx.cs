using System;
using System.Collections.Generic;

namespace MisOfertasFinal.Views.Index
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["consumidorEmail"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }

                Controllers.IndexController obIndexController = new Controllers.IndexController();

                List<Modelo.Rubro> lstRubros = obIndexController.GetRubroController();
                ddlRubro.DataSource = lstRubros;
                ddlRubro.DataTextField = "STNombreRubro";
                ddlRubro.DataValueField = "DECIdRubro";
                ddlRubro.DataBind();

                List<Modelo.Categoria> lstCategorias = obIndexController.GetCategoriaController();
                ddlCategoria.DataSource = lstCategorias;
                ddlCategoria.DataTextField = "STNombreCategoriaProducto";
                ddlCategoria.DataValueField = "DECIdCategoriaProducto";
                ddlCategoria.DataBind();

                List<Modelo.Marca> lstMarcas = obIndexController.GetMarcaController();
                ddlMarca.DataSource = lstMarcas;
                ddlMarca.DataTextField = "STNombreMarca";
                ddlMarca.DataValueField = "DECIdMarca";
                ddlMarca.DataBind();

                List<Modelo.Producto> lstProductos = obIndexController.GetProductoController();
                dlstProductos.DataSource = lstProductos;
                dlstProductos.DataBind();

            }
        }
    }
}