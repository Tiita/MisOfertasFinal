using MisOfertasFinal.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnOferta
    {

        public List<Modelo.Ofertas> getOfertasProductos()
        {
            using (Entities objOfertas = new Entities())
            {
                var query = (from ofer in objOfertas.OFERTA
                             join prod in objOfertas.PRODUCTO on ofer.ID_PRODUCTO equals prod.ID_PRODUCTO
                             join mrc in objOfertas.MARCA on prod.ID_MARCA equals mrc.ID_MARCA
                             join cat in objOfertas.CATEGORIA on prod.ID_CATEGORIA equals cat.ID_CATEGORIA
                             orderby cat.ID_CATEGORIA
                             select new Modelo.Ofertas
                             {
                                 id_oferta = ofer.ID_OFERTA,
                                 id_producto = prod.ID_PRODUCTO,
                                 nombre_producto = prod.NOMBRE_PRODUCTO,
                                 precio_producto = prod.PRECIO_PRODUCTO,
                                 precio_final = (prod.PRECIO_PRODUCTO - (prod.PRECIO_PRODUCTO * (ofer.PORCENTAJE_DESCUENTO / 100))),
                                 stock_producto = prod.STOCK_PRODUCTO,
                                 descripcion_producto = prod.DESCRIPCION_PRODUCTO,
                                 minimo_pro = ofer.MINIMO_PRO,
                                 maximo_pro = ofer.MAXIMO_PRO,
                                 porcentaje_descuento = ofer.PORCENTAJE_DESCUENTO,
                                 nombre_marca = mrc.NOMBRE_MARCA,
                                 fecha_limite = ofer.FECHA_LIMITE,
                                 imagen_producto = prod.IMAGEN_PRODUCTO
                             }).ToList();
                return query;
            }
        }

        public List<Modelo.Ofertas> GetOfertaEspecifica(decimal idOferta, decimal idProducto)
        { LnValoracion valoracion = new LnValoracion();
            using (Entities objOfertas = new Entities())
            {

                var query = (from ofer in objOfertas.OFERTA
                             join prod in objOfertas.PRODUCTO on ofer.ID_PRODUCTO equals prod.ID_PRODUCTO
                             join mrc in objOfertas.MARCA on prod.ID_MARCA equals mrc.ID_MARCA
                             join cat in objOfertas.CATEGORIA on prod.ID_CATEGORIA equals cat.ID_CATEGORIA
                             where prod.ID_PRODUCTO == idProducto & ofer.ID_OFERTA == idOferta
                             orderby cat.ID_CATEGORIA
                             select new Modelo.Ofertas {
                                 id_oferta = ofer.ID_OFERTA,
                                 nombre_categoria = cat.NOMBRE_CATEGORIA,
                                 id_producto = prod.ID_PRODUCTO,
                                 nombre_producto = prod.NOMBRE_PRODUCTO,
                                 precio_producto = prod.PRECIO_PRODUCTO,
                                 precio_final = (prod.PRECIO_PRODUCTO - (prod.PRECIO_PRODUCTO * (ofer.PORCENTAJE_DESCUENTO / 100))),
                                 stock_producto = prod.STOCK_PRODUCTO,
                                 descripcion_producto = prod.DESCRIPCION_PRODUCTO,
                                 minimo_pro = ofer.MINIMO_PRO,
                                 maximo_pro = ofer.MAXIMO_PRO,
                                 porcentaje_descuento = ofer.PORCENTAJE_DESCUENTO,
                                 nombre_marca = mrc.NOMBRE_MARCA,
                                 fecha_limite = ofer.FECHA_LIMITE,
                                 imagen_producto = prod.IMAGEN_PRODUCTO
                             }).ToList();

                foreach (var item in query)
                {
                    //item.calificacion = valoracion.GetValoraciones(item.id_oferta);
                }
                return query;
            }//fin del using            
        }
    }
}