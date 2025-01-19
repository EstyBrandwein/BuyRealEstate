using BuyRealEstate.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.Services;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

// Add AutoMapper
builder.Services.AddAutoMapper(cfg =>
{
    cfg.CreateMap<DevelopmentStatus, DevelopmentStatusDTO>();
    cfg.CreateMap<User, UserDto>();
    cfg.CreateMap<UserDto, User>();
    cfg.CreateMap<Permission, PermissionDTO>();
    cfg.CreateMap<PermissionDTO, Permission>();
    cfg.CreateMap<LegalStatus, LegalStatusDTO>();
    cfg.CreateMap<Image, ImageDTO>();
    cfg.CreateMap<Document, DocumentDTO>();
    cfg.CreateMap<Project, ProjectDTO>()
        .ForMember(dest => dest.ProjectManager, opt => opt.MapFrom(src => src.ProjectManager))
        .ForMember(dest => dest.DeveloperStatus, opt => opt.MapFrom(src => src.DeveloperStatus))
        .ForMember(dest => dest.LegalStatus, opt => opt.MapFrom(src => src.LegalStatus))
        .ForMember(dest => dest.Images, opt => opt.MapFrom(src => src.Images))
        .ForMember(dest => dest.Documents, opt => opt.MapFrom(src => src.Documents));

    cfg.CreateMap<Plot, PlotDTO>()
        .ForMember(dest => dest.Project, opt => opt.MapFrom(src => src.Project));
}, AppDomain.CurrentDomain.GetAssemblies());

// Register repositories and services
builder.Services.AddScoped<IPlotRepository, PlotRepository>();
builder.Services.AddScoped<IPlotService, PlotService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IAuthService, AuthService>();

// Add authentication with cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/api/user/login"; // Path for login
        options.LogoutPath = "/api/user/logout"; // Path for logout
        options.AccessDeniedPath = "/api/user/accessdenied"; // Path for access denied
    });

builder.Services.AddAuthorization();

// Add controllers and other middleware
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
app.UseCors(builder =>
    builder.WithOrigins("http://localhost:3000") // Frontend origin
           .AllowAnyHeader()
           .AllowAnyMethod());


// Add authentication and authorization middleware
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorPages();

app.Run();