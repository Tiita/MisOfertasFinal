using MisOfertasFinal.Entidades;
using System.Collections.Generic;
using System.Linq;

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
            using (Entities obEntitiesOfertas = new Entities())
            {
                var usuarios = (from q in obEntitiesOfertas.USUARIO
                                where q.CORREO_USUARIO == obMoUsuario.StCORREO_USUARIO && q.PASSWORD_USUARIO == obMoUsuario.StPASSWORD_USUARIO
                                select new Modelo.Usuario
                                {
                                    StRUT_USUARIO = q.RUT_USUARIO,
                                    StNOMBRE_USUARIO = q.NOMBRE_USUARIO,
                                    StAPEPA_USUARIO = q.APEPA_USUARIO,
                                    StAPEMA_USUARIO = q.APEMA_USUARIO,
                                    StCORREO_USUARIO = q.CORREO_USUARIO,                                    
                                    StDIRECCION_USUARIO = q.DIRECCION_USUARIO,
                                    StTELEFONO_USUARIO = q.TELEFONO_USUARIO,
                                    StPASSWORD_USUARIO = q.PASSWORD_USUARIO,
                                    StCORREOACTIVO = q.CORREOACTIVO,
                                    DecPUNTOS_USUARIO = q.PUNTOS_USUARIO,
                                    DecID_TIPOUSUARIO = q.ID_TIPOUSUARIO,
                                    DecID_COMUNA = q.ID_COMUNA
                                }).ToList();
                return usuarios;
            }

        }

        public void InsertarUsuarioCliente(Modelo.Usuario obMoUsuario) {
            using (Entities obEntitiesOfertas = new Entities())
            {
                obEntitiesOfertas.USUARIO_TAPI_INS(obMoUsuario.DecID_TIPOUSUARIO, obMoUsuario.StDIRECCION_USUARIO,
                obMoUsuario.StCORREOACTIVO,obMoUsuario.StAPEPA_USUARIO,obMoUsuario.StNOMBRE_USUARIO,obMoUsuario.StRUT_USUARIO,
                obMoUsuario.StCORREO_USUARIO,obMoUsuario.StAPEMA_USUARIO,obMoUsuario.DecPUNTOS_USUARIO,obMoUsuario.StTELEFONO_USUARIO,
                obMoUsuario.DecID_COMUNA,obMoUsuario.StPASSWORD_USUARIO);
                obEntitiesOfertas.SaveChanges();
            }
        }
    }
}