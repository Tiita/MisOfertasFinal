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
                                 DECIdRubro = q.ID_RUBRO,
                                 STNombreRubro = q.NOMBRE_RUBRO,
                                 STDescripcion = q.DESCRIPCION
                             }).ToList();
                return query;
            }
        }
    }
}