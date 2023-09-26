using Infrastructure.Data;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add additional prduction appsettings.json files
//please set the correct appsettings.json file for your environment
builder.Configuration
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
    //.AddJsonFile("appsettings.production.json", optional: true);
    .AddJsonFile("appsettings.Development.json", optional: true);
    //.AddJsonFile("appsettings.production.json", optional: true);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddMvc();

builder.Services.AddScoped<IProductRepository, ProductRepository>();

builder.Services.AddDbContext<StoreContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using var scoped = app.Services.CreateScope();
var services = scoped.ServiceProvider;
var context = services.GetRequiredService<StoreContext>();
var logger = services.GetRequiredService<ILogger<Program>>();
try
{
    await context.Database.MigrateAsync();
    await DbSeederContext.SeedAsync(context);

}
catch (Exception ex)
{
    logger.LogError(ex, "An error occurred during migration");
}

app.Run();
