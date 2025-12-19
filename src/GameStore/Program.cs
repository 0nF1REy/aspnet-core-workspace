using GameStore.Dtos;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

const string GetGameEndpointName = "GetName";

List<GameDto> games = [
    new (
        1,
        "The Witcher 3",
        "RPG",
        99.90m,
        new DateOnly(2015, 5, 19)
    ),
    new (
        2,
        "Hollow Knight",
        "Metroidvania",
        46.99m,
        new DateOnly(2017, 2, 24)
    ),
    new (
        3,
        "Stardew Valley",
        "Simulation",
        24.99m,
        new DateOnly(2016, 2, 26)
    )
];

// GET /ping
app.MapGet("/ping", () => "Pong!");

// GET /games
app.MapGet("games", () => games);

// GET /games/1
app.MapGet("games/{id}", (int id) => games.Find(games => games.Id == id))
    .WithName(GetGameEndpointName);

// POST /games
app.MapPost("games", (CreateGameDto newGame) =>
{
    GameDto game = new(
        games.Count + 1,
        newGame.Name,
        newGame.Genre,
        newGame.Price,
        newGame.ReleaseDate
    );

    games.Add(game);

    return Results.CreatedAtRoute(GetGameEndpointName, new { id = game.Id }, game);
});

app.Run();
