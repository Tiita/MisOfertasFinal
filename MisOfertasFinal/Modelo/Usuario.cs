using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Usuario
    {

        public Usuario()
        {
            this.coleccion_prioridades = new HashSet<Prioridad>();
            this.coleccion_tickets = new HashSet<TicketDescuento>();
            this.coleccion_tiendas = new HashSet<Tienda>();
            this.coleccion_valoraciones = new HashSet<Valoracion>();
        }

        public string rut_usuario { get; set; }
        public string nombre_usuario { get; set; }
        public string apepa_usuario { get; set; }
        public string apema_usuario { get; set; }
        public string correo_usuario { get; set; }
        public string direccion_usuario { get; set; }
        public string telefono_usuario { get; set; }
        public string password_usuario { get; set; }
        public string correoactivo { get; set; }
        public decimal puntos_usuario { get; set; }
        public decimal id_tipoUsuario { get; set; }
        public decimal id_comuna { get; set; }

        public virtual Comuna comuna { get; set; }
        public virtual ICollection<Prioridad> coleccion_prioridades { get; set; }
        public virtual ICollection<TicketDescuento> coleccion_tickets { get; set; }
        public virtual ICollection<Tienda> coleccion_tiendas { get; set; }
        public virtual TipoUsuario tipoUsuario { get; set; }
        public virtual ICollection<Valoracion> coleccion_valoraciones { get; set; }

    }
}