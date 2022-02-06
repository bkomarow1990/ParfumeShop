
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ParfumeShop.Utilities
{
    public class MailJetSettings
    {
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
    public class EmailService : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Task.Run(() =>
            {
                var senderEmail = new MailAddress("yashasalava721@gmail.com", "Jamil");
                var receiverEmail = new MailAddress(email, "email");
                var password = "2232005limmo";
                var sub = subject;
                var body = htmlMessage;
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(senderEmail.Address, password)
                };
                using (var mess = new MailMessage(senderEmail, receiverEmail)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mess);
                }
            });

        }
    }
}
