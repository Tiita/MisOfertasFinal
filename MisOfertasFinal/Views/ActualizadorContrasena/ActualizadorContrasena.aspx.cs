using MisOfertasFinal.LogicaNegocio;
using MisOfertasFinal.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.ActualizadorContrasena
{
    public partial class ActualizadorContrasena : System.Web.UI.Page
    {
        string rut = "";
        string correo ="";

        protected void Page_Load(object sender, EventArgs e)
        {
            btnIniciarSesion.Visible = false;
             rut = Convert.ToString(Request.QueryString["asprt"]);
             correo = Convert.ToString(Request.QueryString["aspc"]);
            if (rut==null && correo==null)
            {
                Response.Redirect("../Login/Login.aspx");
            }



        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

            
            LnUsuario lnUsuario = new LnUsuario();
            var usuario = lnUsuario.BuscarUsuarioMailRut(correo,rut);
            string passwordHash = Hash(txtPassword.Text);

            Usuario us = new Usuario();
            {
                us.rut_usuario = usuario.RUT_USUARIO;
                us.nombre_usuario = usuario.NOMBRE_USUARIO;
                us.apema_usuario = usuario.APEMA_USUARIO;
                us.apepa_usuario = usuario.APEPA_USUARIO;
                us.correo_usuario = usuario.CORREO_USUARIO;
                us.direccion_usuario = usuario.DIRECCION_USUARIO;
                us.telefono_usuario = usuario.TELEFONO_USUARIO;
                us.password_usuario = passwordHash;
                us.correoactivo = usuario.CORREOACTIVO;
                us.puntos_usuario = usuario.PUNTOS_USUARIO;
                us.id_tipoUsuario = usuario.ID_TIPOUSUARIO;
                us.id_comuna = usuario.ID_COMUNA;
            }
            lnUsuario.ActualizarUsuarioCliente(us);
                       ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Contraseña restablecida!'," +
                  " 'Se restablecio su contraseña', 'success')</script>");
                btnAceptar.Visible = false;
                txtPassword.Visible = false;
                TxtPassword2.Visible = false;
                VldRequierepass1.Enabled = false;
                VldCustom1.Enabled = false;
                validador3.Enabled = false;
                Validador2.Enabled = false;
                btnIniciarSesion.Visible = true;
            }
            catch(Exception )
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Correo enviado!'," +
                 " 'Hemos enviado un email a su direccion de correo', 'error')</script>");
            }
        }

        private string Hash(string password)
        {
            var bytes = new System.Text.UTF32Encoding().GetBytes(password);
            byte[] hashBytes = new System.Security.Cryptography.SHA512Managed().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Login/Login.aspx");
        }
    }
}