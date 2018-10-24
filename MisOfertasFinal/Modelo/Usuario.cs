using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Usuario
    {
        public decimal DECIdUsuario { get; set; }
        public string STNombreUsuario { get; set; }
        public string STPatUsuario { get; set; }
        public string STMatUsuario { get; set; }
        public string STCorreoUsuario { get; set; }
        public string STRutUsuario { get; set; }
        public string STDirUsuario { get; set; }
        public string STFonoUsuario { get; set; }
        public string STPasswordUsuario { get; set; }
        public decimal DECPuntosUsuario { get; set; }
        public Comuna OComuna { get; set; }
        public Prioridad OPrioridad { get; set; }
        public TicketDescuento OTicketDescuento { get; set; }
        public Tienda OTienda { get; set; }
        public TipoUsuario OTipoUsuario { get; set; }
        public ICollection<Valoracion> CValoracion { get; set; }
    }
}