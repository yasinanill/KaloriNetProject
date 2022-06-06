using Microsoft.AspNetCore.Identity.UI.Services;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUi.EmailServices
{
    public class EmailSender : IEmailSender
    {  
        
        private const string SendGridKey = "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";
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        

            {
                return Execute(SendGridKey, subject, htmlMessage, email);
            }

            private Task Execute(string sendGridKey, string subject, string message, string email)
            {
                var client = new SendGridClient(sendGridKey);

                var msg = new SendGridMessage()
                {
                    From = new EmailAddress("info@KaloriApp.com", "Kalori Net"),
                    Subject = subject,
                    PlainTextContent = message,
                    HtmlContent = message
                };

                msg.AddTo(new EmailAddress(email));
                return client.SendEmailAsync(msg);



            }
    }
}
