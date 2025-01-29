using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IAuthService
    {
        Task SendVerificationEmail(string email, string verificationCode);
        Task<string> GenerateVerificationCodeAsync(int userId);
        Task<bool> VerifyCodeAsync(int userId, string verificationCode);


    }
}
