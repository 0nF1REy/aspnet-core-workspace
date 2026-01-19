using Inventory.Api.Data;
using Inventory.Api.Features.Items.Constants;
using Inventory.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Api.Features.Items.GetItem;

public static class GetItemEndpoint
{
    public static void MapGetItem(this IEndpointRouteBuilder app)
    {
        // GET /items/122233-434d-43434....
        app.MapGet("/{id}", async (
            Guid id,
            InventoryContext dbContext,
            ILogger<Program> logger) =>
        {
            Item? item = await dbContext.Items.FindAsync(id);

            return item is null ? Results.NotFound() : Results.Ok(
                                new ItemDetailsDto(
                                    item.Id,
                                    item.Name,
                                    item.CategoryId,
                                    item.Price,
                                    item.ReleaseDate,
                                    item.Description,
                                    item.LastUpdatedBy
                                ));
        })
        .WithName(EndpointNames.GetItem)
        .Produces<ItemDetailsDto>()
        .Produces(StatusCodes.Status404NotFound);
    }
}
