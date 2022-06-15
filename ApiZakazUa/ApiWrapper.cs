using ApiZakazUa.Records;
using RestSharp;

namespace ApiZakazUa;

public class ApiWrapper : IApiWrapper
{
    readonly RestClient client;

    public ApiWrapper()
    {
        client = new RestClient("https://stores-api.zakaz.ua");
    }

    public List<Category> GetCategories(int StoreId)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetCategories()
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts(int CategoryId)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetProducts()
    {
        throw new NotImplementedException();
    }

    public List<Store> GetStores()
    {
        return client.GetJson<List<Store>>("stores");
    }
}
