using ApiZakazUa.Records;

namespace ApiZakazUa;

public partial class ApiWrapper
{
    public Task<IReadOnlySet<Category>?> GetCategoriesAsync(int storeId)
    {
        return Task.Factory.StartNew(() => GetCategories(storeId));
    }

    public Task<IReadOnlySet<Product>?> GetProductsAsync(int storeId, string categoryId)
    {
        return Task.Factory.StartNew(() => GetProducts(storeId, categoryId));
    }

    public Task<IReadOnlySet<Store>?> GetStoresAsync()
    {
        return Task.Factory.StartNew(() => GetStores());
    }
}