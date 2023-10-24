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
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Job Portal API", Version = "v1" });
});

builder.Services.AddDbContext<JobDBContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("conStr"));
});
// builder.Services.AddControllers().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCorsPolicy", builder =>
    {
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
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Job Portal API v1");
    });
}

app.UseHttpsRedirection();
app.UseCors("MyCorsPolicy");
app.UseAuthorization();
app.MapControllers();

app.Run();
