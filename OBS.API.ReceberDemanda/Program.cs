var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Teste de Microservi�os com Minimal API");

app.Run();