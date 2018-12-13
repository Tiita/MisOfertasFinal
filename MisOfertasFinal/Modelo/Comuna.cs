using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Comuna
    {
        public Comuna()
        {
            this.coleccion_tiendas = new HashSet<Tienda>();
            this.coleccion_usuarios = new HashSet<Usuario>();
        }

        public decimal id_comuna { get; set; }
        public string nombre_comuna { get; set; }
        public decimal id_region { get; set; }

        public virtual Region region { get; set; }
        public virtual ICollection<Tienda> coleccion_tiendas { get; set; }
        public virtual ICollection<Usuario> coleccion_usuarios { get; set; }
    }
}