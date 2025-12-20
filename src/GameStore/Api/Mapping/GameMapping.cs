using GameStore.Api.Dtos;
using GameStore.Api.Entities;

namespace GameStore.Api.Mapping;

public static class GameMapping
{
    // Converte CreateGameDto para Game
    public static Game ToEntity(this CreateGameDto game)
    {
        return new Game
        {
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    // Converte UpdateGameDto para Game, incluindo Id
    public static Game ToEntity(this UpdateGameDto game, int id)
    {
        return new Game
        {
            Id = id,
            Name = game.Name,
            GenreId = game.GenreId,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };
    }

    // Converte Game para GameSummaryDto
    public static GameSummaryDto ToGameSummaryDto(this Game game)
    {
        return new GameSummaryDto(
            game.Id,
            game.Name,
            game.Genre!.Name,
            game.Price,
            game.ReleaseDate
        );
    }

    // Converte Game para GameDetailsDto
    public static GameDetailsDto ToGameDetailsDto(this Game game)
    {
        return new GameDetailsDto(
            game.Id,
            game.Name,
            game.GenreId,
            game.Price,
            game.ReleaseDate
        );
    }
}
