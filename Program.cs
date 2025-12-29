var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUi(options =>
    {
        //options.DocumentPath
    });
}
app.MapGet("/", () => "Hello World!");

app.Run();
