using Microsoft.EntityFrameworkCore;
using GameStore.Entities;

namespace GameStore.Data;

public class GameStoreContext : DbContext
{
    public GameStoreContext(DbContextOptions<GameStoreContext> options)
        : base(options)
    {
    }

    public DbSet<Game> Games => Set<Game>();

    public DbSet<Genre> Genres => Set<Genre>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Genre>().HasData(
            new { Id = 1, Name = "Fighting" },
            new { Id = 2, Name = "Action" },
            new { Id = 3, Name = "Adventure" },
            new { Id = 4, Name = "RPG" },
            new { Id = 5, Name = "Shooter" },
            new { Id = 6, Name = "Sports" },
            new { Id = 7, Name = "Racing" },
            new { Id = 8, Name = "Strategy" },
            new { Id = 9, Name = "Simulation" },
            new { Id = 10, Name = "Puzzle" },
            new { Id = 11, Name = "Horror" },
            new { Id = 12, Name = "Platformer" },
            new { Id = 13, Name = "MMO" }
        );
    }
}
