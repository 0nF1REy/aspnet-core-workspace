using GameStore.Data;
using GameStore.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

// Chamadas de métodos de extensão
app.MapGamesEndpoints();
app.MapUtilityEndpoints();

app.Run();
