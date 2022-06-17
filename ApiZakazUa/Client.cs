using ApiZakazUa.Resources;
using RestSharp;

namespace ApiZakazUa;

public partial class Client
{
    readonly RestClient client;

    public Client()
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