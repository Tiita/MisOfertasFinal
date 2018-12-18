using MisOfertasFinal.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnValoracion
    {


        #region Insertar_valoracion
        public void InsertarUsuarioCliente(Modelo.Usuario obMoUsuario)
        {
            using (Entities obEntitiesOfertas = new Entities())
            {
                obEntitiesOfertas.USUARIO_TAPI_INS(obMoUsuario.id_tipoUsuario, obMoUsuario.direccion_usuario,
                obMoUsuario.correoactivo, obMoUsuario.apepa_usuario, obMoUsuario.nombre_usuario, obMoUsuario.rut_usuario,
                obMoUsuario.correo_usuario, obMoUsuario.apema_usuario, obMoUsuario.puntos_usuario, obMoUsuario.telefono_usuario,
                obMoUsuario.id_comuna, obMoUsuario.password_usuario);
                obEntitiesOfertas.SaveChanges();

                //obEntitiesOfertas.
            }
        }
        #endregion
    }
}