using System.Text.Json.Serialization;

namespace ApiZakazUa.Records;

public record Discount(
    [property: JsonPropertyName("status")] bool Status,
    [property: JsonPropertyName("value")] int Value,
    [property: JsonPropertyName("old_price")] int OldPrice,
    [property: JsonPropertyName("due_date")] object DueDate
);

public record Producer(
    [property: JsonPropertyName("trademark")] string Trademark,
    [property: JsonPropertyName("trademark_slug")] string TrademarkSlug,
    [property: JsonPropertyName("website")] string Website,
    [property: JsonPropertyName("name")] string Name
);

public record Quantity(
    [property: JsonPropertyName("min")] int Min,
    [property: JsonPropertyName("step")] int Step,
    [property: JsonPropertyName("is_strict")] bool IsStrict
);

public record Restrictions(
    [property: JsonPropertyName("in_sell_from")] string InSellFrom,
    [property: JsonPropertyName("prohibited_payment_methods")] IReadOnlyList<object> ProhibitedPaymentMethods,
    [property: JsonPropertyName("available_for_delivery_services")] IReadOnlyList<string> AvailableForDeliveryServices
);

public record Product(
    [property: JsonPropertyName("ean")] string Ean,
    [property: JsonPropertyName("sku")] string Sku,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("price")] int Price,
    [property: JsonPropertyName("discount")] Discount Discount,
    [property: JsonPropertyName("bundle")] int Bundle,
    [property: JsonPropertyName("unit")] string Unit,
    [property: JsonPropertyName("volume")] object Volume,
    [property: JsonPropertyName("quantity")] Quantity Quantity,
    [property: JsonPropertyName("currency")] string Currency,
    [property: JsonPropertyName("category_id")] string CategoryId,
    [property: JsonPropertyName("parent_category_id")] string ParentCategoryId,
    [property: JsonPropertyName("description")] string Description,
    [property: JsonPropertyName("slug")] string Slug,
    [property: JsonPropertyName("in_stock")] bool InStock,
    [property: JsonPropertyName("is_hit")] bool IsHit,
    [property: JsonPropertyName("is_alcohol")] bool IsAlcohol,
    [property: JsonPropertyName("is_nicotine")] bool IsNicotine,
    [property: JsonPropertyName("is_ready_meal")] bool IsReadyMeal,
    [property: JsonPropertyName("is_new_product")] bool IsNewProduct,
    [property: JsonPropertyName("horeca_only")] bool HorecaOnly,
    [property: JsonPropertyName("excisable")] bool Excisable,
    [property: JsonPropertyName("web_url")] string WebUrl,
    [property: JsonPropertyName("restrictions")] Restrictions Restrictions,
    [property: JsonPropertyName("ingredients")] IReadOnlyList<object> Ingredients,
    [property: JsonPropertyName("fat")] object Fat,
    [property: JsonPropertyName("shelf_life")] string ShelfLife,
    [property: JsonPropertyName("temperature_range")] string TemperatureRange,
    [property: JsonPropertyName("pack_amount")] object PackAmount,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("producer")] Producer Producer,
    [property: JsonPropertyName("is_uber_item")] bool IsUberItem,
    [property: JsonPropertyName("taxons")] IReadOnlyList<object> Taxons,
    [property: JsonPropertyName("weight")] double Weight,
    [property: JsonPropertyName("has_similar_products")] object HasSimilarProducts
);

public record Products(
    [property: JsonPropertyName("count")] int Count,
    [property: JsonPropertyName("results")] IReadOnlyList<Product> Results,
    [property: JsonPropertyName("categories")] IReadOnlyList<Category> Categories
);