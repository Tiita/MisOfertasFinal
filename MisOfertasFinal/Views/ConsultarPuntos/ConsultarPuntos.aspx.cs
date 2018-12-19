using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using ZXing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using System.IO;
using System.Text.RegularExpressions;
using MisOfertasFinal.Entidades;

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
                DateTime fechaInicio = DateTime.Now;
                DateTime fechaFinal = fechaInicio.AddMonths(1);
                lblNombre.Text = nombre;
                lblPuntos.Text = puntos.ToString();
                lblNombreCupon.Text = nombre;
                lblRutCupon.Text = usuario.RUT_USUARIO;
                lblPuntosCupon.Text = usuario.PUNTOS_USUARIO.ToString();
                //recuperar descuento
                LogicaNegocio.LnTicket datosTicket = new LogicaNegocio.LnTicket();                
                lblDescuentoCupon.Text = datosTicket.Descuento(puntos).ToString()+"%";
                lblRubroCupon.Text = datosTicket.RubroDesct(puntos);
                lblMaxCupon.Text = "$" + datosTicket.MaxDect(puntos).ToString();
                lblFechaCupon.Text = fechaFinal.ToString("dd/MM/yyyy");
                //generar codigoQR
                BarcodeWriter barcode = new BarcodeWriter();                            //crea obj codigo
                barcode.Format = BarcodeFormat.QR_CODE;                                 //formato codigo
                string datosQR = datosTicket.DatosQR(usuario);
                Bitmap bitmap = new Bitmap(barcode.Write(datosQR), 300, 300);          //crea bitmap con el string y da tamaño
                bitmap.Save(Server.MapPath("./codigo.png"), ImageFormat.Png);          //salva bitmar en una ruta
                imgQr.ImageUrl = "./codigo.png";




            }
        }

        protected void btnDescargar_Click(object sender, EventArgs e)
        {
            string consumidorEmail = (string)(Session["consumidorEmail"]);
            LogicaNegocio.LnUsuario objLnUsuario = new LogicaNegocio.LnUsuario();
            var usuario = objLnUsuario.BuscarUsuarioMail(consumidorEmail);
            string nombre = usuario.NOMBRE_USUARIO + " " + usuario.APEPA_USUARIO;
            decimal puntos = usuario.PUNTOS_USUARIO;
            LogicaNegocio.LnTicket datosTicket = new LogicaNegocio.LnTicket();
            DateTime fechaInicio = DateTime.Now;
            DateTime fechaFinal = fechaInicio.AddMonths(1);

                       
            //preparacion documento
            Document document = new Document();
            string path = Server.MapPath(".");
            PdfWriter.GetInstance(document, new FileStream(path + "/cupon.pdf", FileMode.Create));

            //Abrir el Documento
            document.Open();
            
            //preparando imagen
            string pathImg = Server.MapPath("./codigo.png");
            iTextSharp.text.Image imagen = iTextSharp.text.Image.GetInstance(pathImg);
            imagen.BorderWidth = 0;
            imagen.Alignment = Element.ALIGN_LEFT;
            float percentage = 0.0f;
            percentage = 150 / imagen.Width;
            imagen.ScalePercent(percentage * 100);

            PdfPTable tablaPdf = new PdfPTable(3);
            PdfPCell titulo = new PdfPCell(new Phrase("Cupón de Descuento"));
            titulo.Colspan = 3;
            titulo.HorizontalAlignment = 1;
            tablaPdf.AddCell(titulo);

            PdfPCell celdaimagen = new PdfPCell();
            celdaimagen.AddElement(imagen);
            celdaimagen.Rowspan = 7;
            celdaimagen.HorizontalAlignment = 1;
            celdaimagen.VerticalAlignment = 1;
            tablaPdf.AddCell(celdaimagen);

            tablaPdf.AddCell("Nombre:");
            tablaPdf.AddCell(nombre);
            tablaPdf.AddCell("RUT:");
            tablaPdf.AddCell(usuario.RUT_USUARIO);
            tablaPdf.AddCell("Puntos:");
            tablaPdf.AddCell(usuario.PUNTOS_USUARIO.ToString());
            tablaPdf.AddCell("Descuento:");
            tablaPdf.AddCell(datosTicket.Descuento(puntos).ToString()+"%");
            tablaPdf.AddCell("Rubro:");
            tablaPdf.AddCell(datosTicket.RubroDesct(puntos));
            tablaPdf.AddCell("Máximo Descuento:");
            tablaPdf.AddCell("$"+datosTicket.MaxDect(puntos).ToString());
            tablaPdf.AddCell("Fecha Expiración:");
            tablaPdf.AddCell(fechaFinal.ToString("dd/MM/yyyy"));


            Entities obEntitiesOfertas = new Entities();
            TICKETDESCUENTO ticket = new TICKETDESCUENTO();

            //convertir imagen a byte[] para gardarlo en la base de datos
            FileStream stream = File.OpenRead(Server.MapPath("./codigo.png"));
            byte[] fileBytes = new byte[stream.Length];
            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();
            /*proceso inverso
             * using (Stream file = File.OpenWrite(Server.MapPath("./codigo.png")))
             *   {
             *       file.Write(fileBytes, 0, fileBytes.Length);
             *   }
             */
            
            /*
            ticket.ID_TICKET = datosTicket.BuscarUltimoIDTicket() + 1;
            ticket.CODIGOBARRA = fileBytes;
            ticket.DESCUENTO_OTORGADO = datosTicket.Descuento(puntos);
            ticket.FECHA_INICIO = fechaInicio;
            ticket.FECHA_TERMINO = fechaFinal;
            ticket.RUT_USUARIO = usuario.RUT_USUARIO;
            ticket.TOPE = datosTicket.MaxDect(puntos);
            */
            obEntitiesOfertas.InsertarTicket(fechaFinal, datosTicket.MaxDect(puntos), usuario.RUT_USUARIO, fileBytes, fechaInicio, datosTicket.BuscarUltimoIDTicket() + 1, datosTicket.Descuento(puntos));
            obEntitiesOfertas.SaveChanges();
                     
            document.Add(tablaPdf);
            //cerrar Documento
            document.Close();

            //Descargar el archivo
            // Limpiamos la salida
            Response.Clear();
            // Con esto le decimos al browser que la salida sera descargable
            Response.ContentType = "application/octet-stream";
            // esta linea es opcional, en donde podemos cambiar el nombre del fichero a descargar (para que sea diferente al original)
            Response.AddHeader("Content-Disposition", "attachment; filename=cupon.pdf");
            // Escribimos el fichero a enviar 
            Response.WriteFile("./cupon.pdf");
            // volcamos el stream 
            Response.Flush();
            // Enviamos todo el encabezado ahora
            Response.End();
        }
    }
}