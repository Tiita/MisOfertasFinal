using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Modelo
{
    public class Ofertas
    {
        public Ofertas() {           
        }        

        public decimal id_oferta { get; set; }
        public decimal maximo_pro { get; set; }
        public decimal minimo_pro { get; set; }
        public System.DateTime fecha_limite { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public decimal porcentaje_descuento { get; set; }
        public string nombre_categoria { get; set; }
        public decimal id_producto { get; set; }
        public string nombre_producto { get; set; }
        public decimal precio_producto { get; set; }
        public byte[] imagen_producto { get; set; }
        public decimal precio_final { get; set; }
        public decimal stock_producto { get; set; }
        public string descripcion_producto { get; set; }
        public string nombre_marca { get; set; }
        public decimal id_valoracion { get; set; }
        public decimal calificacion { get; set; }
        public byte[] imagen_boleta { get; set; }
        public decimal numero_boleta { get; set; }
        public string rut_usuario { get; set; }

    }
}