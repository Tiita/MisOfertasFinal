using System;
using System.Collections.Generic;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnRecuperarPassword
    {
        public List<Modelo.Usuario> getConsultarPassword(Modelo.Usuario objUsuario) {

            try
            {
                
                LogicaNegocio.LnUsuario objLnUsuario = new LnUsuario();                
                return objLnUsuario.GetBuscarUsuarioCorreo(objUsuario);
            }
            catch (Exception ex){ throw ex; }
        }


        public void setEmailLn(Modelo.Correo obCorreo) {
            try
            {
                LogicaNegocio.LnGeneral objGeneral = new LnGeneral();
                objGeneral.setEmail(obCorreo);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}