using MisOfertasFinal.Entidades;
using System.Collections.Generic;

namespace MisOfertasFinal.Modelo
{
    public class Usuario
    {

        public string StRUT_USUARIO { get; set; }
        public string StNOMBRE_USUARIO { get; set; }
        public string StAPEPA_USUARIO { get; set; }
        public string StAPEMA_USUARIO { get; set; }
        public string StCORREO_USUARIO { get; set; }
        public string StDIRECCION_USUARIO { get; set; }
        public string StTELEFONO_USUARIO { get; set; }
        public string StPASSWORD_USUARIO { get; set; }
        public string StCORREOACTIVO { get; set; }
        public decimal DecPUNTOS_USUARIO { get; set; }
        public decimal DecID_TIPOUSUARIO { get; set; }
        public decimal DecID_COMUNA { get; set; }


        public COMUNA COMUNA { get; set; }
        public ICollection<PRIORIDAD> PRIORIDAD { get; set; }
        public ICollection<TICKETDESCUENTO> TICKETDESCUENTO { get; set; }
        public ICollection<TIENDA> TIENDA { get; set; }
        public TIPOUSUARIO TIPOUSUARIO { get; set; }
        public ICollection<VALORACION> VALORACION { get; set; }
        
    }
}