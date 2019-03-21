using Microsoft.Extensions.Options;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using SendGrid;

using System.Threading.Tasks;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace CourseProjectApp.Services
{
    public class MessageSend : IEmailSend, ISmsSend
    {
        public MessageSenderOptions Options { get; set; }

        public MessageSend(IOptions<MessageSenderOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
        }

        [HttpPost]
        public async Task SendSmsAsync(string number, string message)
        {
            using (var client = new HttpClient { BaseAddress = new Uri("https://api.twilio.com") })
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers
                    .AuthenticationHeaderValue("Basic"
                    , Convert.ToBase64String(Encoding.ASCII.GetBytes($"{Options.Sid}:{Options.AuthoToken}")));

                var contentSms = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("To",$"+{number}"),
                    new KeyValuePair<string,string>("From","15005550006"),
                    new KeyValuePair<string,string>("Body",message)
                });

                var results =
                 await client.PostAsync($"/2010-04-01/Accounts/{Options.Sid}/Messages.json", contentSms).ConfigureAwait(false);
            }
        }


        public Task SendEmailAsync(string email, string subject, string message)
        {
            var myMessage = new SendGridMessage();
            myMessage.AddTo(email);
            myMessage.From = new EmailAddress("irhad.mrndzic@example.com", "Aplikacija");
            myMessage.Subject = subject;
            myMessage.PlainTextContent = message;
            //  var apiKey = ConfigurationManager.AppSettings[Options.SendGridApiKey];
            var apiKey = Options.SendGridApiKey;
            var transportWeb = new SendGridClient(apiKey);

            return transportWeb.SendEmailAsync(myMessage);

        }

    }
}
