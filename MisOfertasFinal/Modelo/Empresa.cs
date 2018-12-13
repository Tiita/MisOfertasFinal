using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Empresa
    {
        public Empresa()
        {
            this.coleccion_tiendas = new HashSet<Tienda>();
        }

        public decimal id_empresa { get; set; }
        public string nombre_empresa { get; set; }
        public string rut_empresa { get; set; }
        public string giro { get; set; }

        public virtual ICollection<Tienda> coleccion_tiendas { get; set; }
    }
}