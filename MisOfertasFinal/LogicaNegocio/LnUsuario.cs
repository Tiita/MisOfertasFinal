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
                                where q.CORREO_USUARIO == obMoUsuario.correo_usuario && q.PASSWORD_USUARIO == obMoUsuario.password_usuario
                                select new Modelo.Usuario
                                {
                                    rut_usuario = q.RUT_USUARIO,
                                    nombre_usuario = q.NOMBRE_USUARIO,
                                    apepa_usuario = q.APEPA_USUARIO,
                                    apema_usuario = q.APEMA_USUARIO,
                                    correo_usuario = q.CORREO_USUARIO,                                    
                                    direccion_usuario = q.DIRECCION_USUARIO,
                                    telefono_usuario = q.TELEFONO_USUARIO,
                                    password_usuario = q.PASSWORD_USUARIO,
                                    correoactivo = q.CORREOACTIVO,
                                    puntos_usuario = q.PUNTOS_USUARIO,
                                    id_tipoUsuario = q.ID_TIPOUSUARIO,
                                    id_comuna = q.ID_COMUNA
                                }).ToList();
                return usuarios;
            }

        }
        #region Insertar_cliente
        public void InsertarUsuarioCliente(Modelo.Usuario obMoUsuario) {
            using (Entities obEntitiesOfertas = new Entities())
            {
                obEntitiesOfertas.USUARIO_TAPI_INS(obMoUsuario.id_tipoUsuario, obMoUsuario.direccion_usuario,
                obMoUsuario.correoactivo,obMoUsuario.apepa_usuario,obMoUsuario.nombre_usuario,obMoUsuario.rut_usuario,
                obMoUsuario.correo_usuario,obMoUsuario.apema_usuario,obMoUsuario.puntos_usuario,obMoUsuario.telefono_usuario,
                obMoUsuario.id_comuna,obMoUsuario.password_usuario);
                obEntitiesOfertas.SaveChanges();
            }
        }
        #endregion
    }
}