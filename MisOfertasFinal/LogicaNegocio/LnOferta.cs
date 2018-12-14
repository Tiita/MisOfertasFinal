using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnOferta
    {
        public List<OFERTA> GetListadoOfertas()
        {
            using (Entities obEntitiesOfertas = new Entities())
            {
                var query = from q in obEntitiesOfertas.OFERTA.Include("PRODUCTO1").Include("VALORACION")
                            select q;
                return query.ToList();
            }
        }


        public string CargaOfertas()
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
                             {   prod.ID_PRODUCTO,
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
                   // html.Append("<p><strong> Compra minima: " + item.MINIMO_PRO + " &nbsp; &nbsp; &nbsp; Compra Maxima: " + item.MAXIMO_PRO + " </strong> &nbsp; </p>");
                    //html.Append("<p><strong> Stock en tienda: " + item.STOCK_PRODUCTO + " </strong> &nbsp; &nbsp; <strong> vence el " + item.FECHA_LIMITE + "</strong></p>");
                    html.Append("<p><strong > $" + (precioIni - (precioIni * porFin)) + " </strong> &nbsp; <del>$" + precioIni + "</del> &nbsp; <strong> " + porcDesc + "% de descuento </strong></p>");
                    html.Append("<p><a href = \"../VerOferta/VerOferta.aspx?Valor=" + item.ID_PRODUCTO+"\"  title = \"Ver producto\"> Ver Oferta </a></p>");
                    html.Append("</td>");
                    if (contadorSalto == 2)
                    {
                        html.Append("</tr>");
                        contadorSalto = 0;
                    }
                    contadorSalto++;
                }

                html.Append("</table>");
            }
            return html.ToString();
        }

    }
}