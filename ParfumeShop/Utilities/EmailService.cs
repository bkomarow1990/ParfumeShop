
using Mailjet.Client;
using Mailjet.Client.Resources;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParfumeShop.Utilities
{
    public class MailJetSettings{
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
    }
    public class EmailService : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            MailJetSettings settings = _configuration.GetSection("MailJet").Get<MailJetSettings>();
            MailjetClient client = new MailjetClient(settings.ApiKey, settings.ApiSecret);
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
               .Property(Send.FromEmail, "brilliantperfumes@protonmail.com")
               .Property(Send.FromName, "BrilliantParfumeShop")
               .Property(Send.Subject, "Your email flight plan!")
               .Property(Send.TextPart, "Dear passenger, welcome to BrilliantParfumeShop! May the delivery force be with you!")
               .Property(Send.HtmlPart, htmlMessage)
               .Property(Send.Recipients, new JArray {
                new JObject {
                {"Email", email}
                }
                });
           await client.PostAsync(request);
        }
        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
