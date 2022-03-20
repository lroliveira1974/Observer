var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Teste de Microserviços com Minimal API");

app.Run();