using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Vidracaria_Portal.Services
{
    public class EmailSender
    {
        public async Task<bool> Mail(string To, string From, string Sub, string Mensagem)
        {
            var email = new MailMessage()
            {
                Subject = Sub,
                Body = Mensagem,
                IsBodyHtml = true
            };

            MailAddress eu = new MailAddress(To);

            email.To.Add(eu);
            email.From = new MailAddress(From);
            email.Sender = eu;

            var smtp = new SmtpClient()
            {
                Host = "smtp.office365.com", // smtp.mail.yahoo.com // smtp.live.com
                Port = 587,
                Credentials = new NetworkCredential("AlexandreTavanoDeveloper@outlook.com", ""),
                EnableSsl = true
            };

            try
            {
                await smtp.SendMailAsync(email);
                return true;
            }
            catch (Exception ex){
                return false;
            }
        }
    }
}
