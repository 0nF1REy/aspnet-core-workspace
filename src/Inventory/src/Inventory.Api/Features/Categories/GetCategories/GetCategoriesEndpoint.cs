using Inventory.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Api.Features.Categories.GetCategories;

public static class GetCategoriesEndpoint
{
    public static void MapGetCategories(this IEndpointRouteBuilder app)
    {
        // GET /categories
        app.MapGet("/", async (InventoryContext dbContext) =>
            await dbContext.Categories
                     .Select(category => new CategoryDto(category.Id, category.Name))
                     .AsNoTracking()
                     .ToListAsync())
        .Produces<List<CategoryDto>>();
    }
}
