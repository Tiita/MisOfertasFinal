using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace MisOfertasFinal.Views.RecuperarPassword
{
    public partial class RecuperaPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingresar email -";

                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                LogicaNegocio.LnUsuario objLnUsuario = new LogicaNegocio.LnUsuario();
                Modelo.Usuario objUser = new Modelo.Usuario
                {
                    correo_usuario = txtEmail.Text
                };

                List<Modelo.Usuario> lsConsulta= objLnUsuario.GetBuscarUsuarioCorreo(objUser);
                string nombre = null;
                string pass = null;
                if (lsConsulta.Count > 0)
                {
                    foreach (var item in lsConsulta) {
                        nombre = item.nombre_usuario;
                        pass = item.password_usuario;
                    }

                    string[] stLogin = nombre.ToString().Split('@');

                    string stCuerpoHTML = "<!DOCTYPE html>";
                    stCuerpoHTML += "<html lang='es'>";
                    stCuerpoHTML += "<head>";
                    stCuerpoHTML += "<meta charset='utf - 8'>";
                    stCuerpoHTML += "<title>Recuperacion de correo</title>";
                    stCuerpoHTML += "</head>";
                    stCuerpoHTML += "<body style='background - color: black '>";
                    stCuerpoHTML += "<table style='max - width: 600px; padding: 10px; margin: 0 auto; border - collapse: collapse; '>	";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='padding: 0'>";
                    stCuerpoHTML += "<img style='padding: 0; display: block' src='cid:Fondo' width='100%' height='10%'>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "<tr>";
                    stCuerpoHTML += "<td style='background - color: #ecf0f1'>";
                    stCuerpoHTML += "<div style='color: #34495e; margin: 4% 10% 2%; text-align: justify;font-family: sans-serif'>";
                    stCuerpoHTML += "<h2 style='color: #e67e22; margin: 0 0 7px'>Hola " + stLogin[0] + "</h2>";
                    stCuerpoHTML += "<p style='margin: 2px; font - size: 15px'>";
                    stCuerpoHTML += "Hemos recibido una solicitud para restablecer el password de su cuenta asociada con ";
                    stCuerpoHTML += "esta dirección de correo electrónico. Si no ha realizado esta solicitud, puede ignorar este ";
                    stCuerpoHTML += "correo electrónico y le garantizamos que su cuenta es completamente segura.";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "<br/>";
                    stCuerpoHTML += "Su password es: " + pass.ToString();
                    stCuerpoHTML += "</p>";
                    stCuerpoHTML += "<p style='color: #b3b3b3; font-size: 12px; text-align: center;margin: 30px 0 0'>Copyright © MIS OFERTAS 2018</p>";
                    stCuerpoHTML += "</div>";
                    stCuerpoHTML += "</td>";
                    stCuerpoHTML += "</tr>";
                    stCuerpoHTML += "</table>";
                    stCuerpoHTML += "</body>";
                    stCuerpoHTML += "</html>";

                    Modelo.Correo objCorreo = new Modelo.Correo
                    {
                        servidor = ConfigurationManager.AppSettings["servidor"].ToString(),
                        usuario = ConfigurationManager.AppSettings["usuario"].ToString(),
                        password = ConfigurationManager.AppSettings["password"].ToString(),
                        puerto = ConfigurationManager.AppSettings["puerto"].ToString(),
                        autenticacion = true,
                        conexionSegura = true,
                        prioridad = 0,//normal
                        tipo = 1,
                        asunto = "Recuperación de password",
                        from = ConfigurationManager.AppSettings["usuario"].ToString(),
                        to = txtEmail.Text,
                        imagen = Server.MapPath("~") + @"\Imagenes\descuentos4.jpg",
                        idImagen = "fondo",
                        mensaje = stCuerpoHTML
                    };

                    LogicaNegocio.LnRecuperarPassword lnRecuperar = new LogicaNegocio.LnRecuperarPassword();
                    lnRecuperar.setEmailLn(objCorreo);
                    ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Mensaje!'," +
                   " 'Se realizó el proceso con éxito', 'success')</script>");
                }
                else
                {
                    throw new Exception("No se encontró información asociada a esa dirección de correo");
                }

            }
            catch (Exception ex)
            {

                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!'," +
                   " '" + ex.Message + "!', 'error')</script>");
            }

        }
                
    }
}