//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisOfertasFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class VALORACION
    {
        public decimal ID_VALORACION { get; set; }
        public decimal CALIFICACION { get; set; }
        public byte[] IMAGENBOLETA { get; set; }
        public decimal NUMERO_BOLETA { get; set; }
        public Nullable<decimal> USUARIO_ID_USUARIO { get; set; }
        public Nullable<decimal> OFERTA_ID_OFERTA { get; set; }
    
        public virtual OFERTA OFERTA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
