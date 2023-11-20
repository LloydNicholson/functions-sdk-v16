using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(p => p.SwaggerDoc(
    name: "v1",
    new OpenApiInfo
    {
        Description = "Wow",
    }));

var app = builder.Build();
app
    .UseSwagger()
    .UseSwaggerUI();

app.MapGet("/",
        ([AsParameters] NewObj obj) => new NewObj(Amount: 2).ToString())
    .WithOpenApi();

app.Run();

public record NewObj(decimal Amount)
{
    protected string WowDude { get; private set; } = "Wow";
    public string WowDude1 { get; private set; } = "Wow Cool";
}
