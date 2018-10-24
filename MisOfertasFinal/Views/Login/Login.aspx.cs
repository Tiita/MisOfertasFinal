﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string stMensaje = string.Empty;
                if (string.IsNullOrEmpty(txtEmail.Text)) stMensaje += "Ingresar email --";
                if (string.IsNullOrEmpty(txtPassword.Text)) stMensaje += "Ingresar password,";
                if (!string.IsNullOrEmpty(stMensaje)) throw new Exception(stMensaje.TrimEnd(','));

                //Definir objeto usuario
                Modelo.Usuario obMoUsuario = new Modelo.Usuario
                {
                    STCorreoUsuario = txtEmail.Text,
                    STPasswordUsuario = txtPassword.Text
                };

                //se implementa el hasheo de la password
                string passwordHash = Hash(obMoUsuario.STPasswordUsuario);
                //Insctaciar controlador Login
                Controllers.LoginController objLoginController = new Controllers.LoginController();
                List<Modelo.Usuario> lstUsuario = objLoginController.getUsuarioController(obMoUsuario);

                if (lstUsuario.Count > 0)
                {
                    Session["consumidorEmail"] = txtEmail.Text;
                    Response.Redirect("../Index/Index.aspx");
                }
                else
                {
                    throw new Exception("Usuario o password incorrectos");
                }
            }
            catch (Exception ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "mensaje", "<script>swal('Error!', '" + ex.Message + "!', 'error')</script>");
            }
        }
        private string Hash(string password)
        {
            var bytes = new System.Text.UTF32Encoding().GetBytes(password);
            byte[] hashBytes = new System.Security.Cryptography.SHA512Managed().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }
    }
}