using Northwind.DesktopApp.ViewModels; // To use Category.
using System.IO; // To use File.
using System.Text.Json; // To use JsonSerializer.
using System.Text.Json.Serialization; // To use ReferenceHandler.

namespace Northwind.DesktopApp.Services;

public static class DataService
{
  public static Category[]? LoadCategories()
  {
    string fileName = "categories-and-products.json";
    string directory = Directory.GetCurrentDirectory();

    // In design mode, current directory is the Chapter03 solution
    // directory so adjust to the project directory.
    if (!File.Exists(Path.Combine(directory, fileName)))
    {
      directory = Path.Combine(directory, "Northwind.DesktopApp");
    }

    string path = Path.Combine(directory, fileName);
    string json = File.ReadAllText(path);

    // Preserve object graph references to avoid circular references.
    Category[]? categories = JsonSerializer.Deserialize<Category[]>(
      json, new JsonSerializerOptions 
        { ReferenceHandler = ReferenceHandler.Preserve });

    return categories;
  }
}