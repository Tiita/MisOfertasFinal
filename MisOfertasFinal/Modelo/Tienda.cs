using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Tienda
    {
        public Tienda()
        {
            this.coleccion_productos = new HashSet<Producto>();
        }

        public decimal id_tienda { get; set; }
        public string nombre_tienda { get; set; }
        public string direccion_tienda { get; set; }
        public string telefono_tienda { get; set; }
        public decimal id_comuna { get; set; }
        public decimal id_empresa { get; set; }
        public string rut_usuario { get; set; }

        public virtual Comuna comuna { get; set; }
        public virtual Empresa empresa { get; set; }
        public virtual Usuario usuario { get; set; }
        public virtual ICollection<Producto> coleccion_productos { get; set; }
    }
}