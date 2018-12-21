using MisOfertasFinal.LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using MisOfertasFinal.Modelo;
using System.Drawing;

namespace MisOfertasFinal.Views.VerOferta
{
    public partial class VerOferta : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                if (Session["consumidorEmail"] == null)
                {
                    Response.Redirect("../Login/Login.aspx");
                }
                if (Session["Oferta"]==null) {
                    Response.Redirect("../Index/Index.aspx");
                }
                List<Modelo.Ofertas> data=(List<Modelo.Ofertas>)Session["Oferta"];
                dtlOferta.DataSource = data;
                dtlOferta.DataBind();
                ObtenerProductosRelacionados();                

            }
        }
       
        public void ObtenerProductosRelacionados()
        {
            LogicaNegocio.LnOferta objLnOferta = new LnOferta();
            dtlProRelacionados.DataSource = objLnOferta.getOfertasProductos();
            dtlProRelacionados.DataBind();
        }

        protected void dtlProRelacionados_ItemCommand(object source, System.Web.UI.WebControls.DataListCommandEventArgs e)
        {
            decimal codProducto, codigoOferta;
            if (e.CommandName == "Seleccionar")
            {
                dtlProRelacionados.SelectedIndex = e.Item.ItemIndex;
                codigoOferta = Convert.ToDecimal(((Label)this.dtlProRelacionados.SelectedItem.FindControl("lblCodigoOferta")).Text);
                codProducto = Convert.ToDecimal(((Label)this.dtlProRelacionados.SelectedItem.FindControl("lblCodigoProducto")).Text);

                LogicaNegocio.LnOferta objOferta = new LnOferta();
                List<Modelo.Ofertas> resultado = objOferta.GetOfertaEspecifica(codigoOferta, codProducto);
                Session["Oferta"] = resultado;
                Response.Redirect("../VerOferta/VerOferta.aspx");
                
            }
        }

        protected void dtlOferta_ItemCommand(object source, DataListCommandEventArgs e)
        {
            Decimal puntosAcumulados = 0;
            List<Modelo.Ofertas> oferta = (List<Modelo.Ofertas>)Session["Oferta"];
            LnValoracion lnValoracion = new LnValoracion();
            LnUsuario lnUsuario = new LnUsuario();
            var usuario = lnUsuario.BuscarUsuarioMail((string)(Session["consumidorEmail"]));
            if (e.CommandName == "RegistrarValoracion")
            {

                puntosAcumulados = usuario.PUNTOS_USUARIO + 10;
                Usuario us = new Usuario();
                {
                    us.rut_usuario = usuario.RUT_USUARIO;
                    us.nombre_usuario = usuario.NOMBRE_USUARIO;
                    us.apema_usuario = usuario.APEMA_USUARIO;
                    us.apepa_usuario = usuario.APEPA_USUARIO;
                    us.correo_usuario = usuario.CORREO_USUARIO;
                    us.direccion_usuario = usuario.DIRECCION_USUARIO;
                    us.telefono_usuario = usuario.TELEFONO_USUARIO;
                    us.password_usuario = usuario.PASSWORD_USUARIO;
                    us.correoactivo = usuario.CORREOACTIVO;
                    us.puntos_usuario = puntosAcumulados;
                    us.id_tipoUsuario = usuario.ID_TIPOUSUARIO;
                    us.id_comuna = usuario.ID_COMUNA;
                }
                foreach (var item in oferta)
                {
                    Valoracion valoracion = new Valoracion();
                    {
                        valoracion.id_oferta = item.id_oferta ;
                        valoracion.id_valoracion = Convert.ToDecimal(1);
                        valoracion.imagen_boleta = traerImagen((FileUpload)e.Item.FindControl("flSubir"));
                        valoracion.numero_boleta = Convert.ToDecimal(((TextBox)e.Item.FindControl("txtNumeroBoleta")).Text);
                        valoracion.rut_usuario = usuario.RUT_USUARIO;
                        valoracion.calificacion = Convert.ToDecimal(((DropDownList)e.Item.FindControl("ddlValoracion")).SelectedValue.ToString());
                    }
                    lnValoracion.InsertarValoracionOferta(valoracion,us);
                }                
            }
        }
       
        public Byte[] traerImagen(FileUpload fImagen) {
            int medida = fImagen.PostedFile.ContentLength;
            byte[] imgOriginal = new byte[medida];
            fImagen.PostedFile.InputStream.Read(imgOriginal, 0, medida);
            Bitmap imgOriginalBinaria = new Bitmap(fImagen.PostedFile.InputStream);
            string ImageDataURL64 = "data:Image/jpg;base64," + Convert.ToBase64String(imgOriginal);
            return imgOriginal;
        }        
    }
}