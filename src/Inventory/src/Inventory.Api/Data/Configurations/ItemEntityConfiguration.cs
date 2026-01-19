using Inventory.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inventory.Api.Data.Configurations;

public class ItemEntityConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.Property(item => item.Name)
               .HasMaxLength(50);

        builder.Property(item => item.Description)
               .HasMaxLength(500);

        builder.Property(item => item.Price)
               .HasPrecision(5, 2);
    }
}
