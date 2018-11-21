using MisOfertasFinal.Entidades;
using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Comuna
    {
        public decimal DecID_COMUNA { get; set; }
        public string StNOMBRE_COMUNA { get; set; }
        public decimal DecREGION_ID_REGION { get; set; }

        public REGION REGION { get; set; }
        public ICollection<TIENDA> TIENDA { get; set; }
        public ICollection<USUARIO> USUARIO { get; set; }
    }
}