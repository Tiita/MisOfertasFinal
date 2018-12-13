using MisOfertasFinal.Entidades;
using System.Collections.Generic;
using System.Linq;

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
            using (Entities obEntitiesOfertas = new Entities())
            {

                var query = (from q in obEntitiesOfertas.RUBRO
                             select new Modelo.Rubro
                             {
                                 id_rubro = q.ID_RUBRO,
                                 nombre_rubro = q.NOMBRE_RUBRO,
                                 descripcion = q.DESCRIPCION
                             }).ToList();
                return query;
            }
        }
    }
}