using Inventory.Api.Data.Configurations;
using Inventory.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Api.Data;

public class InventoryContext(DbContextOptions<InventoryContext> options)
    : DbContext(options)
{
    public DbSet<Item> Items => Set<Item>();

    public DbSet<Category> Categories => Set<Category>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ItemEntityConfiguration).Assembly);
    }
}
