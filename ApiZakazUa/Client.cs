using System.Collections;
using System.Net.Http.Json;
using ApiZakazUa.Resources;

namespace ApiZakazUa;

public class HttpClientWrapper
{
    public const string DefaultBaseAddress = "https://stores-api.zakaz.ua";

    public const string StoresEndpoint = "stores";
    public const string StoreCategoriesEndpoint = "stores/{0}/categories";
    public const string StoreCategoryProductsEndpoint = "stores/{0}/categories/{1}/products?page={2}";

    public HttpClient HttpClient { get; set; }
    public Uri? BaseAddress => HttpClient.BaseAddress;

    public HttpClientWrapper(Uri baseAddress)
    {
        HttpClient = new()
        {
            BaseAddress = baseAddress
        };
    }

    public HttpClientWrapper(string baseAddress) : this(new Uri(baseAddress))
    {
    }

    public HttpClientWrapper() : this(DefaultBaseAddress)
    {
    }

    public HttpClientWrapper(HttpClient httpClient)
    {
        HttpClient = httpClient;
    }

    public Task<IEnumerable<Store>?> GetStoresAsync(
        CancellationToken cancellationToken = default)
    {
        return HttpClient.GetFromJsonAsync<IEnumerable<Store>>(
            StoresEndpoint, cancellationToken);
    }

    public Task<IEnumerable<Category>?> GetCategoriesAsync(
        int storeId, CancellationToken cancellationToken = default)
    {
        return HttpClient.GetFromJsonAsync<IEnumerable<Category>>(
            string.Format(StoreCategoriesEndpoint, storeId), cancellationToken);
    }

    public Task<Products?> GetProductsAsync(
        int storeId, string categoryId, int page, CancellationToken cancellationToken = default)
    {
        return HttpClient.GetFromJsonAsync<Products>(
            string.Format(StoreCategoryProductsEndpoint, storeId, categoryId, page), cancellationToken);
    }
}