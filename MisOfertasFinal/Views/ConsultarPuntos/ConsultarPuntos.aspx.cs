using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.ConsultarPuntos
{
    public partial class ConsultarPuntos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["consumidorEmail"] == null)
            {
                Response.Redirect("../Login/Login.aspx");
            }
            else
            {
                string consumidorEmail = (string)(Session["consumidorEmail"]);
                LogicaNegocio.LnUsuario objLnUsuario = new LogicaNegocio.LnUsuario();
                var usuario = objLnUsuario.BuscarUsuarioMail(consumidorEmail);
                string nombre = usuario.NOMBRE_USUARIO + " " + usuario.APEPA_USUARIO;
                decimal puntos = usuario.PUNTOS_USUARIO;
                lblNombre.Text = nombre;
                lblPuntos.Text = puntos.ToString();
            }
        }

        protected void btnDescargar_Click(object sender, EventArgs e)
        {

        }
    }
}