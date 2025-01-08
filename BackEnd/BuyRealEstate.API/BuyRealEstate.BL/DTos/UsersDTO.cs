using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyRealEstate.Core.DTos
{
    public class UsersDTO
    {
        public int ID { get; set; }
        public PermissionDTO Permission { get; set; }
        public int PermissionId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string FirstPhone { get; set; }
        public string? SecendPhon { get; set; }
        //public ICollection<PlotDTO> plots { get; set; }
        public ICollection<DocumentDTO> Documents { get; set; }


    }
}
