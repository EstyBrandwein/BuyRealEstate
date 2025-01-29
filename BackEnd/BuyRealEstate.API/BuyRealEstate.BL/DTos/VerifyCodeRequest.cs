using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.DTos
{
    public class VerifyCodeRequest
    {
        public string Username { get; set; }
        public string Code { get; set; }
    }

}
