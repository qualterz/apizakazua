using System.Text.Json.Serialization;

namespace ApiZakazUa.Resources;

public record Category(
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("children")] IReadOnlyList<Category> Children,
    [property: JsonPropertyName("description")] object Description,
    [property: JsonPropertyName("image_url")] string ImageUrl,
    [property: JsonPropertyName("is_collection")] bool IsCollection,
    [property: JsonPropertyName("parent_id")] object ParentId
);