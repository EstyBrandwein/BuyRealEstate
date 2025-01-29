using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.DTos
{
    public class EmailSettings
    {
        
            public string SmtpServer { get; set; } = "smtp.gmail.com";
            public int Port { get; set; } = 587;
            public string SenderEmail { get; set; } // Your Gmail address
            public string SenderName { get; set; } // Your name or app name
            public string AppPassword { get; set; } // App password generated in Gmail
        

    }
}
