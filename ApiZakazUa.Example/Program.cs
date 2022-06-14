using ApiZakazUa;

var wrapper = new ApiWrapper();

var retailChains = wrapper.GetStores()
    .Select(d => d.RetailChain)
    .Distinct();

Console.WriteLine("Retail Chains: " + string.Join(", ", retailChains));