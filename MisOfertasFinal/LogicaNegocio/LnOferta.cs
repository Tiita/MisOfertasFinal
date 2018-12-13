using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnOferta
    {
        public List<OFERTA> GetListadoOfertas()
        {
            using (Entities obEntitiesOfertas = new Entities())
            {
                var query = from q in obEntitiesOfertas.OFERTA.Include("PRODUCTO1").Include("VALORACION")
                             select q;
                return query.ToList();                             
            }
        }
    }
}