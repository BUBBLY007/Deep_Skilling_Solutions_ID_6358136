var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.MapGet("/api/flights", () => new[]
{
    new { Flight = "IndiGo", From = "Bangaluru", To = "Mumbai", Price = 3000 },
    new { Flight = "Air India", From = "Delhi", To = "Kolkata", Price = 5000 }
});

app.Run();
