using System.Net.Mail;
using System.Net;
using MimeKit;


namespace Sredespacho.Data.DTO
{
    public class EnvioEmail
    {
        public string sendMail(string to, string asunto, string body)
        {
            string msge = " ";
            string from = "jasmellerp@hotmail.com";
            string displayName = "SALA CONTROL CCE"; 

            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from, displayName);
                mail.To.Add(to);

                mail.Subject = asunto;
                mail.Body = body;
                mail.IsBodyHtml = true;


                SmtpClient client = new SmtpClient("smtp.office365.com", 587); 
                client.Credentials = new NetworkCredential(from, "l@fuert3");
                client.EnableSsl = true;

                client.Send(mail);
                msge = "Correo enviado";

            }
            catch (Exception ex)
            {
                msge = ex.Message + ". Por favor verifica tu conexión a internet y que tus datos sean correctos e intenta nuevamente.";
            }

            return msge;
        }

    }
}

