using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using BuyRealEstate.Core.DTos;



public class EmailService : IEmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(EmailSettings emailSettings)
    {
        _emailSettings = emailSettings;
    }

    public async Task SendEmailAsync(string recipientEmail, string subject, string message)
    {
        var email = new MimeMessage();
        email.From.Add(new MailboxAddress(_emailSettings.SenderName, _emailSettings.SenderEmail));
        email.To.Add(MailboxAddress.Parse(recipientEmail));
        email.Subject = subject;
        var bodyBuilder = new BodyBuilder
        {
            HtmlBody = message
        };
        email.Body = bodyBuilder.ToMessageBody();

        using var smtp = new SmtpClient();
        try
        {
            await smtp.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.Port, MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_emailSettings.SenderEmail, _emailSettings.AppPassword);
            await smtp.SendAsync(email);
        }
        finally
        {
            await smtp.DisconnectAsync(true);
        }
    }
}
