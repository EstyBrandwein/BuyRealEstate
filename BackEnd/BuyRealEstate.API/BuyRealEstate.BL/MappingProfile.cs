using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using System.Threading.Tasks;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.DTos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using BuyRealEstate.Core.DTOs;
namespace BuyRealEstate.Core
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UsersDTO>();
            CreateMap<UsersDTO, User>();
            CreateMap<DevelopmentStatus, DevelopmentStatusDTO>();
            CreateMap<User, UsersDTO>();
            CreateMap<LegalStatus, LegalStatusDTO>();
            CreateMap<Image, ImageDTO>();
            CreateMap<Document, DocumentDTO>();
 
            CreateMap<Project, ProjectDTO>()
                .ForMember(dest => dest.ProjectManager, opt => opt.MapFrom(src => src.ProjectManager))
                .ForMember(dest => dest.DeveloperStatus, opt => opt.MapFrom(src => src.DeveloperStatus))
                .ForMember(dest => dest.LegalStatus, opt => opt.MapFrom(src => src.LegalStatus))
                .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
                .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

            CreateMap<Plot, PlotDTO>()
                .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));
        }
    }
}
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<User, UsersDTO>();
        CreateMap<UsersDTO, User>();
        CreateMap<DevelopmentStatus, DevelopmentStatusDTO>();
        CreateMap<User, UsersDTO>();
        CreateMap<LegalStatus, LegalStatusDTO>();
        CreateMap<Image, ImageDTO>();
        CreateMap<Document, DocumentDTO>();

        CreateMap<Project, ProjectDTO>()
            .ForMember(dest => dest.ProjectManager, opt => opt.MapFrom(src => src.ProjectManager))
            .ForMember(dest => dest.DeveloperStatus, opt => opt.MapFrom(src => src.DeveloperStatus))
            .ForMember(dest => dest.LegalStatus, opt => opt.MapFrom(src => src.LegalStatus))
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<Plot, PlotDTO>()
            .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));

        // Add the reverse mapping here
        CreateMap<PlotDTO, Plot>()
            .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));
    }
}





