using BuyRealEstate.Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;
    private readonly string _smtpHost;
    private readonly int _smtpPort;
    private readonly string _smtpUsername;
    private readonly string _smtpPassword;

    public AuthService(IUserRepository userRepository, IConfiguration configuration)
    {
        _userRepository = userRepository;
        _smtpHost = configuration["Smtp:Host"];
        _smtpPort = int.Parse(configuration["Smtp:Port"]);
        _smtpUsername = configuration["Smtp:Username"];
        _smtpPassword = configuration["Smtp:Password"];
    }


    public async Task SendVerificationEmail(string email, string verificationCode)
    {
        var mailMessage = new MailMessage
        {
            From = new MailAddress(_smtpUsername), // Use your Gmail address here
            To = { new MailAddress(email) },
            Subject = "Verify your account",
            Body = $"<p>Your verification code is: <strong>{verificationCode}</strong></p>",
            IsBodyHtml = true
        };

        using (var smtpClient = new SmtpClient(_smtpHost, _smtpPort))
        {
            smtpClient.Credentials = new NetworkCredential(_smtpUsername, _smtpPassword); // Ensure the correct password
            smtpClient.EnableSsl = true; // TLS is required for Gmail
            smtpClient.Timeout = 10000; // Optional: set timeout to allow for slower connections
            try
            {
                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (SmtpException ex)
            {
                // Handle exception (log it, etc.)
                Console.WriteLine("SMTP Exception: " + ex.Message);
            }
        }
    }





    public async Task<string> GenerateVerificationCodeAsync(int userId)
    {
        var verificationCode = GenerateRandomCode();
        var user = await _userRepository.GetByIdAsync(userId);
        if (user != null)
        {
            user.VerificationCode = verificationCode;
            user.VerificationCodeExpiry = DateTime.UtcNow.AddMinutes(10); // תוקף ל-10 דקות
            user.IsVerified = false; // סימון שלא אומת
            await _userRepository.UpdateAsync(user);
        }

        return verificationCode;
    }

    public async Task<bool> VerifyCodeAsync(int userId, string verificationCode)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        if (user == null || user.VerificationCode != verificationCode || user.VerificationCodeExpiry < DateTime.UtcNow)
        {
            return false;
        }

        // עדכון כמאומת
        user.IsVerified = true;
        user.VerificationCode = null; // מחיקת הקוד לאחר האימות
        user.VerificationCodeExpiry = null;
        await _userRepository.UpdateAsync(user);

        return true;
    }

    private string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    private bool VerifyPassword(string enteredPassword, string storedHash)
    {
        return BCrypt.Net.BCrypt.Verify(enteredPassword, storedHash);
    }



    private string GenerateRandomCode()
    {
        var random = new Random();
        return random.Next(100000, 999999).ToString();
    }

    ////  הפונקציה לשליחת האימייל
    //public async Task SendVerificationEmail(string email, string verificationCode)
    //{
    //    var mailMessage = new MailMessage
    //    {
    //        To = { new MailAddress(email) },
    //        Subject = "Verify your account",
    //        Body = $"<p>Your verification code is: <strong>{verificationCode}</strong></p>",
    //        IsBodyHtml = true
    //    };

    //    using (var smtpClient = new SmtpClient("smtp.yourdomain.com", 587))
    //    {
    //        smtpClient.Credentials = new NetworkCredential("m0548471369@gmail.com", "your_password");
    //        smtpClient.EnableSsl = true;
    //        await smtpClient.SendMailAsync(mailMessage);
    //    }
    //}

}
