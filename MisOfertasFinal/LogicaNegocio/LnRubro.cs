using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnRubro
    {
        /// <summary>
        /// OBTENER LISTADO DE RUBROS DE LOS PRODUCTOS
        /// </summary>
        /// <returns>LISTADO CON RUBROS</returns>
        public List<Modelo.Rubro> GetListadoRubros()
        {
            using (EntitiesOfertas obEntitiesOfertas = new EntitiesOfertas())
            {

                var query = (from q in obEntitiesOfertas.RUBROPRODUCTO
                             select new Modelo.Rubro
                             {
                                 DECIdRubro = q.ID_RUBRO,
                                 STNombreRubro = q.NOMBRE_RUBRO,
                                 STDescripcion = q.DESCRIPCION
                             }).ToList();
                return query;
            }
        }
    }
}