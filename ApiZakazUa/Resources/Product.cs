using System.Text.Json.Serialization;

namespace ApiZakazUa.Resources;

public record Discount(
    [property: JsonPropertyName("status")] bool Status,
    [property: JsonPropertyName("value")] int Value,
    [property: JsonPropertyName("old_price")] int OldPrice,
    [property: JsonPropertyName("due_date")] object DueDate
);

public record Gallery(
    [property: JsonPropertyName("s150x150")] string S150x150,
    [property: JsonPropertyName("s200x200")] string S200x200,
    [property: JsonPropertyName("s350x350")] string S350x350,
    [property: JsonPropertyName("s1350x1350")] string S1350x1350
);

public record Image(
    [property: JsonPropertyName("s150x150")] string S150x150,
    [property: JsonPropertyName("s200x200")] string S200x200,
    [property: JsonPropertyName("s350x350")] string S350x350,
    [property: JsonPropertyName("s1350x1350")] string S1350x1350
);

public record Logo(
    [property: JsonPropertyName("s16x16")] string S16x16,
    [property: JsonPropertyName("s32x32")] string S32x32,
    [property: JsonPropertyName("s64x64")] string S64x64
);

public record NutritionFacts(
    [property: JsonPropertyName("ingredient_energy")] string IngredientEnergy,
    [property: JsonPropertyName("ingredient_protein")] string IngredientProtein,
    [property: JsonPropertyName("ingredient_fat")] string IngredientFat,
    [property: JsonPropertyName("ingredient_carbohydrates")] string IngredientCarbohydrates
);

public record Quantity(
    [property: JsonPropertyName("min")] int Min,
    [property: JsonPropertyName("step")] int Step,
    [property: JsonPropertyName("is_strict")] bool IsStrict
);

public record Producer(
    [property: JsonPropertyName("trademark")] string Trademark,
    [property: JsonPropertyName("trademark_slug")] string TrademarkSlug,
    [property: JsonPropertyName("website")] string Website,
    [property: JsonPropertyName("logo")] Logo Logo,
    [property: JsonPropertyName("name")] string Name
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
    [property: JsonPropertyName("volume")] double? Volume,
    [property: JsonPropertyName("quantity")] Quantity Quantity,
    [property: JsonPropertyName("currency")] string Currency,
    [property: JsonPropertyName("category_id")] string CategoryId,
    [property: JsonPropertyName("parent_category_id")] string ParentCategoryId,
    [property: JsonPropertyName("description")] string Description,
    [property: JsonPropertyName("nutrition_facts")] NutritionFacts NutritionFacts,
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
    [property: JsonPropertyName("ingredients")] IReadOnlyList<string> Ingredients,
    [property: JsonPropertyName("fat")] object Fat,
    [property: JsonPropertyName("shelf_life")] string ShelfLife,
    [property: JsonPropertyName("temperature_range")] string TemperatureRange,
    [property: JsonPropertyName("pack_amount")] object PackAmount,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("producer")] Producer Producer,
    [property: JsonPropertyName("custom_ribbons")] IReadOnlyList<object> CustomRibbons,
    [property: JsonPropertyName("img")] Image Image,
    [property: JsonPropertyName("gallery")] IReadOnlyList<Gallery> Gallery,
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