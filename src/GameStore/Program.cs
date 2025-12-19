using GameStore.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Chamadas de métodos de extensão
app.MapGamesEndpoints();
app.MapUtilityEndpoints();

app.Run();
