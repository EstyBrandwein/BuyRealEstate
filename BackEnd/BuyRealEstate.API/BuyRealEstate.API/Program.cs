using BuyRealEstate.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.Services;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<DevelopmentStatus, DevelopmentStatusDTO>();
    cfg.CreateMap<User, UsersDTO>();
    cfg.CreateMap<LegalStatus, LegalStatusDTO>();
    cfg.CreateMap<Image, ImageDTO>();
    cfg.CreateMap<Document, DocumentDTO>();
    cfg.CreateMap<Project, ProjectDTO>()
        .ForMember(dest => dest.ProjectManager, opt => opt.MapFrom(src => src.ProjectManager))
        .ForMember(dest => dest.DeveloperStatus, opt => opt.MapFrom(src => src.DeveloperStatus))
        .ForMember(dest => dest.LegalStatus, opt => opt.MapFrom(src => src.LegalStatus))
        .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));
    // îéôåé ùì Plot
    cfg.CreateMap<Plot, PlotDTO>()
        .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));
}, AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped<IPlotRepository, PlotRepository>();
builder.Services.AddScoped<IPlotService, PlotService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();

builder.Services.AddScoped<IProjectService, ProjectService>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conection_String")));

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.MapRazorPages();
app.Run();

