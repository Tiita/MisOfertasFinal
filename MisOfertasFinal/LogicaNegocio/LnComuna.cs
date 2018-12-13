using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnComuna
    {
        public List<Modelo.Comuna> GetListadoComunas(decimal id_region)
        {
            try
            {
                using (Entities objEntitiesOfertas = new Entities())
                {
                    var query = (from q in objEntitiesOfertas.COMUNA
                                 where q.REGION_ID_REGION== id_region
                                 select new Modelo.Comuna {
                                     id_comuna = q.ID_COMUNA,
                                     nombre_comuna = q.NOMBRE_COMUNA
                                 }).ToList();
                    return query;
                }
            }
            catch (Exception ex){throw ex;}
        }
    }
}