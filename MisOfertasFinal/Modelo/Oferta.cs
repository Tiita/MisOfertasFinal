using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Oferta
    {
        public Oferta()
        {
            this.coleccion_productos = new HashSet<Producto>();
            this.coleccion_valoraciones = new HashSet<Valoracion>();
        }

        public decimal id_oferta { get; set; }
        public decimal maximo_pro { get; set; }
        public decimal minimo_pro { get; set; }
        public System.DateTime fecha_limite { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public decimal porcentaje_descuento { get; set; }
        public decimal id_producto { get; set; }

        public virtual Producto producto { get; set; }
        public virtual ICollection<Producto> coleccion_productos { get; set; }
        public virtual ICollection<Valoracion> coleccion_valoraciones { get; set; }
    }
}