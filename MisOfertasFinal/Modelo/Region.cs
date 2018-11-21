using MisOfertasFinal.Entidades;
using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Region
    {
        public decimal DecID_REGION { get; set; }
        public string StNOMBRE_REGION { get; set; }

        public ICollection<COMUNA> COMUNA { get; set; }
    }
}