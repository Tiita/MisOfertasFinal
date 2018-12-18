using MisOfertasFinal.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.VerOferta
{
    public partial class VerOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["consumidorEmail"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }
                if (Session["Oferta"]==null) {
                    Response.Redirect("../Index/Index.aspx");
                }
                List<Modelo.Ofertas> data=(List<Modelo.Ofertas>)Session["Oferta"];
                dtlOferta.DataSource = data;
                dtlOferta.DataBind();
                ObtenerProductosRelacionados();
                
            }
        }

       
        public void ObtenerProductosRelacionados()
        {
            LogicaNegocio.LnOferta objLnOferta = new LnOferta();
            dtlProRelacionados.DataSource = objLnOferta.getOfertasProductos();
            dtlProRelacionados.DataBind();
        }

        protected void dtlProRelacionados_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
        {
            decimal codProducto, codOferta;
            if (e.CommandName == "Seleccionar")
            {
                dtlProRelacionados.SelectedIndex = e.Item.ItemIndex;
                codOferta = Convert.ToDecimal(((Label)this.dtlProRelacionados.SelectedItem.FindControl("lblCodigoOferta")).Text);
                codProducto = Convert.ToDecimal(((Label)this.dtlProRelacionados.SelectedItem.FindControl("lblCodigoProducto")).Text);

                LogicaNegocio.LnOferta objOferta = new LnOferta();
                List<Modelo.Ofertas> resultado = objOferta.GetOfertaEspecifica(codOferta, codProducto);
                Session["Oferta"] = resultado;
                Response.Redirect("../VerOferta/VerOferta.aspx");
            }
        }

        protected void dtlOferta_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName== "RegistrarValoracion")
            {

            }
        }
       


    }
}