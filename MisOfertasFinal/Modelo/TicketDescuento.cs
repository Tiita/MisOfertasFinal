namespace MisOfertasFinal.Modelo
{
    public class TicketDescuento
    {
        public decimal id_ticket { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_termino { get; set; }
        public decimal descuento_otorgado { get; set; }
        public byte[] codigo_barra { get; set; }
        public decimal tope { get; set; }
        public string rut_usuario { get; set; }

        public virtual Usuario usuario { get; set; }
    }
}