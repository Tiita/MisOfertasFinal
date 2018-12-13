using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Marca
    {
        public Marca()
        {
            this.coleccion_productos = new HashSet<Producto>();
        }

        public decimal id_marca { get; set; }
        public string nombre_marca { get; set; }

        public virtual ICollection<Producto> coleccion_productos { get; set; }
    }
}