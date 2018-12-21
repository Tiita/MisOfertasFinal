using MisOfertasFinal.Entidades;
using MisOfertasFinal.Modelo;
<<<<<<< HEAD
=======
using System;
using System.Collections.Generic;
>>>>>>> 801107137797d3a56aa609fc68aee1fbfff99188
using System.Linq;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnValoracion
    {






        #region Verporcentajefaloracion
        public decimal GetValoraciones(decimal idOferta)
        {
            decimal totalPuntaje = 0;
            using (Entities Ofertas = new Entities())
            {
                var listadoValoraciones = (from q in Ofertas.VALORACION
                                           where q.ID_OFERTA == idOferta
                                           select new Modelo.Valoracion
                                           {
                                               calificacion = q.CALIFICACION

                                           }).ToList();



                foreach (var item in listadoValoraciones)
                {

                    totalPuntaje = totalPuntaje + item.calificacion;
                }
                if (totalPuntaje != 0)
                {
                    totalPuntaje = totalPuntaje / listadoValoraciones.Count;
                }
                


                return Math.Round(totalPuntaje, 1);
            }
            
        }
#endregion

        #region Insertar_valoracion
        public void InsertarValoracionOferta(Modelo.Valoracion obValoracion, Usuario us)
        {
            LnUsuario lnUsuario = new LnUsuario();
            using (Entities obEntitiesOfertas = new Entities())
            {
                // p_IMAGENBOLETAParameter, p_CALIFICACIONParameter, p_NUMERO_BOLETAParameter, p_ID_OFERTAParameter, p_RUT_USUARIOParameter, p_ID_VALORACIONParameter
                obEntitiesOfertas.VALORACION_TAPI_INS1(obValoracion.imagen_boleta, obValoracion.calificacion, obValoracion.numero_boleta, obValoracion.id_oferta,
                obValoracion.rut_usuario, obValoracion.id_valoracion);
                lnUsuario.ActualizarUsuarioCliente(us);
                obEntitiesOfertas.SaveChanges();
            }           
            
        }
        #endregion
    }
}