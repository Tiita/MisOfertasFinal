namespace MisOfertasFinal.Modelo
{
    public class Correo
    {
        public string servidor { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public bool conexionSegura { get; set; }
        public bool autenticacion { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public string asunto { get; set; }
        public string mensaje { get; set; }
        public int tipo { get; set; }
        public int prioridad { get; set; }
        public string puerto { get; set; }
        public string imagen { get; set; }
        public string idImagen { get; set; }
    }
}