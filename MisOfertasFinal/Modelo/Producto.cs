using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Producto
    {
        public Producto() { }

        public decimal DecIdProducto { get; set; }
        public string StNombreProducto { get; set; }
        public decimal StPrecioProducto { get; set; }
        public decimal StStockProducto { get; set; }
        public string StDescripcionProducto { get; set; }
        public byte[] BytImagenProducto { get; set; }
        public decimal DecIdRubroProducto { get; set; }
        public decimal DecIdMarcaProducto { get; set; }
        public decimal DecIdCategoriaProducto { get; set; }
        public decimal DecIdOfertaProducto { get; set; }
    }
}