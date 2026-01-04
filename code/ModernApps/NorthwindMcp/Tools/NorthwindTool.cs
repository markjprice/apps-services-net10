using Microsoft.EntityFrameworkCore; // To use .Include() extension method.
using ModelContextProtocol.Server; // To use [McpServerToolType] and [McpServerTool].
using Northwind.EntityModels; // To use NorthwindContext.
using System.ComponentModel; // To use [Description].
using System.Text.Json; // To use JsonSerializer.

[McpServerToolType]
public static class NorthwindTool
{
  // It is more efficient to cache this than create it every time.
  private static JsonSerializerOptions jsonSerializerOptions =
    new() { WriteIndented = true };

  [McpServerTool]
  [Description("Responds with all products or the products in a specified category.")]
  public static string Products(string? categoryName = null)
  {
    using NorthwindContext db = new();

    IEnumerable<Product> products = db.Products
      .Include(p => p.Category);

    if (!string.IsNullOrEmpty(categoryName))
    {
      products = products.Where(p => p.Category!.CategoryName == categoryName);
    }

    var filteredProducts = products
      .Select(p => new
      {
        p.ProductId,
        p.ProductName,
        p.Category!.CategoryName,
        p.UnitPrice,
        p.UnitsInStock,
        p.UnitsOnOrder,
        p.Discontinued
      })
      .ToArray();

    // Convert the array of products to a JSON string.
    string json = JsonSerializer.Serialize(
      filteredProducts, jsonSerializerOptions);

    return json;
  }
}
