﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Core.Objects;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CATEGORIA> CATEGORIA { get; set; }
        public DbSet<COMUNA> COMUNA { get; set; }
        public DbSet<EMPRESA> EMPRESA { get; set; }
        public DbSet<MARCA> MARCA { get; set; }
        public DbSet<OFERTA> OFERTA { get; set; }
        public DbSet<PRIORIDAD> PRIORIDAD { get; set; }
        public DbSet<PRODUCTO> PRODUCTO { get; set; }
        public DbSet<REGION> REGION { get; set; }
        public DbSet<RUBRO> RUBRO { get; set; }
        public DbSet<TICKETDESCUENTO> TICKETDESCUENTO { get; set; }
        public DbSet<TIENDA> TIENDA { get; set; }
        public DbSet<TIPOUSUARIO> TIPOUSUARIO { get; set; }
        public DbSet<USUARIO> USUARIO { get; set; }
        public DbSet<VALORACION> VALORACION { get; set; }
    
        public virtual int USUARIO_TAPI_INS(Nullable<decimal> p_ID_TIPOUSUARIO, string p_DIRECCION_USUARIO, string p_CORREOACTIVO, string p_APEPA_USUARIO, string p_NOMBRE_USUARIO, string p_RUT_USUARIO, string p_CORREO_USUARIO, string p_APEMA_USUARIO, Nullable<decimal> p_PUNTOS_USUARIO, string p_TELEFONO_USUARIO, Nullable<decimal> p_ID_COMUNA, string p_PASSWORD_USUARIO)
        {
            var p_ID_TIPOUSUARIOParameter = p_ID_TIPOUSUARIO.HasValue ?
                new ObjectParameter("P_ID_TIPOUSUARIO", p_ID_TIPOUSUARIO) :
                new ObjectParameter("P_ID_TIPOUSUARIO", typeof(decimal));
    
            var p_DIRECCION_USUARIOParameter = p_DIRECCION_USUARIO != null ?
                new ObjectParameter("P_DIRECCION_USUARIO", p_DIRECCION_USUARIO) :
                new ObjectParameter("P_DIRECCION_USUARIO", typeof(string));
    
            var p_CORREOACTIVOParameter = p_CORREOACTIVO != null ?
                new ObjectParameter("P_CORREOACTIVO", p_CORREOACTIVO) :
                new ObjectParameter("P_CORREOACTIVO", typeof(string));
    
            var p_APEPA_USUARIOParameter = p_APEPA_USUARIO != null ?
                new ObjectParameter("P_APEPA_USUARIO", p_APEPA_USUARIO) :
                new ObjectParameter("P_APEPA_USUARIO", typeof(string));
    
            var p_NOMBRE_USUARIOParameter = p_NOMBRE_USUARIO != null ?
                new ObjectParameter("P_NOMBRE_USUARIO", p_NOMBRE_USUARIO) :
                new ObjectParameter("P_NOMBRE_USUARIO", typeof(string));
    
            var p_RUT_USUARIOParameter = p_RUT_USUARIO != null ?
                new ObjectParameter("P_RUT_USUARIO", p_RUT_USUARIO) :
                new ObjectParameter("P_RUT_USUARIO", typeof(string));
    
            var p_CORREO_USUARIOParameter = p_CORREO_USUARIO != null ?
                new ObjectParameter("P_CORREO_USUARIO", p_CORREO_USUARIO) :
                new ObjectParameter("P_CORREO_USUARIO", typeof(string));
    
            var p_APEMA_USUARIOParameter = p_APEMA_USUARIO != null ?
                new ObjectParameter("P_APEMA_USUARIO", p_APEMA_USUARIO) :
                new ObjectParameter("P_APEMA_USUARIO", typeof(string));
    
            var p_PUNTOS_USUARIOParameter = p_PUNTOS_USUARIO.HasValue ?
                new ObjectParameter("P_PUNTOS_USUARIO", p_PUNTOS_USUARIO) :
                new ObjectParameter("P_PUNTOS_USUARIO", typeof(decimal));
    
            var p_TELEFONO_USUARIOParameter = p_TELEFONO_USUARIO != null ?
                new ObjectParameter("P_TELEFONO_USUARIO", p_TELEFONO_USUARIO) :
                new ObjectParameter("P_TELEFONO_USUARIO", typeof(string));
    
            var p_ID_COMUNAParameter = p_ID_COMUNA.HasValue ?
                new ObjectParameter("P_ID_COMUNA", p_ID_COMUNA) :
                new ObjectParameter("P_ID_COMUNA", typeof(decimal));
    
            var p_PASSWORD_USUARIOParameter = p_PASSWORD_USUARIO != null ?
                new ObjectParameter("P_PASSWORD_USUARIO", p_PASSWORD_USUARIO) :
                new ObjectParameter("P_PASSWORD_USUARIO", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USUARIO_TAPI_INS", p_ID_TIPOUSUARIOParameter, p_DIRECCION_USUARIOParameter, p_CORREOACTIVOParameter, p_APEPA_USUARIOParameter, p_NOMBRE_USUARIOParameter, p_RUT_USUARIOParameter, p_CORREO_USUARIOParameter, p_APEMA_USUARIOParameter, p_PUNTOS_USUARIOParameter, p_TELEFONO_USUARIOParameter, p_ID_COMUNAParameter, p_PASSWORD_USUARIOParameter);
        }
    
        public virtual ObjectResult<VALORACION> VALORACION_TAPI_INS(byte[] p_IMAGENBOLETA, Nullable<decimal> p_CALIFICACION, Nullable<decimal> p_NUMERO_BOLETA, Nullable<decimal> p_ID_OFERTA, string p_RUT_USUARIO, Nullable<decimal> p_ID_VALORACION)
        {
            var p_IMAGENBOLETAParameter = p_IMAGENBOLETA != null ?
                new ObjectParameter("P_IMAGENBOLETA", p_IMAGENBOLETA) :
                new ObjectParameter("P_IMAGENBOLETA", typeof(byte[]));
    
            var p_CALIFICACIONParameter = p_CALIFICACION.HasValue ?
                new ObjectParameter("P_CALIFICACION", p_CALIFICACION) :
                new ObjectParameter("P_CALIFICACION", typeof(decimal));
    
            var p_NUMERO_BOLETAParameter = p_NUMERO_BOLETA.HasValue ?
                new ObjectParameter("P_NUMERO_BOLETA", p_NUMERO_BOLETA) :
                new ObjectParameter("P_NUMERO_BOLETA", typeof(decimal));
    
            var p_ID_OFERTAParameter = p_ID_OFERTA.HasValue ?
                new ObjectParameter("P_ID_OFERTA", p_ID_OFERTA) :
                new ObjectParameter("P_ID_OFERTA", typeof(decimal));
    
            var p_RUT_USUARIOParameter = p_RUT_USUARIO != null ?
                new ObjectParameter("P_RUT_USUARIO", p_RUT_USUARIO) :
                new ObjectParameter("P_RUT_USUARIO", typeof(string));
    
            var p_ID_VALORACIONParameter = p_ID_VALORACION.HasValue ?
                new ObjectParameter("P_ID_VALORACION", p_ID_VALORACION) :
                new ObjectParameter("P_ID_VALORACION", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VALORACION>("VALORACION_TAPI_INS", p_IMAGENBOLETAParameter, p_CALIFICACIONParameter, p_NUMERO_BOLETAParameter, p_ID_OFERTAParameter, p_RUT_USUARIOParameter, p_ID_VALORACIONParameter);
        }
    
        public virtual ObjectResult<VALORACION> VALORACION_TAPI_INS(byte[] p_IMAGENBOLETA, Nullable<decimal> p_CALIFICACION, Nullable<decimal> p_NUMERO_BOLETA, Nullable<decimal> p_ID_OFERTA, string p_RUT_USUARIO, Nullable<decimal> p_ID_VALORACION, MergeOption mergeOption)
        {
            var p_IMAGENBOLETAParameter = p_IMAGENBOLETA != null ?
                new ObjectParameter("P_IMAGENBOLETA", p_IMAGENBOLETA) :
                new ObjectParameter("P_IMAGENBOLETA", typeof(byte[]));
    
            var p_CALIFICACIONParameter = p_CALIFICACION.HasValue ?
                new ObjectParameter("P_CALIFICACION", p_CALIFICACION) :
                new ObjectParameter("P_CALIFICACION", typeof(decimal));
    
            var p_NUMERO_BOLETAParameter = p_NUMERO_BOLETA.HasValue ?
                new ObjectParameter("P_NUMERO_BOLETA", p_NUMERO_BOLETA) :
                new ObjectParameter("P_NUMERO_BOLETA", typeof(decimal));
    
            var p_ID_OFERTAParameter = p_ID_OFERTA.HasValue ?
                new ObjectParameter("P_ID_OFERTA", p_ID_OFERTA) :
                new ObjectParameter("P_ID_OFERTA", typeof(decimal));
    
            var p_RUT_USUARIOParameter = p_RUT_USUARIO != null ?
                new ObjectParameter("P_RUT_USUARIO", p_RUT_USUARIO) :
                new ObjectParameter("P_RUT_USUARIO", typeof(string));
    
            var p_ID_VALORACIONParameter = p_ID_VALORACION.HasValue ?
                new ObjectParameter("P_ID_VALORACION", p_ID_VALORACION) :
                new ObjectParameter("P_ID_VALORACION", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VALORACION>("VALORACION_TAPI_INS", mergeOption, p_IMAGENBOLETAParameter, p_CALIFICACIONParameter, p_NUMERO_BOLETAParameter, p_ID_OFERTAParameter, p_RUT_USUARIOParameter, p_ID_VALORACIONParameter);
        }
    
        public virtual int VALORACION_TAPI_INS1(byte[] p_IMAGENBOLETA, Nullable<decimal> p_CALIFICACION, Nullable<decimal> p_NUMERO_BOLETA, Nullable<decimal> p_ID_OFERTA, string p_RUT_USUARIO, Nullable<decimal> p_ID_VALORACION)
        {
            var p_IMAGENBOLETAParameter = p_IMAGENBOLETA != null ?
                new ObjectParameter("P_IMAGENBOLETA", p_IMAGENBOLETA) :
                new ObjectParameter("P_IMAGENBOLETA", typeof(byte[]));
    
            var p_CALIFICACIONParameter = p_CALIFICACION.HasValue ?
                new ObjectParameter("P_CALIFICACION", p_CALIFICACION) :
                new ObjectParameter("P_CALIFICACION", typeof(decimal));
    
            var p_NUMERO_BOLETAParameter = p_NUMERO_BOLETA.HasValue ?
                new ObjectParameter("P_NUMERO_BOLETA", p_NUMERO_BOLETA) :
                new ObjectParameter("P_NUMERO_BOLETA", typeof(decimal));
    
            var p_ID_OFERTAParameter = p_ID_OFERTA.HasValue ?
                new ObjectParameter("P_ID_OFERTA", p_ID_OFERTA) :
                new ObjectParameter("P_ID_OFERTA", typeof(decimal));
    
            var p_RUT_USUARIOParameter = p_RUT_USUARIO != null ?
                new ObjectParameter("P_RUT_USUARIO", p_RUT_USUARIO) :
                new ObjectParameter("P_RUT_USUARIO", typeof(string));
    
            var p_ID_VALORACIONParameter = p_ID_VALORACION.HasValue ?
                new ObjectParameter("P_ID_VALORACION", p_ID_VALORACION) :
                new ObjectParameter("P_ID_VALORACION", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("VALORACION_TAPI_INS1", p_IMAGENBOLETAParameter, p_CALIFICACIONParameter, p_NUMERO_BOLETAParameter, p_ID_OFERTAParameter, p_RUT_USUARIOParameter, p_ID_VALORACIONParameter);
        }
    }
}
