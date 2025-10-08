namespace Northwind.DesktopApp.ViewModels;

public class Product
{
  public int ProductId { get; set; }

  public string ProductName { get; set; } = null!;

  public int? CategoryId { get; set; }

  public double? Cost { get; set; }

  public short? Stock { get; set; }

  public bool? Discontinued { get; set; }

  public virtual Category? Category { get; set; }
}
