using ApiZakazUa.Records;

namespace ApiZakazUa.Extensions;

/// <summary>
/// High-level methods for wrapper
/// </summary>
/// <remarks>
/// Methods of this class are not optimized, so you may get cooldown due to `too many requests` error
/// </remarks>
public static class WrapperExtensions
{
    public static IReadOnlySet<Category>? GetCategories(this ApiWrapper wrapper)
    {
        var stores = wrapper.GetStores();

        if (stores == null)
            return null;

        var result = new HashSet<Category>();

        var storeIds = stores.Select(d => d.Id);
        foreach (var id in storeIds) 
        {
            var categories = wrapper.GetCategories(id);
            if (categories != null)
                result.UnionWith(categories);
        }

        if (result.Any()) return result; else return null;
    }

    public static IReadOnlySet<Product>? GetProducts(this ApiWrapper wrapper, int storeId)
    {
        var categories = wrapper.GetCategories(storeId);
        if (categories == null)
            return null;

        var result = new HashSet<Product>();

        var categoryIds = categories.Select(d => d.Id);
        foreach (var id in categoryIds)
        {
            var products = wrapper.GetProducts(storeId, id);

            if (products != null)
                result.UnionWith(products);
        }

        if (result.Any()) return result; else return null;
    }

    public static IReadOnlySet<Product>? GetProducts(this ApiWrapper wrapper)
    {
        var stores = wrapper.GetStores();
        if (stores == null)
            return null;

        var result = new HashSet<Product>();

        var storeIds = stores.Select(d => d.Id);
        foreach (var id in storeIds)
        {
            var products = wrapper.GetProducts(id);

            if (products != null)
                result.UnionWith(products);
        }

        if (result.Any()) return result; else return null;
    }
}