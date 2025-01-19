public interface IAuthService
{
    Task<string> GenerateVerificationCodeAsync(int userId);
    Task<bool> VerifyCodeAsync(int userId, string verificationCode);
    //Task UpdateVerificationCodeAsync(int userId, string verificationCode, bool isVerified);

    // הוספת הפונקציה לשליחת אימייל
    Task SendVerificationEmail(string email, string verificationCode);
}
