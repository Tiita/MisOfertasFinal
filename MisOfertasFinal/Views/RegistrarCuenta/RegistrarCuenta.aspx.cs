using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace MisOfertasFinal.Views.RegistrarCuenta
{
    public partial class RegistrarCuenta : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
                                  
            if (!IsPostBack) {
                cargarRegiones();
                ddlRegion.Items.Insert(0, new ListItem("Región", "0"));
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
                id_tipoUsuario = 3,
                direccion_usuario = txtDireccion.Text,
                correoactivo = activo,
                apepa_usuario = txtApePaterno.Text,
                nombre_usuario = txtNombreCliente.Text,
                rut_usuario = txtRut.Text,
                correo_usuario = txtCorreo.Text,
                apema_usuario = txtApeMaterno.Text,
                puntos_usuario = 0,
                telefono_usuario = txtFono.Text,                
                id_comuna = int.Parse(comuna),
                password_usuario = passwordHash
        };
            LogicaNegocio.LnUsuario objLnUsuario = new LogicaNegocio.LnUsuario();
            objLnUsuario.InsertarUsuarioCliente(obMoUsuario);
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
            LogicaNegocio.LnRegion objLnRegion = null;
            LogicaNegocio.LnComuna objLnComuna = null;
            objLnRegion = new LogicaNegocio.LnRegion();
            //Se obtiene listado de las regiones de la base de datos
            List<Modelo.Region> lstRegiones = objLnRegion.GetListadoRegiones();
            //Se carga el DropDownList con todas las regiones
            ddlRegion.DataSource = lstRegiones;
            ddlRegion.DataTextField = "nombre_region";
            ddlRegion.DataValueField = "id_region";
            ddlRegion.DataBind();            
        }

        public void cargarComunas(decimal id_region) {
            LogicaNegocio.LnRegion objLnRegion = null;
            LogicaNegocio.LnComuna objLnComuna = null;
            objLnComuna = new LogicaNegocio.LnComuna();
            List<Modelo.Comuna> lstComunas = objLnComuna.GetListadoComunas(id_region);
            //Se cargan las comunas de acuerdo a la región
            ddlComuna.DataSource = lstComunas;
            ddlComuna.DataTextField = "nombre_comuna";
            ddlComuna.DataValueField = "id_comuna";
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