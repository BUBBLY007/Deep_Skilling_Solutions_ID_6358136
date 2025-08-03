var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod());

app.MapGet("/api/convert", (double rupees) =>
{
    double euroRate = 0.011;
    double euros = rupees * euroRate;
    return Results.Ok(new { Rupees = rupees, Euros = euros });
});

app.Run();
