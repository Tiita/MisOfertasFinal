using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnComuna
    {
        public List<Modelo.Comuna> GetListadoComunas(decimal decIdRegionE)
        {
            try
            {
                using (Entities objEntitiesOfertas = new Entities())
                {
                    var query = (from q in objEntitiesOfertas.COMUNA
                                 where q.REGION_ID_REGION==decIdRegionE
                                 select new Modelo.Comuna {
                                     DecID_COMUNA = q.ID_COMUNA,
                                     StNOMBRE_COMUNA = q.NOMBRE_COMUNA
                                 }).ToList();
                    return query;
                }
            }
            catch (Exception ex){throw ex;}
        }
    }
}