using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

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

                CargarMarcas();
                CargarRubros();
                ddlCategoria.Items.Insert(0, new ListItem("Categoría", "0"));
                LogicaNegocio.LnProducto objLnProducto = new LogicaNegocio.LnProducto();
                List<Modelo.Producto> lstProductos = objLnProducto.GetListadoProductos();
                //dlstProductos.DataSource = lstProductos;
                //dlstProductos.DataBind();

            }
        }

        public void CargarMarcas() {
            LogicaNegocio.LnMarca objLnMarca = new LogicaNegocio.LnMarca();
            List<Modelo.Marca> lstMarcas = objLnMarca.GetListadoMarcas();
            ddlMarca.DataSource = lstMarcas;
            ddlMarca.DataTextField = "STNombreMarca";
            ddlMarca.DataValueField = "DECIdMarca";
            ddlMarca.DataBind();
            ddlMarca.Items.Insert(0, new ListItem("Marca", "0"));
        }

        public void CargarRubros() {
            LogicaNegocio.LnRubro objLnRubro = new LogicaNegocio.LnRubro();
            List<Modelo.Rubro> lstRubros = objLnRubro.GetListadoRubros();
            ddlRubro.DataSource = lstRubros;
            ddlRubro.DataTextField = "STNombreRubro";
            ddlRubro.DataBind();
            ddlRubro.Items.Insert(0,new ListItem("Rubro","0"));
        }

        public void CargarCategorias(decimal DecIdcategoria) {
            LogicaNegocio.LnCategoria objLnCategoria = new LogicaNegocio.LnCategoria();
            List<Modelo.Categoria> lstCategorias = objLnCategoria.GetListadoCategorias(DecIdcategoria);
            ddlCategoria.DataSource = lstCategorias;
            ddlCategoria.DataTextField = "STNombreCategoriaProducto";
            ddlCategoria.DataBind();
            ddlCategoria.Items.Insert(0, new ListItem("Categoría", "0"));
        }

        protected void ddlRubro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddlRubro.SelectedValue))
            {
                CargarCategorias(int.Parse(ddlRubro.SelectedValue));
            }
            else
            {
                ddlCategoria.Items.Insert(0,new ListItem("Categoría","0"));
            }
        }
    }
}