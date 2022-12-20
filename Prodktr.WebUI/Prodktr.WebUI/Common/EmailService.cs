using System;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Prodktr.WebUI.Common
{
    public class EmailService : IDisposable
    {
        private SmtpClient _client;
        public StringBuilder _body;

        public EmailService()
        {
            _body = new StringBuilder();
            _client = new SmtpClient();
        }

        public void Dispose()
        {
            _body.Clear();
            _client.Dispose();
        }

        public async Task<bool> SendEmailAsync(string fullname, string receiverEmail, string subject)
        {
            try
            {
                _client.UseDefaultCredentials = false;
                _client.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail.To.Add(receiverEmail);
                mail.From = new MailAddress("prabhakart16@gmail.com", "Dev Studio", Encoding.UTF8);
                mail.Subject = subject;
                mail.Body = _body.ToString();
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;
                _client.Host = "smtp.gmail.com";
                _client.Port = 587;
                _client.Credentials = new NetworkCredential("prabhakart16@gmail.com", "zwchmlbufoskphcp");
                
                
                await _client.SendMailAsync(mail);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}