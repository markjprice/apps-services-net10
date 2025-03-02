using System.Collections.Generic; // To use ICollection<T>.

namespace Northwind.DesktopApp.ViewModels;

public class Category
{
  public int CategoryId { get; set; }

  public string CategoryName { get; set; } = null!;

  public string? Description { get; set; }

  public string? PicturePath { get => $"avares://Northwind.DesktopApp/Assets/category{CategoryId}-small.jpeg"; }

  public virtual ICollection<Product> Products { get; set; } = [];
}
