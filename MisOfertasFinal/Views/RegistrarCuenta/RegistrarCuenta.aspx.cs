using MisOfertasFinal.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.RegistrarCuenta
{
    public partial class RegistrarCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //se toman los datos ingresados por el usuario
            string p_NOMBRE_USUARIO = txtNombreCliente.Text.Trim();
            string p_APEPA_USUARIO = txtApePaterno.Text.Trim();
            string p_APEMA_USUARIO = txtApeMaterno.Text.Trim();
            string p_RUT_USUARIO = txtRut.Text.Trim();
            string p_CORREO_USUARIO = txtCorreo.Text.Trim();
            string p_DIRECCION_USUARIO = txtDireccion.Text.Trim();
            string p_PASSWORD_USUARIO = txtPassword.Text.Trim();
            string p_TELEFONO_USUARIO = txtFono.Text.Trim();
            string comuna = DropDownListComuna.SelectedValue;
            int p_COMUNA_ID_COMUNA = int.Parse(comuna.ToString());
            int id = 0;
            // Se realiza el hasheo de la password
            string passwordHash = Hash(p_PASSWORD_USUARIO);




            /* p_DIRECCION_USUARIO, 
             p_APEPA_USUARIO, 
             p_RUT_USUARIO, 
             p_APEMA_USUARIO, 
             null, 
             p_PASSWORD_USUARIO, 
             null
             p_COMUNA_ID_COMUNA,
             p_NOMBRE_USUARIO, 
             perfil, 
             null, 
             p_CORREO_USUARIO, 
             null, 
             p_TELEFONO_USUARIO*/


            //Llamado al entity, Base de datos y Procedimiento.
            EntitiesOfertas bd = new EntitiesOfertas();
            //Llenado de datos al procedimiento( le asignamos 5 al tipo usuario ya que este es el consumidor)
            bd.insertarUsuario(id, p_DIRECCION_USUARIO, p_APEPA_USUARIO, p_RUT_USUARIO, p_APEMA_USUARIO, null, passwordHash, null, p_COMUNA_ID_COMUNA, p_NOMBRE_USUARIO, 5, null, p_CORREO_USUARIO, 0, p_TELEFONO_USUARIO);
            // se guarda el registro en la Base de datos
            bd.SaveChanges();
            //Redirección al login
            Response.Redirect("../Login/Login.aspx");

        }
        //Metodo para el hash de la password
        private string Hash(string password)
        {
            var bytes = new System.Text.UTF32Encoding().GetBytes(password);
            byte[] hashBytes = new System.Security.Cryptography.SHA512Managed().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

    }
}