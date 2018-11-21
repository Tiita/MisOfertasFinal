using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.RegistrarCuenta
{
    public partial class RegistrarCuenta : System.Web.UI.Page
    {
        private Controllers.RegistrarUsuarioController objRegistrarUsuario = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            objRegistrarUsuario = new Controllers.RegistrarUsuarioController();
                       
            if (!IsPostBack) {
                cargarRegiones();
                ddlComuna.Items.Insert(0, new ListItem("Comunas", "0"));
            }
        }        

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            String activo = ObtenerCheck();
            string passwordHash = Hash(txtPassword.Text);
            String comuna = ddlComuna.SelectedValue;
            //Definir objeto usuario
            Modelo.Usuario obMoUsuario = new Modelo.Usuario
            {
                DecID_TIPOUSUARIO = 3,
                StDIRECCION_USUARIO = txtDireccion.Text,
                StCORREOACTIVO = activo,
                StAPEPA_USUARIO = txtApePaterno.Text,
                StNOMBRE_USUARIO = txtNombreCliente.Text,
                StRUT_USUARIO = txtRut.Text,
                StCORREO_USUARIO = txtCorreo.Text,
                StAPEMA_USUARIO = txtApeMaterno.Text,
                DecPUNTOS_USUARIO = 0,
                StTELEFONO_USUARIO = txtFono.Text,                
                DecID_COMUNA = int.Parse(comuna),
                StPASSWORD_USUARIO = passwordHash
        };
            Controllers.RegistrarUsuarioController objRegistrarC = new Controllers.RegistrarUsuarioController();
            objRegistrarC.RegistrarClienteController(obMoUsuario);
            Response.Redirect("../Login/Login.aspx");

        }        
        
        //Metodo para el hash de la password
        private string Hash(string password)
        {
            var bytes = new System.Text.UTF32Encoding().GetBytes(password);
            byte[] hashBytes = new System.Security.Cryptography.SHA512Managed().ComputeHash(bytes);
            return Convert.ToBase64String(hashBytes);
        }        

        public void cargarRegiones()
        {
            //Se obtiene listado de las regiones de la base de datos
            List<Modelo.Region> lstRegiones = objRegistrarUsuario.GetRegionesController();
            //Se carga el DropDownList con todas las regiones
            ddlRegion.DataSource = lstRegiones;
            ddlRegion.DataTextField = "StNOMBRE_REGION";
            ddlRegion.DataValueField = "DecID_REGION";
            ddlRegion.DataBind();
            ddlRegion.Items.Insert(0, new ListItem("Región", "0"));
        }

        public void cargarComunas(decimal decIdRegion) {
            List<Modelo.Comuna> lstComunas = objRegistrarUsuario.GetComunasController(decIdRegion);
            //Se cargan las comunas de acuerdo a la región
            ddlComuna.DataSource = lstComunas;
            ddlComuna.DataTextField = "StNOMBRE_COMUNA";
            ddlComuna.DataValueField = "DecID_COMUNA";
            ddlComuna.DataBind();
        }

        protected void ddlRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(ddlRegion.SelectedValue)) {
                cargarComunas(int.Parse(ddlRegion.SelectedValue));
            }
            else
            {
                ddlComuna.Items.Insert(0, new ListItem("Comunas", "0"));
            }
        }
        public String ObtenerCheck() {
            String valor = "N";
            if (chkCorreo.Checked == true) {
                valor = "S";
            }
            return valor;
        }


    }
}