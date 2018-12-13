using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Prioridad
    {
        public decimal id_prioridad { get; set; }
        public decimal producto_1 { get; set; }
        public decimal producto_2 { get; set; }
        public string rut_usuario { get; set; }

        public virtual Usuario usuario { get; set; }
    }
}