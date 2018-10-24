using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnUsuario
    {
        /// <summary>
        /// BUSCAR CONSUMIDOR ESPECIFICO
        /// </summary>
        /// <param name="obMoUsuario"></param>
        /// <returns>LISTADO CON DATOS DEL CONSUMIDOR</returns>
        public List<Modelo.Usuario> GetBuscarUsuario(Modelo.Usuario obMoUsuario)
        {
            using (EntitiesOfertas obEntitiesOfertas = new EntitiesOfertas())
            {

                var usuarios = (from q in obEntitiesOfertas.USUARIO
                                where q.CORREO_USUARIO == obMoUsuario.STCorreoUsuario && q.PASSWORD_USUARIO == obMoUsuario.STPasswordUsuario
                                select new Modelo.Usuario
                                {
                                    DECIdUsuario = q.ID_USUARIO,
                                    STNombreUsuario = q.NOMBRE_USUARIO,
                                    STPatUsuario = q.APEPA_USUARIO,
                                    STMatUsuario = q.APEMA_USUARIO,
                                    STCorreoUsuario = q.CORREO_USUARIO,
                                    STRutUsuario = q.RUT_USUARIO,
                                    STDirUsuario = q.DIRECCION_USUARIO,
                                    STFonoUsuario = q.TELEFONO_USUARIO,
                                    STPasswordUsuario = q.PASSWORD_USUARIO,
                                    DECPuntosUsuario = q.PUNTOS_USUARIO
                                }).ToList();
                return usuarios;
            }

        }
    }
}