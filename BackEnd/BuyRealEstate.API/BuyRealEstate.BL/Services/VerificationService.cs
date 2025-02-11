using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Services
{
    public class VerificationService : IVerificationService
    {
        private readonly IEmailService _emailService;
        private readonly IUserService _userService;
        private static readonly Dictionary<string, string> verificationCodes = new();

        public VerificationService(IEmailService emailService, IUserService userService)
        {
            _emailService = emailService;
            _userService = userService;
        }

        public async Task<VerificationResult> SendVerificationCodeAsync(string username, string password)
        {
            var user = await _userService.GetUserAsync(username);
            if (user == null || !BCrypt.Net.BCrypt.Verify(password, user.Password))
            {
                return new VerificationResult
                {
                    IsSuccessful = false,
                    ErrorMessage = "Invalid username or password."
                };
            }

            var verificationCode = new Random().Next(100000, 999999).ToString();
            verificationCodes[username] = verificationCode;



            var message = @"
<!DOCTYPE html>
<html lang=""he"">
<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>קוד אימות</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 100%;
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            padding: 20px;
            border-radius: 8px;
            box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
        }
        h3 {
            color: #333;
            font-size: 22px;
            text-align: center;
            margin-bottom: 20px;
        }
        .code {
            font-size: 32px;
            font-weight: bold;
            color: #4CAF50;
            text-align: center;
            margin: 20px 0;
            letter-spacing: 3px;
        }
        .message {
            color: #555;
            font-size: 16px;
            text-align: center;
            margin-bottom: 30px;
        }
        .footer {
            font-size: 12px;
            color: #888;
            text-align: center;
            background-color: #f9f9f9;
            padding: 10px;
            border-radius: 4px;
        }
        .footer a {
            color: #4CAF50;
            text-decoration: none;
        }
    </style>
</head>
<body>
    <div class=""container"">
        <h3>קוד האימות שלך לאפליקצית לקנות נדלן</h3>
        <p class=""code"">{verificationCode}</p>
        <p class=""message"">אנא הזן את הקוד הזה באפליקציה כדי להשלים את האימות</p>
        <div class=""footer"">
            <p>אם לא ביקשת קוד אימות, פשוט התעלם מההודעה.</p>
        </div>
    </div>
</body>
</html>
";

            message = message.Replace("{verificationCode}", verificationCode);




            await _emailService.SendEmailAsync(user.Email, "קוד אימות", message);

            return new VerificationResult
            {
                IsSuccessful = true,
                UserId = user.ID
            };
        }


        public bool VerifyCode(string username, string code)
        {
            if (verificationCodes.TryGetValue(username, out var correctCode) && correctCode == code)
            {
                verificationCodes.Remove(username);
                return true;
            }
            return false;
        }
    }

}
