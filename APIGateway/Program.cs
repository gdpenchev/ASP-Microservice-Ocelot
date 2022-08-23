using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddOcelot();

var app = builder.Build();
//comment
app.UseOcelot();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
