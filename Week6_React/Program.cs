var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddCors();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.MapControllers();

app.Run();
