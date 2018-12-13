using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Region
    {
        public Region()
        {
            this.coleccion_comunas = new HashSet<Comuna>();
        }

        public decimal id_region { get; set; }
        public string nombre_region { get; set; }

        public virtual ICollection<Comuna> coleccion_comunas { get; set; }
    }
}