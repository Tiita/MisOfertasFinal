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
        public List<Modelo.Categoria> GetListadoCategorias(decimal DecIdcategoria)
        {
            using (Entities obEntitiesOfertas = new Entities())
            {

                var query = (from q in obEntitiesOfertas.CATEGORIA
                             where q.ID_CATEGORIA == DecIdcategoria
                             select new Modelo.Categoria
                             {
                                 DECIdCategoriaProducto = q.ID_CATEGORIA,
                                 STNombreCategoriaProducto = q.NOMBRE_CATEGORIA
                             }).ToList();
                return query;
            }
        }
    }
}