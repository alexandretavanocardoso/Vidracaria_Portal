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
            var m = new MailMessage()
            {
                Subject = Sub,
                Body = Mensagem,
                IsBodyHtml = true
            };
            MailAddress to = new MailAddress(To);
            m.To.Add(to);
            m.From = new MailAddress(From);
            m.Sender = to;
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com", // smtp.mail.yahoo.com // smtp.live.com
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("vidracariaportalbb@gmail.com", "ASD123asd")
            };
            try
            {
                await smtp.SendMailAsync(m);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
