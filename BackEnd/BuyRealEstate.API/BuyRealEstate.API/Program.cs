using BuyRealEstate.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.Services;
using BuyRealEstate.Domain.Interfaces;
using BuyRealEstate.Core.DTos;
using BuyRealEstate.Core.DTOs;
using BuyRealEstate.Core;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IPlotRepository, PlotRepository>();
builder.Services.AddScoped<IPlotService, PlotService>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
//builder.Services.AddScoped<IAuthService, AuthService>();
builder.Services.AddScoped<IDocumentService, DocumentService>();
builder.Services.AddScoped<IDocumentRepository, DocumentRepository>();
builder.Services.AddScoped<IImageRepository, ImageRepository>();
builder.Services.AddScoped<IImageService, ImageService>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IVerificationService, VerificationService>();

builder.Services.AddScoped<IGuaranteesRepository, GuaranteesRepository>();
builder.Services.AddScoped<IGuaranteesService, GuaranteesService>();

//builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
//builder.Services.AddSingleton<IEmailService, EmailService>();


var emailSettings = builder.Configuration.GetSection("EmailSettings").Get<EmailSettings>();
builder.Services.AddSingleton(emailSettings);

builder.Services.AddScoped<IEmailService, EmailService>();




var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MappingProfile()); // Add your custom profiles
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Conection_String")));

builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy", builder =>
    {
        builder.WithOrigins("http://localhost:3000")
               .AllowAnyMethod()
               .AllowAnyHeader()
               .WithExposedHeaders("content-type"); // allows content-type header
    });
});
var app = builder.Build();

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
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.MapRazorPages();
app.Run();
            