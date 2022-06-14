using ApiZakazUa.Records;

namespace ApiZakazUa;

public interface IApiWrapper
{
    List<Store> GetStores();
    List<Category> GetCategories(int StoreId);
    List<Category> GetCategories();
    List<Product> GetProducts(int CategoryId);
    List<Product> GetProducts();
}