using BuyRealEstate.Core.Interfaces;
using BuyRealEstate.Core.Services;
using BuyRealEstate.Domain.Models;
using BuyRealEstate.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using BuyRealEstate.Core;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Configure services directly using the builder
builder.Services.AddDbContext<BuyRealEstateDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Register the repository with the dependency injection container
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Register the service with the dependency injection container
builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddControllers();
builder.Services.AddRazorPages();

builder.Services.AddAutoMapper(typeof(MappingProfile));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // Make sure to map your API controllers
app.MapRazorPages();

app.Run();
