using ApiZakazUa;
using ApiZakazUa.Extensions;
using static ApiZakazUa.Examples.Util;

var wrapper = new ApiWrapper();

// Get set of retail chains
{
    var retailChains = wrapper.GetStores()?
                              .Select(d => d.RetailChain)
                              .Distinct();

    var retailChainsOutput = retailChains == null ? "no retail chains" : SeparateWithComma(retailChains);

    Console.WriteLine("Retail Chains: " + retailChainsOutput);
}

// Get all existing categories
{
    var existingCategories = wrapper.GetCategories()?
                                    .Select(d => d.Title)
                                    .Distinct();

    var categoriesOutput = existingCategories == null ? "no categories" : SeparateWithComma(existingCategories);

    Console.WriteLine("Categories: " + categoriesOutput);
}

// Get products from all stores
{
    var allProducts = wrapper.GetProducts()?
                             .Select(d => d.Title)
                             .Distinct();
    
    var productsOutput = allProducts == null ? "no products" : SeparateWithComma(allProducts);

    Console.WriteLine("Products: " + productsOutput);
}