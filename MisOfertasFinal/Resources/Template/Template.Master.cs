using System;

namespace MisOfertasFinal.Resources.Template
{
    public partial class Template : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //iLogo.ImageUrl = "~/Imagenes/iconoV2.png";
            if (!IsPostBack)
            {
                
                if (Session["consumidorEmail"] != null)
                {
                    lblUsuario.Text = Session["consumidorEmail"].ToString();
                }
                else
                {
                    Response.Redirect("../../Views/Login/Login.aspx");
                }
            }
        }

        protected void lbSalir_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("../../Views/Login/Login.aspx");
        }
    }
}