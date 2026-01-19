using Inventory.Api.Data;
using Inventory.Api.Features.Items.CreateItem;
using Inventory.Api.Features.Items.DeleteItem;
using Inventory.Api.Features.Items.GetItem;
using Inventory.Api.Features.Items.GetItems;
using Inventory.Api.Features.Items.UpdateItem;
using Inventory.Api.Models;

namespace Inventory.Api.Features.Items;

public static class ItemsEndpoints
{
    public static void MapItems(this IEndpointRouteBuilder app)
    {
        var group = app.MapGroup("/items");

        group.MapGetItems();
        group.MapGetItem();
        group.MapCreateItem();
        group.MapUpdateItem();
        group.MapDeleteItem();
    }
}
