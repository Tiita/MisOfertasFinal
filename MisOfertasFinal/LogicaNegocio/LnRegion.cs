using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnRegion
    {
        public List<Modelo.Region> GetListadoRegiones()
        {
            using (Entities objEntitiesOfertas = new Entities())
            {
                var query = (from q in objEntitiesOfertas.REGION
                             select new Modelo.Region
                             {
                                 id_region = q.ID_REGION,
                                 nombre_region = q.NOMBRE_REGION

                             }).ToList();
                return query;
            }
        }
    }
}