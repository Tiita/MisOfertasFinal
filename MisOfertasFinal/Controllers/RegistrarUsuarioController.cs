using System;
using System.Collections.Generic;

namespace MisOfertasFinal.Controllers
{
    public class RegistrarUsuarioController
    {
        /// <summary>
        /// OBTENER REGIONES DE LA BASE DE DATOS
        /// </summary>
        /// <returns>LISTADO DE REGIONES</returns>
        public List<Modelo.Region> GetRegionesController()
        {
            try
            {
                LogicaNegocio.LnRegion objLnRegion = new LogicaNegocio.LnRegion();
                return objLnRegion.GetListadoRegiones();
            }
            catch (Exception ex){throw ex;}
        }


        public List<Modelo.Comuna> GetComunasController( decimal decIdRegionC)
        {
            try
            {
                LogicaNegocio.LnComuna objLnComuna = new LogicaNegocio.LnComuna();
                return objLnComuna.GetListadoComunas(decIdRegionC);
            }
            catch (Exception ex ){throw ex;}
        }

        public void RegistrarClienteController(Modelo.Usuario objUsuario)
        {
            try
            {
                LogicaNegocio.LnUsuario objLnUsuario = new LogicaNegocio.LnUsuario();
                objLnUsuario.InsertarUsuarioCliente(objUsuario);
            }
            catch (Exception ex){throw ex;}
        }

        
    }
}