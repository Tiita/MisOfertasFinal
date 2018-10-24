using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnCategoria
    {
        /// <summary>
        /// OBTENER TODAS LAS CATEGORÍAS DE PRODUCTOS
        /// </summary>
        /// <returns>LISTADO DE CATEGORIAS</returns>
        public List<Modelo.Categoria> GetListadoCategorias()
        {
            using (EntitiesOfertas obEntitiesOfertas = new EntitiesOfertas())
            {

                var query = (from q in obEntitiesOfertas.CATGORIAPRODUCTO
                             select new Modelo.Categoria
                             {
                                 DECIdCategoriaProducto = q.ID_CATEGORIAPRODUCTO,
                                 STNombreCategoriaProducto = q.NOMBRE_CATEGORIAPROD
                             }).ToList();
                return query;
            }
        }
    }
}