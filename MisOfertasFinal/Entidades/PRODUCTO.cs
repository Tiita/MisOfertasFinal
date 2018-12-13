//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MisOfertasFinal.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.OFERTA = new HashSet<OFERTA>();
            this.TIENDA = new HashSet<TIENDA>();
        }
    
        public decimal ID_PRODUCTO { get; set; }
        public string NOMBRE_PRODUCTO { get; set; }
        public decimal PRECIO_PRODUCTO { get; set; }
        public decimal STOCK_PRODUCTO { get; set; }
        public string DESCRIPCION_PRODUCTO { get; set; }
        public byte[] IMAGEN_PRODUCTO { get; set; }
        public decimal ID_MARCA { get; set; }
        public decimal ID_CATEGORIA { get; set; }
        public Nullable<decimal> ID_OFERTA { get; set; }
        public decimal ID_TIENDA { get; set; }
    
        public virtual CATEGORIA CATEGORIA { get; set; }
        public virtual MARCA MARCA { get; set; }
        public virtual ICollection<OFERTA> OFERTA { get; set; }
        public virtual OFERTA OFERTA1 { get; set; }
        public virtual ICollection<TIENDA> TIENDA { get; set; }
    }
}
