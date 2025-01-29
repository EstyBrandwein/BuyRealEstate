using AutoMapper;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Domain.Models;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // Existing mappings
        CreateMap<User, UsersDTO>();
        CreateMap<UsersDTO, User>();
        CreateMap<DevelopmentStatus, DevelopmentStatusDTO>();
        CreateMap<LegalStatus, LegalStatusDTO>();
        CreateMap<Image, ImageDTO>();
        CreateMap<ImageDTO, Image>();
        CreateMap<Document, DocumentDTO>();
        CreateMap<DocumentDTO, Document>();
        CreateMap<Guarantees, GuaranteesDTO>();
        CreateMap<GuaranteesDTO, Guarantees>();
        CreateMap<Payment, PaymentDTO>();
        CreateMap<PaymentDTO, Payment>();

        // Project and ProjectDTO mappings
        CreateMap<Project, ProjectDTO>()
            .ForMember(dest => dest.ProjectManager, opt => opt.MapFrom(src => src.ProjectManager))
            .ForMember(dest => dest.DeveloperStatus, opt => opt.MapFrom(src => src.DeveloperStatus))
            .ForMember(dest => dest.LegalStatus, opt => opt.MapFrom(src => src.LegalStatus))
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        CreateMap<ProjectDTO, Project>()
            .ForMember(dest => dest.ProjectManager, opt => opt.MapFrom(src => src.ProjectManager))
            .ForMember(dest => dest.DeveloperStatus, opt => opt.MapFrom(src => src.DeveloperStatus))
            .ForMember(dest => dest.LegalStatus, opt => opt.MapFrom(src => src.LegalStatus))
            .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
            .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

        // Plot and PlotDTO mappings
        CreateMap<Plot, PlotDTO>()
            .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));

        CreateMap<PlotDTO, Plot>()
            .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));
    }
}
