using BuyRealEstate.Core.DTos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.Interfaces
{
    public interface IVerificationService
    {
        Task<VerificationResult> SendVerificationCodeAsync(string username, string password);
        bool VerifyCode(string username, string code);
    }

}
