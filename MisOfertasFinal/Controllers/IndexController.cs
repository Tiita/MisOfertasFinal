using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.Controllers
{
    public class IndexController
    {
        /// <summary>
        /// OBTENER RUBROS DESDE EL MODELO
        /// </summary>
        /// <returns>LISTADO DE RUBROS</returns>
        public List<Modelo.Rubro> GetRubroController()
        {
            try
            {
                LogicaNegocio.LnRubro oblnRubro = new LogicaNegocio.LnRubro();
                return oblnRubro.GetListadoRubros();
            }
            catch (Exception ex) { throw ex; }
        }

        /// <summary>
        /// OBTENER CATEGORÍAS DESDE EL MODELO
        /// </summary>
        /// <returns>LISTADO DE CATEGORÍAS</returns>
        public List<Modelo.Categoria> GetCategoriaController()
        {
            try
            {
                LogicaNegocio.LnCategoria oblnCategoria = new LogicaNegocio.LnCategoria();
                return oblnCategoria.GetListadoCategorias();
            }
            catch (Exception ex) { throw ex; }
        }


        /// <summary>
        /// OBTENER MARCAS DESDE EL MODELO
        /// </summary>
        /// <returns>LISTADO DE MARCAS</returns>
        public List<Modelo.Marca> GetMarcaController()
        {
            try
            {
                LogicaNegocio.LnMarca obLnMarca = new LogicaNegocio.LnMarca();
                return obLnMarca.GetListadoMarcas();
            }
            catch (Exception ex) { throw ex; }
        }

        public List<Modelo.Producto> GetProductoController()
        {
            try
            {
                LogicaNegocio.LnProducto oblnProducto = new LogicaNegocio.LnProducto();
                return oblnProducto.GetListadoProductos();
            }
            catch (Exception ex) { throw ex; }
        }

    }
}