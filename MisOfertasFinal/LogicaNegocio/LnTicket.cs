using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MisOfertasFinal.Entidades;


namespace MisOfertasFinal.LogicaNegocio
{
    public class LnTicket
    {
        public decimal Descuento(decimal puntos)
        {
            decimal dest = 5;

            if (puntos >= 101 && puntos <= 500)
            {
                dest = 10;

            }
            if (puntos >= 501 && puntos <= 1000)
            {
                dest = 15;

            }
            return dest;
        }

        public string RubroDesct(decimal puntos)
        {
            string rubro = "Alimentos";
            if (puntos >= 101 && puntos <= 500)
            {
                rubro = "Alimentos, Electrónica y Línea Blanca";

            }
            if (puntos >= 501 && puntos <= 1000)
            {
                rubro = "Alimentos, Electrónica, Línea Blanca y Ropa";

            }
            return rubro;
        }

        public decimal MaxDect(decimal puntos)
        {
            decimal max = 100000;

            if (puntos >= 101 && puntos <= 500)
            {

                max = 150000;
            }
            if (puntos >= 501 && puntos <= 1000)
            {

                max = 300000;
            }
            return max;
        }

        public string DatosQR(USUARIO usu)
        {
            string glosa = "";
            string nombre = usu.NOMBRE_USUARIO + " " + usu.APEPA_USUARIO;
            string rut = usu.RUT_USUARIO;
            string puntos = usu.PUNTOS_USUARIO.ToString();
            string descuento = Descuento(usu.PUNTOS_USUARIO).ToString();
            string rubro = RubroDesct(usu.PUNTOS_USUARIO);
            string max = MaxDect(usu.PUNTOS_USUARIO).ToString();
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFinal = fechaInicio.AddMonths(1);
            string fecha = fechaFinal.ToString("dd/MM/yyyy");
            glosa = nombre + " " + rut + " " + puntos + " " + descuento + " " + rubro + " " + max + " " + fecha;
            return glosa;
        }

        public void IngresarTicket()
        {
            Entities db = new Entities();
            TICKETDESCUENTO ticket = new TICKETDESCUENTO();
        }
       
    }
}