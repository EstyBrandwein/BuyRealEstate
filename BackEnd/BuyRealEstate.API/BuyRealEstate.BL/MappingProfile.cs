using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.DTos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BuyRealEstate.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            
            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }

}
