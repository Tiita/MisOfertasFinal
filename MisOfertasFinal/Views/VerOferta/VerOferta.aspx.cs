using MisOfertasFinal.Entidades;
using MisOfertasFinal.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.VerOferta
{
    public partial class VerOferta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Valor = Request.QueryString["valor"];

            if (!IsPostBack)
            {
                if (Session["consumidorEmail"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }
                if (Valor == null)
                {
                    Response.Redirect("../Index/Index.aspx");
                }



                preciofinal.Text = Valor;
                CargaOtrasOfertas();
                CargaOfertaVista(decimal.Parse(Valor));
            }



        }

        public void CargaOtrasOfertas()
        {
            LnOferta ofertas = new LnOferta();
            pruebadiv.Controls.Add(new Literal { Text = ofertas.CargaOfertas() });

        }

        public void CargaOfertaVista(decimal idProd)
        {
            using (Entities objOfertas = new Entities())
            {

                var query = (from ofer in objOfertas.OFERTA
                             join prod in objOfertas.PRODUCTO on ofer.ID_PRODUCTO equals prod.ID_PRODUCTO
                             join mrc in objOfertas.MARCA on prod.ID_MARCA equals mrc.ID_MARCA
                             join cat in objOfertas.CATEGORIA on prod.ID_CATEGORIA equals cat.ID_CATEGORIA
                             where prod.ID_PRODUCTO == idProd
                             orderby cat.ID_CATEGORIA
                             select new
                             {
                                 cat.NOMBRE_CATEGORIA,
                                 prod.ID_PRODUCTO,
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

               
                foreach (var item in query)
                {
                    nombreproducto.Text = item.NOMBRE_PRODUCTO ;
                    porcentajeDescuento.Text = item.PORCENTAJE_DESCUENTO+"%";
                    precioviejo.Text = " $"+item.PRECIO_PRODUCTO;
                    nombreCategoria.Text = item.NOMBRE_CATEGORIA;
                    preciofinal.Text = " $"+item.PRECIO_PRODUCTO;

                }
            }//fin del using

            




        }





    }


}