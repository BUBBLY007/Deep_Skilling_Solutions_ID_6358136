var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());

app.MapGet("/api/offices", () =>
{
    return new[]
    {
        new { Name = "Office One", Rent = 55000, Address = "Mumbai" },
        new { Name = "Office Two", Rent = 65000, Address = "Delhi" },
        new { Name = "Office Three", Rent = 45000, Address = "Bangalore" }
    };
});

app.Run();
