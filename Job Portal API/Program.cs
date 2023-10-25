using Job_Portal_API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using System;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var configuration = builder.Configuration;

builder.Services.AddControllers();

// Add Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    // Configure Swagger documentation
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Job Portal API", Version = "v1" });
});

builder.Services.AddDbContext<JobDBContext>(options =>
{
    // Configure Entity Framework to use a SQL Server database with the connection string from configuration
    options.UseSqlServer(configuration.GetConnectionString("conStr"));
});

// builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
        // Define a CORS policy that allows requests from any origin, with any HTTP method, and any headers.
        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Enable Swagger UI for API documentation in a development environment
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Job Portal API v1");
    });
}

app.UseHttpsRedirection();
app.UseCors("MyCorsPolicy");
app.UseAuthorization();
app.MapControllers();

app.Run();
