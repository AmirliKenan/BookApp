using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BookApp.Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailOptions emailOptions;
        public EmailSender(IOptions<EmailOptions> options)
        {
            emailOptions = options.Value;
                
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(emailOptions.SendGridKey, subject, htmlMessage, email);
        }
      private    Task Execute(string sendGridKey,string subject,string message,string email)
        {
            var client = new SendGridClient(sendGridKey);
            var from = new EmailAddress("amirli_555@mail.ru", "Books");
            var to = new EmailAddress(email, "End User");
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", message);
            return client.SendEmailAsync(msg);
        }
    }
}
