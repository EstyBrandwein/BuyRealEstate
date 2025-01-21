using BuyRealEstate.Domain.Interfaces;
using System.Net;
using System.Net.Mail;

public class AuthService : IAuthService
{
    private readonly IUserRepository _userRepository;

    public AuthService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
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

    //  הפונקציה לשליחת האימייל
    public async Task SendVerificationEmail(string email, string verificationCode)
    {
        var mailMessage = new MailMessage
        {
            To = { new MailAddress(email) },
            Subject = "Verify your account",
            Body = $"<p>Your verification code is: <strong>{verificationCode}</strong></p>",
            IsBodyHtml = true
        };

        using (var smtpClient = new SmtpClient("smtp.yourdomain.com", 587))
        {
            smtpClient.Credentials = new NetworkCredential("m0548471369@gmail.com", "your_password");
            smtpClient.EnableSsl = true;
            await smtpClient.SendMailAsync(mailMessage);
        }
    }

}
