namespace ApiZakazUa.Resources;

using System.Text.Json.Serialization;

public record Address(
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("street")] string Street,
    [property: JsonPropertyName("building")] string Building
);

public record OpeningHours(
    [property: JsonPropertyName("from")] string From,
    [property: JsonPropertyName("to")] string To
);

public record Store(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("retail_chain")] string RetailChain,
    [property: JsonPropertyName("region_id")] string RegionId,
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("phones")] IReadOnlyList<string> Phones,
    [property: JsonPropertyName("address")] Address Address,
    [property: JsonPropertyName("coords")] string Coords,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("delivery_types")] IReadOnlyList<string> DeliveryTypes,
    [property: JsonPropertyName("payment_types")] IReadOnlyList<string> PaymentTypes,
    [property: JsonPropertyName("opening_hours")] OpeningHours OpeningHours
);