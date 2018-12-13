using MisOfertasFinal.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnCategoria
    {
        /// <summary>
        /// OBTENER TODAS LAS CATEGORÍAS DE PRODUCTOS
        /// </summary>
        /// <returns>LISTADO DE CATEGORIAS</returns>
        public List<Modelo.Categoria> GetListadoCategorias(decimal id_rubro)
        {
            using (Entities obEntitiesOfertas = new Entities())
            {

                var query = (from q in obEntitiesOfertas.CATEGORIA
                             where q.ID_RUBRO == id_rubro
                             select new Modelo.Categoria
                             {
                                 id_categoria = q.ID_CATEGORIA,
                                 nombre_categoria = q.NOMBRE_CATEGORIA
                             }).ToList();
                return query;
            }
        }
    }
}