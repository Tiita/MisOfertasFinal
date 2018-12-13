using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Categoria
    {
        public Categoria()
        {
            this.coleccion_productos = new HashSet<Producto>();
        }

        public decimal id_categoria { get; set; }
        public string nombre_categoria { get; set; }
        public decimal id_rubro { get; set; }

        public virtual ICollection<Producto> coleccion_productos { get; set; }
        public virtual Rubro rubro { get; set; }
    }
}