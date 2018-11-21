using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnProducto
    {
        public List<Modelo.Producto> GetListadoProductos()
        {
            using (Entities obEntitiesOfertas = new Entities())
            {

                var query = (from q in obEntitiesOfertas.PRODUCTO
                             select new Modelo.Producto
                             {
                                 DecIdProducto = q.ID_PRODUCTO,
                                 StNombreProducto = q.NOMBRE_PRODUCTO,
                                 StPrecioProducto = q.PRECIO_PRODUCTO,
                                 StStockProducto = q.STOCK_PRODUCTO,
                                 StDescripcionProducto = q.DESCRIPCION_PRODUCTO,
                                 BytImagenProducto = q.IMAGEN_PRODUCTO
                             }).ToList();
                return query;
            }
        }
    }
}