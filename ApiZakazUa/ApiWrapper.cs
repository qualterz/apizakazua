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

    public IReadOnlySet<Product>? GetProducts(int storeId, string categoryId)
    {
        return client.GetJson<Products>($"stores/{storeId}/categories/{categoryId}/products")?.Results.ToHashSet();
    }

    public IReadOnlySet<Store>? GetStores()
    {
        return client.GetJson<List<Store>>("stores")?.ToHashSet();
    }
}