//using MailKit.Net.Smtp;
//using MimeKit;
//using System.Threading.Tasks;

//public class EmailService
//{
//    public async Task SendVerificationEmail(string email, string verificationCode)
//    {
//        var message = new MimeMessage();
//        message.From.Add(new MailboxAddress("Your Name", "your-email@example.com"));
//        message.To.Add(new MailboxAddress("", email));
//        message.Subject = "Your Verification Code";

//        message.Body = new TextPart("plain")
//        {
//            Text = $"Your verification code is: {verificationCode}"
//        };

//        using (var client = new SmtpClient())
//        {
//            // התחבר לשרת SMTP
//            await client.ConnectAsync("smtp.gmail.com", 587, false);
//            client.Authenticate("your-email@example.com", "your-email-password");

//            // שלח את ההודעה
//            await client.SendAsync(message);
//            await client.DisconnectAsync(true);
//        }
//    }
//}
