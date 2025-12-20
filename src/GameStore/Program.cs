using GameStore.Data;
using GameStore.Endpoints;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("GameStore");

builder.Services.AddSqlite<GameStoreContext>(connString);

var app = builder.Build();

// Map endpoints
app.MapGamesEndpoints();
app.MapUtilityEndpoints();

app.MigrateDb();

app.Run();
