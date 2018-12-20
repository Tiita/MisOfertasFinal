using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;

namespace MisOfertasFinal.LogicaNegocio
{
    public class LnGeneral
    {
        public void setEmail(Modelo.Correo objCorreo) {

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(objCorreo.from);
                mail.To.Add(objCorreo.to);
                mail.Subject = objCorreo.asunto;
                mail.Body = objCorreo.mensaje;

                if (objCorreo.tipo == 0) mail.IsBodyHtml = false;
                else if (objCorreo.tipo == 1) mail.IsBodyHtml = true;

                if (objCorreo.prioridad == 2) mail.Priority = MailPriority.High;
                else if (objCorreo.prioridad == 1) mail.Priority = MailPriority.Low;
                else if (objCorreo.prioridad == 0) mail.Priority = MailPriority.Normal;

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(objCorreo.mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);

                LinkedResource img = new LinkedResource(objCorreo.imagen,MediaTypeNames.Image.Jpeg);
                img.ContentId = objCorreo.idImagen;
                htmlView.LinkedResources.Add(img);



                SmtpClient smtp = new SmtpClient();
                smtp.Host = objCorreo.servidor;

                if (objCorreo.autenticacion) smtp.Credentials = new System.Net.NetworkCredential(objCorreo.usuario,objCorreo.password);
                if (objCorreo.puerto.Length > 0) smtp.Port = Convert.ToInt32(objCorreo.puerto);

                smtp.EnableSsl = objCorreo.conexionSegura;
                smtp.Send(mail);

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}