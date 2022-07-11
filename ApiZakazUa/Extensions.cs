using ApiZakazUa.Resources;

namespace ApiZakazUa.Extensions;

/// <summary>
/// High-level methods for wrapper
/// </summary>
/// <remarks>
/// Methods of this class are not optimized, so you may get cooldown due to `too many requests` error
/// </remarks>
public static class WrapperExtensions
{
    public static IReadOnlySet<Category>? GetCategories(this Client client)
    {
        var stores = client.GetStores();

        if (stores == null)
            return null;

        var result = new HashSet<Category>();

        var storeIds = stores.Select(d => d.Id);
        foreach (var id in storeIds)
        {
            var categories = client.GetCategories(id);
            if (categories != null)
                result.UnionWith(categories);
        }

        if (result.Any()) return result; else return null;
    }

    public static IReadOnlySet<Product>? GetProducts(this Client client, int storeId)
    {
        var categories = client.GetCategories(storeId);
        if (categories == null)
            return null;

        var result = new HashSet<Product>();

        var categoryIds = categories.Select(d => d.Id);
        foreach (var id in categoryIds)
        {
            var products = client.GetProducts(storeId, id);

            if (products != null)
                result.UnionWith(products);
        }

        if (result.Any()) return result; else return null;
    }

    public static IReadOnlySet<Product>? GetProducts(this Client client)
    {
        var stores = client.GetStores();
        if (stores == null)
            return null;

        var result = new HashSet<Product>();

        var storeIds = stores.Select(d => d.Id);
        foreach (var id in storeIds)
        {
            var products = client.GetProducts(id);

            if (products != null)
                result.UnionWith(products);
        }

        if (result.Any()) return result; else return null;
    }
}