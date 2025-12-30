using Microsoft.EntityFrameworkCore;
using Application.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationContext>(opt =>
opt.UseInMemoryDatabase("Application"));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUi(opt =>
    {
        //options.DocumentPath
    });
}
app.MapGet("/", () => "Hello World!");

app.Run();
