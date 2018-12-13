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
                                 id_producto = q.ID_PRODUCTO,
                                 nombre_producto = q.NOMBRE_PRODUCTO,
                                 precio_producto = q.PRECIO_PRODUCTO,
                                 stock_producto = q.STOCK_PRODUCTO,
                                 descripcion_producto = q.DESCRIPCION_PRODUCTO,
                                 imagen_producto = q.IMAGEN_PRODUCTO
                             }).ToList();
                return query;
            }
        }
    }
}