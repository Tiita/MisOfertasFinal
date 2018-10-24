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
            using (EntitiesOfertas obEntitiesOfertas = new EntitiesOfertas())
            {

                var query = (from q in obEntitiesOfertas.MARCA
                             select new Modelo.Marca
                             {
                                 DECIdMarca = q.ID_MARCA,
                                 STNombreMarca = q.NOMBRE_MARCA
                             }).ToList();
                return query;
            }
        }
    }
}