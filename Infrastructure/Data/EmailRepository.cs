﻿using Core.Interfaces;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class EmailRepository : IEmailSenderRepository
    {
        public void SendEmail(string toEmail, string subject)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential("dhanushkauduwela10000@gmail.com", "txfrsufipqotkikr");

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("dhanushkauduwela10000@gmail.com");
            mailMessage.To.Add(toEmail);
            mailMessage.Subject = subject;
            mailMessage.IsBodyHtml = true;
            StringBuilder mailBody = new StringBuilder();
            mailBody.AppendFormat("<h1>User Registered</h1>");
            mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<p>Thank you For Registering account</p>");
            mailMessage.Body = mailBody.ToString();

            client.Send(mailMessage);

        }

    }
}
