namespace MisOfertasFinal.Modelo
{
    public class Valoracion
    {
        public decimal id_valoracion { get; set; }
        public decimal calificacion { get; set; }
        public byte[] imagen_boleta { get; set; }
        public decimal numero_boleta { get; set; }
        public decimal id_oferta { get; set; }
        public string rut_usuario { get; set; }

        public virtual Oferta oferta { get; set; }
        public virtual Usuario usuario { get; set; }
    }
}