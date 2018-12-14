using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using MisOfertasFinal.Entidades;
using System.Data;
using System.Linq;
using System.Text;
using MisOfertasFinal.LogicaNegocio;

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
                CargaOfertas();
            }
            else
            {
                ddlCategoria.Items.Insert(0,new ListItem("Categoría","0"));
                
            }
        }
        #endregion

        public void CargaOfertas()
        {
            LnOferta ofertas = new LnOferta();
            pruebadiv.Controls.Add(new Literal { Text = ofertas.CargaOfertas() });

            }



        }


    }
