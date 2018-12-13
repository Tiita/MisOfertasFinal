using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnMarca
    {
        /// <summary>
        /// OBTENER TODAS LAS MARCAS DE PRODUCTOS
        /// </summary>
        /// <returns>lISTADO DE MARCAS</returns>
        public List<Modelo.Marca> GetListadoMarcas()
        {
            using (Entities obEntitiesOfertas = new Entities())
            {

                var query = (from q in obEntitiesOfertas.MARCA
                             select new Modelo.Marca
                             {
                                 id_marca = q.ID_MARCA,
                                 nombre_marca = q.NOMBRE_MARCA
                             }).ToList();
                return query;
            }
        }
    }
}