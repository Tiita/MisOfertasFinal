using System;
using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Producto
    {
        public Producto()
        {
            this.coleccion_ofertas = new HashSet<Oferta>();
            this.coleccion_tiendas = new HashSet<Tienda>();
        }

        public decimal id_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_producto { get; set; }
        public decimal stock_producto { get; set; }
        public string descripcion_producto { get; set; }
        public byte[] imagen_producto { get; set; }
        public decimal id_marca { get; set; }
        public decimal id_categoria { get; set; }
        public Nullable<decimal> id_oferta { get; set; }
        public decimal id_tienda { get; set; }

        public virtual Categoria categoria { get; set; }
        public virtual Marca marca { get; set; }
        public virtual ICollection<Oferta> coleccion_ofertas { get; set; }
        public virtual Oferta oferta { get; set; }
        public virtual ICollection<Tienda> coleccion_tiendas { get; set; }
    }
}