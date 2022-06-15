using ApiZakazUa.Records;
using RestSharp;

namespace ApiZakazUa;

public class ApiWrapper
{
    readonly RestClient client;


    public ApiWrapper()
    {
        client = new RestClient("https://stores-api.zakaz.ua");
    }

    public IReadOnlySet<Category>? GetCategories(int storeId)
    {
        return client.GetJson<HashSet<Category>>($"stores/{storeId}/categories");
    }

    public IReadOnlySet<Category>? GetCategories()
    {
        var stores = GetStores();

        if (stores == null)
            return null;

        var result = new HashSet<Category>();

        var storeIds = stores.Select(d => d.Id);
        foreach (var id in storeIds) 
        {
            var categories = GetCategories(id);
            if (categories != null)
                result.UnionWith(categories);
        }

        if (result.Any()) return result; else return null;
    }

    public IReadOnlySet<Product>? GetProducts(int storeId, string categoryId)
    {
        return client.GetJson<Products>($"stores/{storeId}/categories/{categoryId}/products")?.Results.ToHashSet();
    }

    public IReadOnlySet<Product>? GetProducts(int storeId)
    {
        var categories = GetCategories(storeId);
        if (categories == null)
            return null;

        var result = new HashSet<Product>();

        var categoryIds = categories.Select(d => d.Id);
        foreach (var id in categoryIds)
        {
            var products = GetProducts(storeId, id);

            if (products != null)
                result.UnionWith(products);
        }

        if (result.Any()) return result; else return null;
    }

    public IReadOnlySet<Product>? GetProducts()
    {
        var stores = GetStores();
        if (stores == null)
            return null;

        var result = new HashSet<Product>();

        var storeIds = stores.Select(d => d.Id);
        foreach (var id in storeIds)
        {
            var products = GetProducts(id);

            if (products != null)
                result.UnionWith(products);
        }

        if (result.Any()) return result; else return null;
    }

    public IReadOnlySet<Store>? GetStores()
    {
        return client.GetJson<List<Store>>("stores")?.ToHashSet();
    }
}