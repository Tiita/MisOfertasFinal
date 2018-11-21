using System;
using System.Collections.Generic;

namespace MisOfertasFinal.Controllers
{
    public class LoginController
    {
        public List<Modelo.Usuario> getUsuarioController(Modelo.Usuario obMoUsuario)
        {
            try
            {
                LogicaNegocio.LnUsuario obLogUsuario = new LogicaNegocio.LnUsuario();
                return obLogUsuario.GetBuscarUsuario(obMoUsuario);
            }
            catch (Exception ex) {
                throw ex;
            }
        }

    }
}