using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Rubro
    {
        public Rubro()
        {
            this.coleccion_categorias = new HashSet<Categoria>();
        }

        public decimal id_rubro { get; set; }
        public string nombre_rubro { get; set; }
        public string descripcion { get; set; }

        public virtual ICollection<Categoria> coleccion_categorias { get; set; }
    }
}