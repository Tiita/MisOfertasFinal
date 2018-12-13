using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using MisOfertasFinal.Entidades;
using System.Data;
using System.Linq;
using System.Text;
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
                CargarRubros();
                CargarMarcas();                
                ddlCategoria.Items.Insert(0, new ListItem("Categoría", "0"));
                ddlRubro.Items.Insert(0, new ListItem("Rubro", "0"));
                ddlMarca.Items.Insert(0, new ListItem("Marca", "0"));
                CargaOfertas();
                

            }
        }
        #region Marcas        
        public void CargarMarcas() {
            LogicaNegocio.LnMarca objLnMarca = new LogicaNegocio.LnMarca();
            List<Modelo.Marca> lstMarcas = objLnMarca.GetListadoMarcas();
            ddlMarca.DataSource = lstMarcas;
            ddlMarca.DataTextField = "nombre_marca";
            ddlMarca.DataValueField = "id_marca";
            ddlMarca.DataBind();            
        }
        #endregion

        #region Rubros
        public void CargarRubros() {
            LogicaNegocio.LnRubro objLnRubro = new LogicaNegocio.LnRubro();
            List<Modelo.Rubro> lstRubros = objLnRubro.GetListadoRubros();
            ddlRubro.DataSource = lstRubros;
            ddlRubro.DataTextField = "nombre_rubro";
            ddlRubro.DataValueField = "id_rubro";
            ddlRubro.DataBind();            
        }
        #endregion
        #region Categorias
        public void CargarCategorias(decimal id_rubro) {
            LogicaNegocio.LnCategoria objLnCategoria = new LogicaNegocio.LnCategoria();
            List<Modelo.Categoria> lstCategorias = objLnCategoria.GetListadoCategorias(id_rubro);
            ddlCategoria.DataSource = lstCategorias;
            ddlCategoria.DataTextField = "nombre_categoria";
            ddlCategoria.DataValueField = "id_categoria";
            ddlCategoria.DataBind();            
        }
        #endregion
        #region eventos rubros
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
        #endregion

        public void CargaOfertas()
        {
            StringBuilder html = new StringBuilder();
            int contadorSalto = 0; //este es un contador usado para ver cada cuantos productos se saltara la siguente fila
            using (Entities objOfertas = new Entities())
            {

                var query = (from ofer in objOfertas.OFERTA
                             join prod in objOfertas.PRODUCTO on ofer.ID_PRODUCTO equals prod.ID_PRODUCTO
                             join mrc in objOfertas.MARCA on prod.ID_MARCA equals mrc.ID_MARCA
                             join cat in objOfertas.CATEGORIA on prod.ID_CATEGORIA equals cat.ID_CATEGORIA
                             orderby cat.ID_CATEGORIA
                             select new
                             {
                                 prod.NOMBRE_PRODUCTO,
                                 prod.PRECIO_PRODUCTO,
                                 prod.STOCK_PRODUCTO,
                                 ofer.MINIMO_PRO,
                                 ofer.MAXIMO_PRO,
                                 ofer.PORCENTAJE_DESCUENTO,
                                 mrc.NOMBRE_MARCA,
                                 ofer.FECHA_LIMITE,
                                 prod.IMAGEN_PRODUCTO
                             }).ToList();


                //GW_OfertasProductos.DataSourceID = null;
                //GW_OfertasProductos.DataSource = query;
                //GW_OfertasProductos.DataBind();
                html.Append("<table>");

                foreach (var item in query)
                {
                    if (contadorSalto == 0)
                    {
                        html.Append("<tr>");
                    }
                    html.Append("<td>");
                    decimal precioIni = Decimal.ToInt32(item.PRECIO_PRODUCTO);
                    int porcDesc = Decimal.ToInt32(item.PORCENTAJE_DESCUENTO);
                    decimal porFin = porcDesc / 100;
                    decimal precioFin = precioIni - (precioIni * porFin);

                    byte[] imagen = item.IMAGEN_PRODUCTO;


                    html.Append("<p> <img alt=\"\" src=\"" + imagen + "\" /> </p>");
                    html.Append("<h4><a title = \"Ver más información sobre el portátil\"> " + item.NOMBRE_PRODUCTO + "</a></h4>");
                    html.Append("<p><strong> Compra minima: " + item.MINIMO_PRO + " &nbsp; &nbsp; &nbsp; Compra Maxima: " + item.MAXIMO_PRO + " </strong> &nbsp; </p>");
                    html.Append("<p><strong> Stock en tienda: " + item.STOCK_PRODUCTO + " </strong> &nbsp; &nbsp; <strong> vence el " + item.FECHA_LIMITE + "</strong></p>");
                    html.Append("<p><strong > $" + (precioIni - (precioIni * porFin)) + " </strong> &nbsp; <del>$" + precioIni + "</del> &nbsp; <strong> " + porcDesc + "% de descuento </strong></p>");
                    html.Append("<p><a href = \"../../Views/Valoracion.aspx\"  title = \"Comprar el portátil\"> Valorar oferta </a></p>");
                    html.Append("</td>");


                    if (contadorSalto == 2)
                    {
                        html.Append("</tr>");
                        contadorSalto = 0;
                    }
                    contadorSalto++;

                }

                html.Append("</table>");
                pruebadiv.Controls.Add(new Literal { Text = html.ToString() });

            }
        }


    }
}