using Northwind.EntityModels; // To use Category entity model.

namespace Northwind.DesktopApp.ViewModels;

public class CategoryViewModel : Category
{
  public string? PicturePath { get => $"avares://Northwind.DesktopApp/Assets/category{CategoryId}-small.jpeg"; }
}
