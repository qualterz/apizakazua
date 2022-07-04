using ApiZakazUa;
using ApiZakazUa.Extensions;
using static ApiZakazUa.Examples.Util;

var client = new Client();

// Get set of retail chains
{
    var retailChains = client.GetStores()?
                              .Select(d => d.RetailChain)
                              .Distinct();

    var retailChainsOutput = retailChains == null ? "no retail chains" : SeparateWithComma(retailChains);

    Console.WriteLine("Retail Chains: " + retailChainsOutput);
}

// Get all existing categories
{
    var existingCategories = client.GetCategories()?
                                    .Select(d => d.Title)
                                    .Distinct();

    var categoriesOutput = existingCategories == null ? "no categories" : SeparateWithComma(existingCategories);

    Console.WriteLine("Categories: " + categoriesOutput);
}

// Get products from all stores
{
    var allProducts = client.GetProducts()?
                             .Select(d => d.Title)
                             .Distinct();
    
    var productsOutput = allProducts == null ? "no products" : SeparateWithComma(allProducts);

    Console.WriteLine("Products: " + productsOutput);
}